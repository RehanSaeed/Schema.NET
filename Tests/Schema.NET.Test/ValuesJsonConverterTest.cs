namespace Schema.NET.Test
{
    using System;
    using System.Linq;
    using Newtonsoft.Json;
    using Xunit;

    public class ValuesJsonConverterTest
    {
        [Fact]
        public void WriteJson_Values_ZeroCountWritesNull()
        {
            var value = default(Values<int?, string>);
            var json = this.SerializeObject(value);
            Assert.Equal("{\"Property\":null}", json);
        }

        [Fact]
        public void WriteJson_Values_OneCountWritesSingle()
        {
            var value = new Values<int?, string>("One Value");
            var json = this.SerializeObject(value);
            Assert.Equal("{\"Property\":\"One Value\"}", json);
        }

        [Fact]
        public void WriteJson_Values_GreaterThanOneCountWritesArray()
        {
            var value = new Values<int?, string>(new[] { "A", "B" });
            var json = this.SerializeObject(value);
            Assert.Equal("{\"Property\":[\"A\",\"B\"]}", json);
        }

        [Fact]
        public void WriteJson_Values_MixedValueTypes()
        {
            var value = new Values<int?, string>(new object[] { 123, "B" });
            var json = this.SerializeObject(value);
            Assert.Equal("{\"Property\":[123,\"B\"]}", json);
        }

        [Fact]
        public void WriteJson_OneOrMany_ZeroCountWritesNull()
        {
            var value = default(OneOrMany<string>);
            var json = this.SerializeObject(value);
            Assert.Equal("{\"Property\":null}", json);
        }

        [Fact]
        public void WriteJson_OneOrMany_OneCountWritesSingle()
        {
            var value = new OneOrMany<string>("One Value");
            var json = this.SerializeObject(value);
            Assert.Equal("{\"Property\":\"One Value\"}", json);
        }

        [Fact]
        public void WriteJson_OneOrMany_GreaterThanOneCountWritesArray()
        {
            var value = new OneOrMany<string>(new[] { "A", "B" });
            var json = this.SerializeObject(value);
            Assert.Equal("{\"Property\":[\"A\",\"B\"]}", json);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_String()
        {
            var json = "{\"Property\":\"Test String\"}";
            var result = this.DeserializeObject<Values<int, string>>(json);
            Assert.Equal("Test String", result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_IntegerAsString()
        {
            var json = "{\"Property\":\"123\"}";
            var result = this.DeserializeObject<Values<string, int>>(json);
            Assert.Equal(123, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_LongAsString()
        {
            var json = "{\"Property\":\"8294967295\"}";
            var result = this.DeserializeObject<Values<string, long>>(json);
            Assert.Equal(8294967295, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_FloatAsString()
        {
            var json = "{\"Property\":\"123.45\"}";
            var result = this.DeserializeObject<Values<string, float>>(json);
            Assert.Equal(123.45f, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DoubleAsString()
        {
            var json = "{\"Property\":\"123.45\"}";
            var result = this.DeserializeObject<Values<string, double>>(json);
            Assert.Equal(123.45, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_BooleanAsString()
        {
            var json = "{\"Property\":\"true\"}";
            var result = this.DeserializeObject<Values<string, bool>>(json);
            Assert.True(result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_NullablePrimitiveAsString()
        {
            var json = "{\"Property\":\"123\"}";
            var result = this.DeserializeObject<Values<string, int?>>(json);
            Assert.Equal(123, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Primitive()
        {
            var json = "{\"Property\":123}";
            var result = this.DeserializeObject<Values<string, int>>(json);
            Assert.Equal(123, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DecimalAsString()
        {
            var json = "{\"Property\":\"123.456\"}";
            var result = this.DeserializeObject<Values<string, decimal>>(json);
            Assert.Equal(123.456m, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Decimal()
        {
            var json = "{\"Property\":123.456}";
            var result = this.DeserializeObject<Values<string, decimal>>(json);
            Assert.Equal(123.456m, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeAsISO8601String()
        {
            var json = "{\"Property\":\"2000-01-01T12:34\"}";
            var result = this.DeserializeObject<Values<string, DateTime>>(json);
            Assert.Equal(new DateTime(2000, 1, 1, 12, 34, 0), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeAsMicrosoftDateTimeString()
        {
            var json = "{\"Property\":\"\\/Date(946730040000)\\/\"}";
            var result = this.DeserializeObject<Values<string, DateTime>>(json);
            Assert.Equal(new DateTime(2000, 1, 1, 12, 34, 0), result.Value2.First());
        }

        [Fact(Skip = "MS DateTime string conversion doesn't support offset - this should be fixed")]
        public void ReadJson_Values_SingleValue_DateTimeOffsetAsMicrosoftDateTimeString()
        {
            var json = "{\"Property\":\"\\/Date(946730040000-0100)\\/\"}";
            var result = this.DeserializeObject<Values<string, DateTimeOffset>>(json);
            Assert.Equal(new DateTimeOffset(2000, 1, 1, 12, 34, 0, TimeSpan.FromHours(1)), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeOffsetAsISO8601String()
        {
            var json = "{\"Property\":\"2000-01-01T12:34:00+01:00\"}";
            var result = this.DeserializeObject<Values<string, DateTimeOffset>>(json);
            Assert.Equal(new DateTimeOffset(2000, 1, 1, 12, 34, 0, TimeSpan.FromHours(1)), result.Value2.First());
        }

        [Fact]
        public void ReadJson_ParseValueToken_UriAsString()
        {
            var json = "{\"Property\":\"https://schema.org/Thing\"}";
            var result = this.DeserializeObject<Values<string, Uri>>(json);
            Assert.Equal(new Uri("https://schema.org/Thing"), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_ThingInterface()
        {
            var json = "{\"Property\":" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Book\"," +
                    "\"@id\":\"http://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"http://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}" +
            "}";
            var result = this.DeserializeObject<Values<string, IBook>>(json);
            var actual = result.Value2.First();

            Assert.Equal(new Uri("http://example.com/book/1"), ((Book)actual).Id);
            Assert.Equal("The Catcher in the Rye", actual.Name);
            Assert.Equal(new Uri("http://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual.Url);
            var author = Assert.Single(actual.Author.Value2);
            Assert.Equal("J.D. Salinger", author.Name);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_ThingActual()
        {
            var json = "{\"Property\":" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Book\"," +
                    "\"@id\":\"http://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"http://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}" +
            "}";
            var result = this.DeserializeObject<Values<string, Book>>(json);
            var actual = result.Value2.First();

            Assert.Equal(new Uri("http://example.com/book/1"), actual.Id);
            Assert.Equal("The Catcher in the Rye", actual.Name);
            Assert.Equal(new Uri("http://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual.Url);
            var author = Assert.Single(actual.Author.Value2);
            Assert.Equal("J.D. Salinger", author.Name);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_ThingInterfaceWithNoTypeToken()
        {
            var json = "{\"Property\":" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@id\":\"http://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"http://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}" +
            "}";
            var result = this.DeserializeObject<Values<string, IBook>>(json);
            Assert.Empty(result.Value2);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_ThingActualWithNoTypeToken()
        {
            var json = "{\"Property\":" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@id\":\"http://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"http://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}" +
            "}";
            var result = this.DeserializeObject<Values<string, Book>>(json);
            var actual = result.Value2.First();

            Assert.Equal(new Uri("http://example.com/book/1"), actual.Id);
            Assert.Equal("The Catcher in the Rye", actual.Name);
            Assert.Equal(new Uri("http://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual.Url);
            var author = Assert.Single(actual.Author.Value2);
            Assert.Equal("J.D. Salinger", author.Name);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Enum_NoUrl()
        {
            var json = "{\"Property\":\"InStock\"}";
            var result = this.DeserializeObject<Values<string, ItemAvailability>>(json);
            Assert.Equal(ItemAvailability.InStock, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Enum_HttpSchema()
        {
            var json = "{\"Property\":\"http://schema.org/InStock\"}";
            var result = this.DeserializeObject<Values<string, ItemAvailability>>(json);
            Assert.Equal(ItemAvailability.InStock, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Enum_HttpsSchema()
        {
            var json = "{\"Property\":\"https://schema.org/InStock\"}";
            var result = this.DeserializeObject<Values<string, ItemAvailability>>(json);
            Assert.Equal(ItemAvailability.InStock, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_MultiValue_SameType()
        {
            var json = "{\"Property\":[\"A\",\"B\"]}";
            var result = this.DeserializeObject<Values<int, string>>(json);
            Assert.Equal(new[] { "A", "B" }, result.Value2);
        }

        [Fact(Skip = "The ordering of the types shouldn't matter - this should be fixed")]
        public void ReadJson_Values_MultiValue_SameType_ArgumentsSwapped()
        {
            var json = "{\"Property\":[\"A\",\"B\"]}";
            var result = this.DeserializeObject<Values<string, int>>(json);
            Assert.Equal(new[] { "A", "B" }, result.Value1);
        }

        [Fact(Skip = "Mixed types doesn't work - this should be fixed")]
        public void ReadJson_Values_MultiValue_MixedType()
        {
            var json = "{\"Property\":[1,\"B\"]}";
            var result = this.DeserializeObject<Values<int, string>>(json);
            Assert.Equal(new[] { 1 }, result.Value1);
            Assert.Equal(new[] { "B" }, result.Value2);
        }

        [Fact(Skip = "An array of nullable primitive values isn't handled properly, passed as non-primitive to OneOrMany constructor - this needs to be fixed")]
        public void ReadJson_Values_MultiValue_NullablePrimitiveAsString()
        {
            var json = "{\"Property\":[\"123\",\"456\"]}";
            var result = this.DeserializeObject<Values<string, int?>>(json);
            Assert.Equal(new int?[] { 123, 456 }, result.Value2);
        }

        [Fact]
        public void ReadJson_Values_MultiValue_ThingInterface()
        {
            var json = "{\"Property\":[" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Book\"," +
                    "\"@id\":\"http://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"http://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}," +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Book\"," +
                    "\"@id\":\"http://example.com/book/2\"," +
                    "\"name\":\"The Lord of the Rings\"," +
                    "\"url\":\"http://www.barnesandnoble.com/store/info/offer/JRRTolkien\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.R.R. Tolkien\"" +
                    "}," +
                "}" +
            "]}";
            var result = this.DeserializeObject<Values<string, IBook>>(json);
            var actual = result.Value2.ToArray();

            Assert.Equal(new Uri("http://example.com/book/1"), ((Book)actual[0]).Id);
            Assert.Equal("The Catcher in the Rye", actual[0].Name);
            Assert.Equal(new Uri("http://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual[0].Url);
            var author1 = Assert.Single(actual[0].Author.Value2);
            Assert.Equal("J.D. Salinger", author1.Name);

            Assert.Equal(new Uri("http://example.com/book/2"), ((Book)actual[1]).Id);
            Assert.Equal("The Lord of the Rings", actual[1].Name);
            Assert.Equal(new Uri("http://www.barnesandnoble.com/store/info/offer/JRRTolkien"), (Uri)actual[1].Url);
            var author2 = Assert.Single(actual[1].Author.Value2);
            Assert.Equal("J.R.R. Tolkien", author2.Name);
        }

        [Fact]
        public void ReadJson_OneOrMany_SingleValue_String()
        {
            var json = "{\"Property\":\"Test String\"}";
            var result = this.DeserializeObject<OneOrMany<string>>(json);
            Assert.Equal("Test String", result.First());
        }

        [Fact]
        public void ReadJson_OneOrMany_MultiValue_String()
        {
            var json = "{\"Property\":[\"A\",\"B\"]}";
            var result = this.DeserializeObject<OneOrMany<string>>(json);
            Assert.Equal(new[] { "A", "B" }, result);
        }

        [Fact]
        public void ReadJson_OneOrMany_SingleValue_NullablePrimitiveAsString()
        {
            var json = "{\"Property\":\"123\"}";
            var result = this.DeserializeObject<OneOrMany<int?>>(json);
            Assert.Equal(123, result.First());
        }

        [Fact(Skip = "An array of nullable primitive values isn't handled properly, passed as non-primitive to OneOrMany constructor - this needs to be fixed")]
        public void ReadJson_OneOrMany_MultiValue_NullablePrimitiveAsString()
        {
            var json = "{\"Property\":[\"123\",\"456\"]}";
            var result = this.DeserializeObject<OneOrMany<int?>>(json);
            Assert.Equal(new int?[] { 123, 456 }, result);
        }

        private string SerializeObject<T>(T value)
            where T : IValues
            => JsonConvert.SerializeObject(new TestModel<T> { Property = value });

        private T DeserializeObject<T>(string json)
            where T : IValues
            => JsonConvert.DeserializeObject<TestModel<T>>(json).Property;

        private class TestModel<T>
            where T : IValues
        {
            [JsonConverter(typeof(ValuesJsonConverter))]
            public T Property { get; set; }
        }
    }
}
