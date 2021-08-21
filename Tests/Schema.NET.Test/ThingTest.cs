namespace Schema.NET.Test
{
    using System;
    using Xunit;

    public class ThingTest
    {
        private readonly Thing thing = new()
        {
            Name = "New Object",
            Description = "This is the description of a new object we can't deserialize",
            Image = new Uri("https://example.com/image.jpg"),
        };

        private readonly string json =
            "{" +
                "\"@context\":\"https://schema.org\"," +
                "\"@type\":\"NewObject\"," +
                "\"name\":\"New Object\"," +
                "\"description\":\"This is the description of a new object we can't deserialize\"," +
                "\"image\":\"https://example.com/image.jpg\"," +
                "\"someProperty\":\"not supported\"" +
            "}";

        [Fact]
        public void Deserializing_NewObjectJsonLd_ReturnsThing() =>
            Assert.Equal(
                this.thing.ToString(),
                SchemaSerializer.DeserializeObject<Thing>(this.json)!.ToString());

        [Fact]
        public void Equality_AreEqual_Default() => CompareEqual(new Thing(), new Thing());

        [Fact]
        public void Equality_AreEqual_SinglePropertyValue() => CompareEqual(
            new Thing
            {
                Name = "Custom Name",
            },
            new Thing
            {
                Name = "Custom Name",
            });

        [Fact]
        public void Equality_AreEqual_MultiPropertyValue() => CompareEqual(
            new Thing
            {
                Name = "Custom Name",
                Url = new Uri("https://schema.net"),
            },
            new Thing
            {
                Name = "Custom Name",
                Url = new Uri("https://schema.net"),
            });

        [Fact]
        public void Equality_AreNotEqual_Null() => CompareNotEqual(
            new Thing
            {
                Name = "A",
            },
            null!);

        [Fact]
        public void Equality_AreNotEqual_SinglePropertyValue() => CompareNotEqual(
            new Thing
            {
                Name = "A",
            },
            new Thing
            {
                Name = "B",
            });

        [Fact]
        public void Equality_AreNotEqual_MultiPropertyValue() => CompareNotEqual(
            new Thing
            {
                Name = "A",
                Url = new Uri("https://schema.net"),
            },
            new Thing
            {
                Name = "B",
                Url = new Uri("https://schema.net/Thing"),
            });

        [Fact]
        public void Equality_AreNotEqual_DifferentTypes_SameBaseProperties() => CompareNotEqual(
            new Thing
            {
                Name = "Person Name",
                Url = new Uri("https://schema.net"),
            },
            new Person
            {
                Name = "Person Name",
                Url = new Uri("https://schema.net"),
            });

        [Fact]
        public void Equality_AreEqual_SameDerivedType_SameBaseProperties() => CompareEqual(
            new Person
            {
                Name = "Person Name",
                Url = new Uri("https://schema.net"),
            },
            new Person
            {
                Name = "Person Name",
                Url = new Uri("https://schema.net"),
            });

        [Fact]
        public void Equality_AreEqual_SameDerivedType_SameDerivedProperties() => CompareEqual(
            new Person
            {
                AdditionalName = "Extra Name",
            },
            new Person
            {
                AdditionalName = "Extra Name",
            });

        [Fact]
        public void Equality_AreNotEqual_SameDerivedType_DifferentBaseProperties() => CompareNotEqual(
            new Person
            {
                Name = "A",
            },
            new Person
            {
                Name = "B",
            });

        [Fact]
        public void Equality_AreNotEqual_SameDerivedType_DifferentDerivedProperties() => CompareNotEqual(
            new Person
            {
                AdditionalName = "A",
            },
            new Person
            {
                AdditionalName = "B",
            });

        [Fact]
        public void ToString_UnsafeStringData_ReturnsExpectedJsonLd()
        {
            var expectedJson =
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Thing\"," +
                    "\"name\":\"Test</script><script>alert('gotcha');</script>\"" +
                "}";

            var thing = new Thing
            {
                Name = "Test</script><script>alert('gotcha');</script>",
            };

            Assert.Equal(expectedJson, thing.ToString());
        }

        [Fact]
        public void ToHtmlEscapedString_UnsafeStringData_ReturnsExpectedJsonLd()
        {
            var expectedJson =
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Thing\"," +
                    "\"name\":\"Test\\u003c/script\\u003e\\u003cscript\\u003ealert(\\u0027gotcha\\u0027);\\u003c/script\\u003e\"" +
                "}";

            var thing = new Thing
            {
                Name = "Test</script><script>alert('gotcha');</script>",
            };

            Assert.Equal(expectedJson, thing.ToHtmlEscapedString());
        }

        [Fact]
        public void ToStringWithNullAssignedProperty_ReturnsExpectedJsonLd()
        {
            var expectedJson =
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Thing\"" +
                "}";

            var thing = new Thing
            {
                Name = (string)null!,
            };

            Assert.Equal(expectedJson, thing.ToString());
        }

        [Fact]
        public void TrySetValue_ValidProperty()
        {
            var thing = new Thing();

            Assert.True(thing.TrySetValue("Name", new[] { "TestName" }));
            Assert.Equal("TestName", thing.Name);
        }

        [Fact]
        public void TrySetValue_InvalidProperty()
        {
            var thing = new Thing();

            Assert.False(thing.TrySetValue("InvalidName", new[] { "TestName" }));
        }

        [Fact]
        public void TrySetValue_CaseInsensitive()
        {
            var thing = new Thing();

            Assert.True(thing.TrySetValue("name", new[] { "TestName" }));
            Assert.Equal("TestName", thing.Name);
        }

        [Fact]
        public void TryGetValue_ValidProperty_OneOrMany()
        {
            var thing = new Thing
            {
                Name = "TestName",
            };

            Assert.True(thing.TryGetValue<string>("Name", out var result));
            Assert.Equal("TestName", result);
        }

        [Fact]
        public void TryGetValue_ValidProperty_Values()
        {
            var thing = new Thing
            {
                Identifier = new Uri("https://example.org/test-identifier"),
            };

            Assert.True(thing.TryGetValue<Uri>("Identifier", out var result));
            var identifier = Assert.Single(result);
            Assert.Equal(new Uri("https://example.org/test-identifier"), identifier);
        }

        [Fact]
        public void TryGetValue_InvalidProperty_InvalidName()
        {
            var thing = new Thing();

            Assert.False(thing.TryGetValue<string>("InvalidName", out _));
        }

        [Fact]
        public void TryGetValue_InvalidProperty_InvalidType()
        {
            var thing = new Thing
            {
                Name = "TestName",
            };

            Assert.False(thing.TryGetValue<Uri>("Name", out _));
        }

        [Fact]
        public void TryGetValue_CaseInsensitive()
        {
            var thing = new Thing
            {
                Name = "TestName",
            };

            Assert.True(thing.TryGetValue<string>("name", out var result));
            Assert.Equal("TestName", result);
        }

        private static void CompareEqual<T>(T a, T? b)
        {
            Assert.NotNull(a);
            Assert.Equal(a!.GetHashCode(), b?.GetHashCode());
            Assert.True(a.Equals(b));
        }

        private static void CompareNotEqual<T>(T a, T? b)
        {
            Assert.NotNull(a);
            Assert.NotEqual(a!.GetHashCode(), b?.GetHashCode());
            Assert.False(a.Equals(b));
        }
    }
}
