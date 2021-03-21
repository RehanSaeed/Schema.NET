namespace Schema.NET.Tool.GeneratorModels
{
    public class GeneratorSchemaObject
    {
        public GeneratorSchemaObject(string layer, string name, string description)
        {
            this.Layer = layer;
            this.Name = name;
            this.Description = description;
        }

        public string Description { get; }

        public string Layer { get; }

        public string Name { get; }
    }
}
