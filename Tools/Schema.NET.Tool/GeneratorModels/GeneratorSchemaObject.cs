namespace Schema.NET.Tool.GeneratorModels
{
    public class GeneratorSchemaObject
    {
        public GeneratorSchemaObject(string name, string layer)
        {
            this.Name = name;
            this.Layer = layer;
        }

        public string Layer { get; set; }

        public string Name { get; set; }
    }
}
