using Discord.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.WebSocket
{
    public interface ISocketNestedChannel
    {
        GuildChannelCacheable Parent { get; }
    }
}
