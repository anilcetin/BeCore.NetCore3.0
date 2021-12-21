using System;
using System.Linq;
using System.Threading.Tasks;
using DataContext;
using DSharpPlus;
using Models;

namespace Discord
{
    class Program
    {
        static async Task MainAsync()
        {

            var discord = new DiscordClient(new DiscordConfiguration()
            {
                Token = "OTE0NjkyNjMxNzI3MDY3MjQ2.YaQv5Q.5KGG4IY5rDNr4_STrq8tWh2dt-I",
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += async (s, e) =>
            {
                if (e.Message.Embeds.Count > 0)
                {
                    var serverName = e.Guild.Name.ToString();

                    var content = e.Message.Embeds[0].Description.ToString();

                    InsertDiscordBanneds(content.ToString(), serverName);
                }
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        static void Main(string[] args)
        {
            MainAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static void InsertDiscordBanneds(string hexId, string serverName)
        {
            using (var conn = new ApplicationDbContext())
            {
                if (!string.IsNullOrEmpty(serverName))
                {
                    if (!conn.Set<Servers>().Any(x => x.Name == serverName))
                    {
                        Servers servers = new Servers
                        {
                            Name = serverName,
                            isActive = true
                        };
                        conn.Add(servers);
                        conn.SaveChanges();
                    }
                    Datas banneds = new Datas
                    {
                        HexId = hexId,
                        ServerId = serverName,
                        ReasonDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
                    };
                    conn.Add(banneds);
                    conn.SaveChanges();
                }
            }
            return;


        }
    }
}
