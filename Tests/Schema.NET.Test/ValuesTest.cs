namespace Schema.NET.Test
{
    using System;
    using Newtonsoft.Json;
    using Xunit;

    public class ValuesTest
    {
        [Fact]
        public void CanSetValuesIntUsingString()
        {
            Values<int> vInt = (Values<int>)"someTest";
            Assert.Equal("someTest", vInt.Value);
            Assert.True(vInt.ExplicitlySet);
        }

        [Fact]
        public void CanSetValuesIntUsingInteger()
        {
            Values<int> vInt = 20;
            Assert.Equal(20, vInt.Value);
            Assert.False(vInt.ExplicitlySet);
        }

        [Fact]
        public void CanSetValuesStringUsingString()
        {
            Values<string> vString = "Nice";
            Assert.Equal("Nice", vString.Value);
            Assert.False(vString.ExplicitlySet);
        }

        [Fact]
        public void CanSeValuesDecimalIntUsingString()
        {
            Values<decimal,int> v = (Values<decimal,int>)"Nice";
            Assert.Equal("Nice", v.Value);
            Assert.True(v.ExplicitlySet);
        }

        [Fact]
        public void CanSeValuesDecimalIntUsingDecimal()
        {
            Values<decimal,int> v = 1.0m;
            Assert.Equal(1.0m, v.Value);
            Assert.False(v.ExplicitlySet);
        }

                [Fact]
        public void CanSeValuesDecimalIntUsingInt()
        {
            Values<decimal,int> v = 5;
            Assert.Equal(5, v.Value);
            Assert.False(v.ExplicitlySet);
        }
    }
}
