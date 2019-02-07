namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A book.
    /// </summary>
    [DataContract]
    public partial class Book : CreativeWork
    {
        public interface IAbridged : IValue {}
        public interface IAbridged<T> : IAbridged { new T Value { get; } }
        public class OneOrManyAbridged : OneOrMany<IAbridged>
        {
            public OneOrManyAbridged(IAbridged item) : base(item) { }
            public OneOrManyAbridged(IEnumerable<IAbridged> items) : base(items) { }
            public static implicit operator OneOrManyAbridged (bool value) { return new OneOrManyAbridged (new Abridgedbool (value)); }
            public static implicit operator OneOrManyAbridged (bool[] values) { return new OneOrManyAbridged (values.Select(v => (IAbridged) new Abridgedbool (v))); }
            public static implicit operator OneOrManyAbridged (List<bool> values) { return new OneOrManyAbridged (values.Select(v => (IAbridged) new Abridgedbool (v))); }
        }
        public struct Abridgedbool : IAbridged<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public Abridgedbool (bool value) { Value = value; }
            public static implicit operator Abridgedbool (bool value) { return new Abridgedbool (value); }
        }

        public interface IBookEdition : IValue {}
        public interface IBookEdition<T> : IBookEdition { new T Value { get; } }
        public class OneOrManyBookEdition : OneOrMany<IBookEdition>
        {
            public OneOrManyBookEdition(IBookEdition item) : base(item) { }
            public OneOrManyBookEdition(IEnumerable<IBookEdition> items) : base(items) { }
            public static implicit operator OneOrManyBookEdition (string value) { return new OneOrManyBookEdition (new BookEditionstring (value)); }
            public static implicit operator OneOrManyBookEdition (string[] values) { return new OneOrManyBookEdition (values.Select(v => (IBookEdition) new BookEditionstring (v))); }
            public static implicit operator OneOrManyBookEdition (List<string> values) { return new OneOrManyBookEdition (values.Select(v => (IBookEdition) new BookEditionstring (v))); }
        }
        public struct BookEditionstring : IBookEdition<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BookEditionstring (string value) { Value = value; }
            public static implicit operator BookEditionstring (string value) { return new BookEditionstring (value); }
        }

        public interface IBookFormat : IValue {}
        public interface IBookFormat<T> : IBookFormat { new T Value { get; } }
        public class OneOrManyBookFormat : OneOrMany<IBookFormat>
        {
            public OneOrManyBookFormat(IBookFormat item) : base(item) { }
            public OneOrManyBookFormat(IEnumerable<IBookFormat> items) : base(items) { }
            public static implicit operator OneOrManyBookFormat (BookFormatType value) { return new OneOrManyBookFormat (new BookFormatBookFormatType (value)); }
            public static implicit operator OneOrManyBookFormat (BookFormatType[] values) { return new OneOrManyBookFormat (values.Select(v => (IBookFormat) new BookFormatBookFormatType (v))); }
            public static implicit operator OneOrManyBookFormat (List<BookFormatType> values) { return new OneOrManyBookFormat (values.Select(v => (IBookFormat) new BookFormatBookFormatType (v))); }
        }
        public struct BookFormatBookFormatType : IBookFormat<BookFormatType>
        {
            object IValue.Value => this.Value;
            public BookFormatType Value { get; }
            public BookFormatBookFormatType (BookFormatType value) { Value = value; }
            public static implicit operator BookFormatBookFormatType (BookFormatType value) { return new BookFormatBookFormatType (value); }
        }

        public interface IIllustrator : IValue {}
        public interface IIllustrator<T> : IIllustrator { new T Value { get; } }
        public class OneOrManyIllustrator : OneOrMany<IIllustrator>
        {
            public OneOrManyIllustrator(IIllustrator item) : base(item) { }
            public OneOrManyIllustrator(IEnumerable<IIllustrator> items) : base(items) { }
            public static implicit operator OneOrManyIllustrator (Person value) { return new OneOrManyIllustrator (new IllustratorPerson (value)); }
            public static implicit operator OneOrManyIllustrator (Person[] values) { return new OneOrManyIllustrator (values.Select(v => (IIllustrator) new IllustratorPerson (v))); }
            public static implicit operator OneOrManyIllustrator (List<Person> values) { return new OneOrManyIllustrator (values.Select(v => (IIllustrator) new IllustratorPerson (v))); }
        }
        public struct IllustratorPerson : IIllustrator<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public IllustratorPerson (Person value) { Value = value; }
            public static implicit operator IllustratorPerson (Person value) { return new IllustratorPerson (value); }
        }

        public interface IIsbn : IValue {}
        public interface IIsbn<T> : IIsbn { new T Value { get; } }
        public class OneOrManyIsbn : OneOrMany<IIsbn>
        {
            public OneOrManyIsbn(IIsbn item) : base(item) { }
            public OneOrManyIsbn(IEnumerable<IIsbn> items) : base(items) { }
            public static implicit operator OneOrManyIsbn (string value) { return new OneOrManyIsbn (new Isbnstring (value)); }
            public static implicit operator OneOrManyIsbn (string[] values) { return new OneOrManyIsbn (values.Select(v => (IIsbn) new Isbnstring (v))); }
            public static implicit operator OneOrManyIsbn (List<string> values) { return new OneOrManyIsbn (values.Select(v => (IIsbn) new Isbnstring (v))); }
        }
        public struct Isbnstring : IIsbn<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Isbnstring (string value) { Value = value; }
            public static implicit operator Isbnstring (string value) { return new Isbnstring (value); }
        }

        public interface INumberOfPages : IValue {}
        public interface INumberOfPages<T> : INumberOfPages { new T Value { get; } }
        public class OneOrManyNumberOfPages : OneOrMany<INumberOfPages>
        {
            public OneOrManyNumberOfPages(INumberOfPages item) : base(item) { }
            public OneOrManyNumberOfPages(IEnumerable<INumberOfPages> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfPages (int value) { return new OneOrManyNumberOfPages (new NumberOfPagesint (value)); }
            public static implicit operator OneOrManyNumberOfPages (int[] values) { return new OneOrManyNumberOfPages (values.Select(v => (INumberOfPages) new NumberOfPagesint (v))); }
            public static implicit operator OneOrManyNumberOfPages (List<int> values) { return new OneOrManyNumberOfPages (values.Select(v => (INumberOfPages) new NumberOfPagesint (v))); }
        }
        public struct NumberOfPagesint : INumberOfPages<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public NumberOfPagesint (int value) { Value = value; }
            public static implicit operator NumberOfPagesint (int value) { return new NumberOfPagesint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Book";

        /// <summary>
        /// Indicates whether the book is an abridged edition.
        /// </summary>
        [DataMember(Name = "abridged", Order = 206)]
        public OneOrManyAbridged Abridged { get; set; }

        /// <summary>
        /// The edition of the book.
        /// </summary>
        [DataMember(Name = "bookEdition", Order = 207)]
        public OneOrManyBookEdition BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        [DataMember(Name = "bookFormat", Order = 208)]
        public OneOrManyBookFormat BookFormat { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        [DataMember(Name = "illustrator", Order = 209)]
        public OneOrManyIllustrator Illustrator { get; set; }

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        [DataMember(Name = "isbn", Order = 210)]
        public OneOrManyIsbn Isbn { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        [DataMember(Name = "numberOfPages", Order = 211)]
        public OneOrManyNumberOfPages NumberOfPages { get; set; }
    }
}
