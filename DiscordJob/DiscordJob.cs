using System;
using System.Threading.Tasks;
using DSharpPlus;

namespace DiscordJob
{
    public class DiscordJob
    {
        static DiscordClient discord;

        static async Task MainAsync(string[] arg)
        {
            discord = new DiscordClient(new DiscordConfiguration { 
                Token = "OTE0NjkyNjMxNzI3MDY3MjQ2.YaQv5Q.5KGG4IY5rDNr4_STrq8tWh2dt-I",
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += async e =>
            {
                if (e.Message.Content.Length > 0)
                {
                    await e.Message.RespondAsync(e.Message.Content);
                }
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        static void Main(string[] arg)
        {
            MainAsync(arg).ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}
