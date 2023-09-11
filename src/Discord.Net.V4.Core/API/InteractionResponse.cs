using System.Text.Json.Serialization;

namespace Discord.API;

public sealed class InteractionResponse
{
    [JsonPropertyName("type")]
    public InteractionResponseType Type { get; set; }

    [JsonPropertyName("data")]
    public Optional<InteractionCallbackData> Data { get; set; }
}
