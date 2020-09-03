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
            var json = SerializeObject(value);
            Assert.Equal("{}", json);
        }

        [Fact]
        public void WriteJson_Values_OneCountWritesSingle()
        {
            var value = new Values<int?, string>("One Value");
            var json = SerializeObject(value);
            Assert.Equal("{\"Property\":\"One Value\"}", json);
        }

        [Fact]
        public void WriteJson_Values_GreaterThanOneCountWritesArray()
        {
            var value = new Values<int?, string>(new[] { "A", "B" });
            var json = SerializeObject(value);
            Assert.Equal("{\"Property\":[\"A\",\"B\"]}", json);
        }

        [Fact]
        public void WriteJson_Values_MixedValueTypes()
        {
            var value = new Values<int?, string>(new object[] { 123, "B" });
            var json = SerializeObject(value);
            Assert.Equal("{\"Property\":[123,\"B\"]}", json);
        }

        [Fact]
        public void WriteJson_OneOrMany_ZeroCountWritesNull()
        {
            var value = default(OneOrMany<string>);
            var json = SerializeObject(value);
            Assert.Equal("{}", json);
        }

        [Fact]
        public void WriteJson_OneOrMany_OneCountWritesSingle()
        {
            var value = new OneOrMany<string>("One Value");
            var json = SerializeObject(value);
            Assert.Equal("{\"Property\":\"One Value\"}", json);
        }

        [Fact]
        public void WriteJson_OneOrMany_GreaterThanOneCountWritesArray()
        {
            var value = new OneOrMany<string>(new[] { "A", "B" });
            var json = SerializeObject(value);
            Assert.Equal("{\"Property\":[\"A\",\"B\"]}", json);
        }

        [Fact]
        public void WriteJson_DateTime_ISO8601_DateTime()
        {
            var value = new OneOrMany<DateTime>(new DateTime(2000, 1, 1, 12, 34, 56));
            var json = SerializeObject(value);
            Assert.Equal("{\"Property\":\"2000-01-01T12:34:56\"}", json);
        }

        [Fact]
        public void WriteJson_DateTimeOffset_ISO8601_DateTimeWithTimeOffset()
        {
            var value = new OneOrMany<DateTimeOffset>(new DateTimeOffset(2000, 1, 1, 12, 34, 56, TimeSpan.FromHours(1)));
            var json = SerializeObject(value);
            Assert.Equal("{\"Property\":\"2000-01-01T12:34:56+01:00\"}", json);
        }

        [Fact]
        public void WriteJson_TimeSpan_ISO8601_TimeOfDay()
        {
            var value = new OneOrMany<TimeSpan>(new TimeSpan(12, 34, 56));
            var json = SerializeObject(value);
            Assert.Equal("{\"Property\":\"12:34:56\"}", json);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_String()
        {
            var json = "{\"Property\":\"Test String\"}";
            var result = DeserializeObject<Values<int, string>>(json);
            Assert.Equal("Test String", result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_IntegerAsString()
        {
            var json = "{\"Property\":\"123\"}";
            var result = DeserializeObject<Values<string, int>>(json);
            Assert.Equal(123, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_LongAsString()
        {
            var json = "{\"Property\":\"8294967295\"}";
            var result = DeserializeObject<Values<string, long>>(json);
            Assert.Equal(8294967295, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_FloatAsString()
        {
            var json = "{\"Property\":\"123.45\"}";
            var result = DeserializeObject<Values<string, float>>(json);
            Assert.Equal(123.45f, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DoubleAsString()
        {
            var json = "{\"Property\":\"123.45\"}";
            var result = DeserializeObject<Values<string, double>>(json);
            Assert.Equal(123.45, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_BooleanAsString()
        {
            var json = "{\"Property\":\"true\"}";
            var result = DeserializeObject<Values<string, bool>>(json);
            Assert.True(result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_GuidAsString()
        {
            var json = "{\"Property\":\"13ec75b3-250c-48a2-8bd0-dfee62852bd4\"}";
            var result = DeserializeObject<Values<string, Guid>>(json);
            Assert.Equal(new Guid("13ec75b3-250c-48a2-8bd0-dfee62852bd4"), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_NullablePrimitiveAsString()
        {
            var json = "{\"Property\":\"123\"}";
            var result = DeserializeObject<Values<string, int?>>(json);
            Assert.Equal(123, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Primitive()
        {
            var json = "{\"Property\":123}";
            var result = DeserializeObject<Values<string, int>>(json);
            Assert.Equal(123, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DecimalAsString()
        {
            var json = "{\"Property\":\"123.456\"}";
            var result = DeserializeObject<Values<string, decimal>>(json);
            Assert.Equal(123.456m, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Decimal()
        {
            var json = "{\"Property\":123.456}";
            var result = DeserializeObject<Values<string, decimal>>(json);
            Assert.Equal(123.456m, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeAsISO8601String()
        {
            var json = "{\"Property\":\"2000-01-01T12:34\"}";
            var result = DeserializeObject<Values<string, DateTime>>(json);
            Assert.Equal(new DateTime(2000, 1, 1, 12, 34, 0), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeAsMicrosoftDateTimeString()
        {
            var json = "{\"Property\":\"\\/Date(946730040000)\\/\"}";
            var result = DeserializeObject<Values<string, DateTime>>(json);
            Assert.Equal(new DateTime(2000, 1, 1, 12, 34, 0), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeNegativeOffsetAsMicrosoftDateTimeString()
        {
            var json = "{\"Property\":\"\\/Date(946730040000-0100)\\/\"}";
            var result = DeserializeObject<Values<string, DateTimeOffset>>(json);
            Assert.Equal(new DateTimeOffset(2000, 1, 1, 12, 34, 0, TimeSpan.FromHours(-1)), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimePositiveOffsetAsMicrosoftDateTimeString()
        {
            var json = "{\"Property\":\"\\/Date(946730040000+0100)\\/\"}";
            var result = DeserializeObject<Values<string, DateTimeOffset>>(json);
            Assert.Equal(new DateTimeOffset(2000, 1, 1, 12, 34, 0, TimeSpan.FromHours(1)), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeOffsetAsISO8601String()
        {
            var json = "{\"Property\":\"2000-01-01T12:34:00+01:00\"}";
            var result = DeserializeObject<Values<string, DateTimeOffset>>(json);
            Assert.Equal(new DateTimeOffset(2000, 1, 1, 12, 34, 0, TimeSpan.FromHours(1)), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeOffsetFallback_DateTimeAsISO8601String_NoOffset()
        {
            var json = "{\"Property\":\"2000-01-01T12:34:00\"}";
            var result = DeserializeObject<Values<DateTime, DateTimeOffset>>(json);
            Assert.Equal(new DateTime(2000, 1, 1, 12, 34, 0), result.Value1.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeOffsetNoFallback_DateTimeAsISO8601String_ZOffset()
        {
            var json = "{\"Property\":\"2000-01-01T12:34:00Z\"}";
            var result = DeserializeObject<Values<DateTime, DateTimeOffset>>(json);
            Assert.Equal(new DateTimeOffset(2000, 1, 1, 12, 34, 0, TimeSpan.FromHours(0)), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_DateTimeOffsetNoFallback_DateTimeAsISO8601String_TimeOffset()
        {
            var json = "{\"Property\":\"2000-01-01T12:34:00+01:00\"}";
            var result = DeserializeObject<Values<DateTime, DateTimeOffset>>(json);
            Assert.Equal(new DateTimeOffset(2000, 1, 1, 12, 34, 0, TimeSpan.FromHours(1)), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_TimeSpanAsISO8601TimeOfDayString()
        {
            var json = "{\"Property\":\"12:34\"}";
            var result = DeserializeObject<Values<string, TimeSpan>>(json);
            Assert.Equal(new TimeSpan(12, 34, 0), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_TimeSpanAsISO8601DurationString()
        {
            var json = "{\"Property\":\"PT12H34M\"}";
            var result = DeserializeObject<Values<string, TimeSpan>>(json);
            Assert.Equal(new TimeSpan(12, 34, 0), result.Value2.First());
        }

        [Fact]
        public void ReadJson_ParseValueToken_UriAsString()
        {
            var json = "{\"Property\":\"https://schema.org/Thing\"}";
            var result = DeserializeObject<Values<string, Uri>>(json);
            Assert.Equal(new Uri("https://schema.org/Thing"), result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_ThingInterface()
        {
            var json = "{\"Property\":" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Book\"," +
                    "\"@id\":\"https://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"https://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}" +
            "}";
            var result = DeserializeObject<Values<string, IBook>>(json);
            var actual = result.Value2.First();

            Assert.Equal(new Uri("https://example.com/book/1"), ((Book)actual).Id);
            Assert.Equal("The Catcher in the Rye", actual.Name);
            Assert.Equal(new Uri("https://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual.Url);
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
                    "\"@id\":\"https://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"https://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}" +
            "}";
            var result = DeserializeObject<Values<string, Book>>(json);
            var actual = result.Value2.First();

            Assert.Equal(new Uri("https://example.com/book/1"), actual.Id);
            Assert.Equal("The Catcher in the Rye", actual.Name);
            Assert.Equal(new Uri("https://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual.Url);
            var author = Assert.Single(actual.Author.Value2);
            Assert.Equal("J.D. Salinger", author.Name);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_ThingInterfaceWithNoTypeToken()
        {
            var json = "{\"Property\":" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@id\":\"https://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"https://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}" +
            "}";
            var result = DeserializeObject<Values<string, IBook>>(json);
            var actual = result.Value2.First();

            Assert.Equal(new Uri("https://example.com/book/1"), ((Book)actual).Id);
            Assert.Equal("The Catcher in the Rye", actual.Name);
            Assert.Equal(new Uri("https://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual.Url);
            var author = Assert.Single(actual.Author.Value2);
            Assert.Equal("J.D. Salinger", author.Name);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_ThingActualWithNoTypeToken()
        {
            var json = "{\"Property\":" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@id\":\"https://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"https://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}" +
            "}";
            var result = DeserializeObject<Values<string, Book>>(json);
            var actual = result.Value2.First();

            Assert.Equal(new Uri("https://example.com/book/1"), actual.Id);
            Assert.Equal("The Catcher in the Rye", actual.Name);
            Assert.Equal(new Uri("https://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual.Url);
            var author = Assert.Single(actual.Author.Value2);
            Assert.Equal("J.D. Salinger", author.Name);
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Enum_NoUrl()
        {
            var json = "{\"Property\":\"InStock\"}";
            var result = DeserializeObject<Values<string, ItemAvailability>>(json);
            Assert.Equal(ItemAvailability.InStock, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Enum_HttpSchema()
        {
            var json = "{\"Property\":\"https://schema.org/InStock\"}";
            var result = DeserializeObject<Values<string, ItemAvailability>>(json);
            Assert.Equal(ItemAvailability.InStock, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_SingleValue_Enum_HttpsSchema()
        {
            var json = "{\"Property\":\"https://schema.org/InStock\"}";
            var result = DeserializeObject<Values<string, ItemAvailability>>(json);
            Assert.Equal(ItemAvailability.InStock, result.Value2.First());
        }

        [Fact]
        public void ReadJson_Values_MultiValue_SameType()
        {
            var json = "{\"Property\":[\"A\",\"B\"]}";
            var result = DeserializeObject<Values<int, string>>(json);
            Assert.Equal(new[] { "A", "B" }, result.Value2);
        }

        [Fact]
        public void ReadJson_Values_MultiValue_SameType_ArgumentsSwapped()
        {
            var json = "{\"Property\":[\"A\",\"B\"]}";
            var result = DeserializeObject<Values<string, int>>(json);
            Assert.Equal(new[] { "A", "B" }, result.Value1);
        }

        [Fact]
        public void ReadJson_Values_MultiValue_MixedType()
        {
            var json = "{\"Property\":[1,\"B\"]}";
            var result = DeserializeObject<Values<int, string>>(json);
            Assert.Equal(new[] { 1 }, result.Value1);
            Assert.Equal(new[] { "B" }, result.Value2);
        }

        [Fact]
        public void ReadJson_Values_MultiValue_NullablePrimitiveAsString()
        {
            var json = "{\"Property\":[\"123\",\"456\"]}";
            var result = DeserializeObject<Values<string, int?>>(json);
            Assert.Equal(new int?[] { 123, 456 }, result.Value2);
        }

        [Fact]
        public void ReadJson_Values_MultiValue_ThingInterface()
        {
            var json = "{\"Property\":[" +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Book\"," +
                    "\"@id\":\"https://example.com/book/1\"," +
                    "\"name\":\"The Catcher in the Rye\"," +
                    "\"url\":\"https://www.barnesandnoble.com/store/info/offer/JDSalinger\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.D. Salinger\"" +
                    "}," +
                "}," +
                "{" +
                    "\"@context\":\"https://schema.org\"," +
                    "\"@type\":\"Book\"," +
                    "\"@id\":\"https://example.com/book/2\"," +
                    "\"name\":\"The Lord of the Rings\"," +
                    "\"url\":\"https://www.barnesandnoble.com/store/info/offer/JRRTolkien\"," +
                    "\"author\":{" +
                        "\"@type\":\"Person\"," +
                        "\"name\":\"J.R.R. Tolkien\"" +
                    "}," +
                "}" +
            "]}";
            var result = DeserializeObject<Values<string, IBook>>(json);
            var actual = result.Value2.ToArray();

            Assert.Equal(new Uri("https://example.com/book/1"), ((Book)actual[0]).Id);
            Assert.Equal("The Catcher in the Rye", actual[0].Name);
            Assert.Equal(new Uri("https://www.barnesandnoble.com/store/info/offer/JDSalinger"), (Uri)actual[0].Url);
            var author1 = Assert.Single(actual[0].Author.Value2);
            Assert.Equal("J.D. Salinger", author1.Name);

            Assert.Equal(new Uri("https://example.com/book/2"), ((Book)actual[1]).Id);
            Assert.Equal("The Lord of the Rings", actual[1].Name);
            Assert.Equal(new Uri("https://www.barnesandnoble.com/store/info/offer/JRRTolkien"), (Uri)actual[1].Url);
            var author2 = Assert.Single(actual[1].Author.Value2);
            Assert.Equal("J.R.R. Tolkien", author2.Name);
        }

        [Fact]
        public void ReadJson_OneOrMany_SingleValue_String()
        {
            var json = "{\"Property\":\"Test String\"}";
            var result = DeserializeObject<OneOrMany<string>>(json);
            Assert.Equal("Test String", result.First());
        }

        [Fact]
        public void ReadJson_OneOrMany_MultiValue_String()
        {
            var json = "{\"Property\":[\"A\",\"B\"]}";
            var result = DeserializeObject<OneOrMany<string>>(json);
            Assert.Equal(new[] { "A", "B" }, result);
        }

        [Fact]
        public void ReadJson_OneOrMany_SingleValue_NullablePrimitiveAsString()
        {
            var json = "{\"Property\":\"123\"}";
            var result = DeserializeObject<OneOrMany<int?>>(json);
            Assert.Equal(123, result.First());
        }

        [Fact]
        public void ReadJson_OneOrMany_MultiValue_NullablePrimitiveAsString()
        {
            var json = "{\"Property\":[\"123\",\"456\"]}";
            var result = DeserializeObject<OneOrMany<int?>>(json);
            Assert.Equal(new int?[] { 123, 456 }, result);
        }

        [Fact]
        public void ReadJson_ExplicitExternalTypes_AllowCustomNamespace()
        {
            var json = "{\"Property\":[" +
                "{" +
                    "\"@type\":\"ExternalSchemaModelCustomNamespace, Schema.NET.Test\"," +
                    "\"name\":\"Property from Thing\"," +
                    "\"myCustomProperty\":\"My Test String\"" +
                "}" +
            "]}";
            var result = DeserializeObject<Values<string, SomeCustomNamespace.ExternalSchemaModelCustomNamespace>>(json);
            var actual = Assert.Single(result.Value2);
            Assert.Equal(new[] { "Property from Thing" }, actual.Name);
            Assert.Equal(new[] { "My Test String" }, actual.MyCustomProperty);
        }

        [Fact]
        public void ReadJson_ExplicitExternalTypes_AllowSharedNamespace()
        {
            var json = "{\"Property\":[" +
                "{" +
                    "\"@type\":\"ExternalSchemaModelSharedNamespace, Schema.NET.Test\"," +
                    "\"name\":\"Property from Thing\"," +
                    "\"myCustomProperty\":\"My Test String\"" +
                "}" +
            "]}";
            var result = DeserializeObject<Values<string, ExternalSchemaModelSharedNamespace>>(json);
            var actual = Assert.Single(result.Value2);
            Assert.Equal(new[] { "Property from Thing" }, actual.Name);
            Assert.Equal(new[] { "My Test String" }, actual.MyCustomProperty);
        }

        [Fact]
        public void ReadJson_ImplicitExternalTypes_AllowCustomNamespace()
        {
            var json = "{\"Property\":[" +
                "{" +
                    "\"@type\":\"SomeCustomNamespace.ExternalSchemaModelCustomNamespace, Schema.NET.Test\"," +
                    "\"name\":\"Property from Thing\"," +
                    "\"myCustomProperty\":\"My Test String\"" +
                "}" +
            "]}";
            var result = DeserializeObject<Values<string, IThing>>(json);
            var actual = Assert.Single(result.Value2);
            Assert.IsType<SomeCustomNamespace.ExternalSchemaModelCustomNamespace>(actual);
            Assert.Equal(new[] { "Property from Thing" }, actual.Name);
            Assert.Equal(new[] { "My Test String" }, ((SomeCustomNamespace.ExternalSchemaModelCustomNamespace)actual).MyCustomProperty);
        }

        [Fact]
        public void ReadJson_ImplicitExternalTypes_AllowSharedNamespace()
        {
            var json = "{\"Property\":[" +
                "{" +
                    "\"@type\":\"Schema.NET.ExternalSchemaModelSharedNamespace, Schema.NET.Test\"," +
                    "\"name\":\"Property from Thing\"," +
                    "\"myCustomProperty\":\"My Test String\"" +
                "}" +
            "]}";
            var result = DeserializeObject<Values<string, IThing>>(json);
            var actual = Assert.Single(result.Value2);
            Assert.IsType<ExternalSchemaModelSharedNamespace>(actual);
            Assert.Equal(new[] { "Property from Thing" }, actual.Name);
            Assert.Equal(new[] { "My Test String" }, ((ExternalSchemaModelSharedNamespace)actual).MyCustomProperty);
        }

        private static string SerializeObject<T>(T value)
            where T : IValues
            => SchemaSerializer.SerializeObject(new TestModel<T> { Property = value });

        private static T DeserializeObject<T>(string json)
            where T : IValues
            => SchemaSerializer.DeserializeObject<TestModel<T>>(json).Property;

        private class TestModel<T>
            where T : IValues
        {
            [JsonConverter(typeof(ValuesJsonConverter))]
            public T Property { get; set; }
        }
    }
}
