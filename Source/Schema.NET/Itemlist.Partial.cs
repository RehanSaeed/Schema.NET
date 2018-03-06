using System;

namespace Schema.NET
{
    public partial class ItemList : Intangible
    {
        public class ItemListElementUri : IItemListElement<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri)value; } }
            public virtual Uri Data { get; set; }
            public ItemListElementUri() { }
            public ItemListElementUri(Uri data) { Data = data; }
            public static implicit operator ItemListElementUri(Uri data) { return new ItemListElementUri(data); }
        }
    }
}
