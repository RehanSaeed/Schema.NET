namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Organization: A business corporation.
    /// </summary>
    [DataContract]
    public partial class Corporation : Organization
    {
        public interface ITickerSymbol : IValue {}
        public interface ITickerSymbol<T> : ITickerSymbol { new T Value { get; } }
        public class OneOrManyTickerSymbol : OneOrMany<ITickerSymbol>
        {
            public OneOrManyTickerSymbol(ITickerSymbol item) : base(item) { }
            public OneOrManyTickerSymbol(IEnumerable<ITickerSymbol> items) : base(items) { }
            public static implicit operator OneOrManyTickerSymbol (string value) { return new OneOrManyTickerSymbol (new TickerSymbolstring (value)); }
            public static implicit operator OneOrManyTickerSymbol (string[] values) { return new OneOrManyTickerSymbol (values.Select(v => (ITickerSymbol) new TickerSymbolstring (v))); }
            public static implicit operator OneOrManyTickerSymbol (List<string> values) { return new OneOrManyTickerSymbol (values.Select(v => (ITickerSymbol) new TickerSymbolstring (v))); }
        }
        public struct TickerSymbolstring : ITickerSymbol<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TickerSymbolstring (string value) { Value = value; }
            public static implicit operator TickerSymbolstring (string value) { return new TickerSymbolstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Corporation";

        /// <summary>
        /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO15022.
        /// </summary>
        [DataMember(Name = "tickerSymbol", Order = 206)]
        public OneOrManyTickerSymbol TickerSymbol { get; set; }
    }
}
