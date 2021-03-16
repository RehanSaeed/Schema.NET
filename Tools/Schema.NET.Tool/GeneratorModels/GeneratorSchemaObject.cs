namespace Schema.NET.Tool.GeneratorModels
{
    public class GeneratorSchemaObject
    {
        public GeneratorSchemaObject(string layer, string name)
        {
            this.Layer = layer;
            this.Name = name;
        }

        public string Layer { get; }

        public string Name { get; }
    }
}
