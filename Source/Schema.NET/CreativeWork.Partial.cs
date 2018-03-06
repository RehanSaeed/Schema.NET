namespace Schema.NET
{
    public partial class CreativeWork
    {
        public class AuthorString : IAuthor<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string)value; } }
            public virtual string Data { get; set; }
            public AuthorString() { }
            public AuthorString(string data) { Data = data; }
            public static implicit operator AuthorString(string data) { return new AuthorString(data); }
        }
    }
}
