using System.Text.Json.Serialization;

namespace Discord.API;

public sealed class ForumReactionEmoji
{
    [JsonPropertyName("emoji_id")]
    public ulong? EmojiId { get; set; }

    [JsonPropertyName("emoji_name")]
    public string? EmojiName { get; set; }
}
