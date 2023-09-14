using System.Text.Json.Serialization;

namespace Discord.API;

public sealed class EmbedField
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("inline")]
    public Optional<bool> Inline { get; set; }
}
