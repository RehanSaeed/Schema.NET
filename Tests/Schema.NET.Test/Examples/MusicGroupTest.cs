namespace Schema.NET.Test.Examples;

using System;
using Xunit;

public class MusicGroupTest
{
    private readonly MusicGroup musicGroup = new()
    {
        Name = "Radiohead", // Required
        Identifier = "4Z8W4fKeB5YxbusRsdQVPb", // Recommended
        Image = new ImageObject() // Recommended
        {
            ContentUrl = new Uri("https://i.scdn.co/image/afcd616e1ef2d2786f47b3b4a8a6aeea24a72adc"), // Required
        },
        SameAs = new Uri("https://music.apple.com/us/artist/radiohead/657515"), // Recommended
        Url = new Uri("https://open.spotify.com/artist/4Z8W4fKeB5YxbusRsdQVPb"), // Recommended
    };

    private readonly string json =
    "{" +
        "\"@context\":\"https://schema.org\"," +
        "\"@type\": \"MusicGroup\"," +
        "\"name\": \"Radiohead\"," +
        "\"identifier\": \"4Z8W4fKeB5YxbusRsdQVPb\"," +
        "\"image\": {" +
            "\"@context\":\"https://schema.org\"," +
            "\"@type\": \"ImageObject\"," +
            "\"contentUrl\": \"https://i.scdn.co/image/afcd616e1ef2d2786f47b3b4a8a6aeea24a72adc\"" +
        "}," +
        "\"sameAs\": \"https://music.apple.com/us/artist/radiohead/657515\"," +
        "\"url\": \"https://open.spotify.com/artist/4Z8W4fKeB5YxbusRsdQVPb\"" +
    "}";

    [Fact]
    public void Deserializing_MusicGroupJsonLd_ReturnsMusicGroup()
    {
        Assert.Equal(this.musicGroup.ToString(), SchemaSerializer.DeserializeObject<MusicGroup>(this.json)!.ToString());
        Assert.Equal(SchemaSerializer.SerializeObject(this.musicGroup), SchemaSerializer.SerializeObject(SchemaSerializer.DeserializeObject<MusicGroup>(this.json)!));
    }
}
