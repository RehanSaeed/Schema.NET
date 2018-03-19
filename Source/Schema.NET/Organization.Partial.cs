namespace Schema.NET
{
    public partial class Organization
    {
        public Organization() { }

        public Organization(string name)
        {
            Name = name;
        }

        public static implicit operator Organization(string name) => new Organization(name);
    }
}
