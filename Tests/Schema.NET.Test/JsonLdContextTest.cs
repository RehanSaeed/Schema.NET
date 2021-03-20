namespace Schema.NET.Test
{
    using System.Collections.Generic;
    using Xunit;

    public class JsonLdContextTest
    {
        public static IEnumerable<object[]> EqualContexts => new List<object[]>
        {
            new object[] { new JsonLdContext(), new JsonLdContext() },
            new object[] { new JsonLdContext() { Name = "a" }, new JsonLdContext() { Name = "a" } },
            new object[]
            {
                new JsonLdContext() { Name = "a", Language = "b" },
                new JsonLdContext() { Name = "a", Language = "b" },
            },
        };

        public static IEnumerable<object[]> NotEqualContexts => new List<object[]>
        {
            new object[] { new JsonLdContext(), null! },
            new object[] { new JsonLdContext(), new JsonLdContext() { Name = "a" } },
            new object[] { new JsonLdContext() { Name = "a" }, new JsonLdContext() },
            new object[] { new JsonLdContext() { Name = "a" }, new JsonLdContext() { Name = "b" } },
            new object[]
            {
                new JsonLdContext() { Name = "a", Language = "b" },
                new JsonLdContext() { Name = "a", Language = "c" },
            },
        };

        public static IEnumerable<object[]> ToStringContexts => new List<object[]>
        {
            new object[] { new JsonLdContext(), "https://schema.org" },
            new object[] { new JsonLdContext() { Name = "a" }, "a" },
        };

        [Theory]
        [MemberData(nameof(EqualContexts))]
        public void Equals_IsEqual_ReturnsTrue(JsonLdContext a, JsonLdContext b) => Assert.True(a.Equals(b));

        [Theory]
        [MemberData(nameof(NotEqualContexts))]
        public void Equals_IsNotEqual_ReturnsFalse(JsonLdContext a, JsonLdContext b) => Assert.False(a.Equals(b));

        [Theory]
        [MemberData(nameof(EqualContexts))]
        public void EqualsOperator_IsEqual_ReturnsTrue(JsonLdContext a, JsonLdContext b) => Assert.True(a == b);

        [Theory]
        [MemberData(nameof(NotEqualContexts))]
        public void EqualsOperator_IsNotEqual_ReturnsFalse(JsonLdContext a, JsonLdContext b) => Assert.False(a == b);

        [Theory]
        [MemberData(nameof(EqualContexts))]
        public void NotEqualsOperator_IsEqual_ReturnsFalse(JsonLdContext a, JsonLdContext b) => Assert.False(a != b);

        [Theory]
        [MemberData(nameof(NotEqualContexts))]
        public void NotEqualsOperator_IsNotEqual_ReturnsTrue(JsonLdContext a, JsonLdContext b) => Assert.True(a != b);

        [Theory]
        [MemberData(nameof(ToStringContexts))]
        public void ToString_MatchesExpected_ReturnsName(JsonLdContext context, string expectedValue) =>
            Assert.Equal(expectedValue, context.ToString());
    }
}
