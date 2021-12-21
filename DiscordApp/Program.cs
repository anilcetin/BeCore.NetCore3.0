using DiscordApp.DataContext;
using DiscordApp.Models;
using DSharpPlus;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace DiscordApp
{
    public class Program
    {
        static DiscordClient discord;
        static string _hexId, _matchedDiscordId, _matchedReason, _matchStatement, _date;
        static async Task MainAsync()
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "OTE0NjkyNjMxNzI3MDY3MjQ2.YaQv5Q.5KGG4IY5rDNr4_STrq8tWh2dt-I",
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += async e =>
            {
                
                if (e.Message.Embeds.Count > 0)
                {
                    var content = e.Message.Embeds[0].Description.ToString();

                    InsertDiscordBanneds(content.ToString());
                }
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        static void InsertDiscordBanneds(string hexId)
        {
                using (var conn = new ApplicationDbContext())
                {
                    Datas banneds = new Datas{

                        ServerId = hexId,
                        ReasonDate = DateTime.Now.ToString("MM/dd/yyyy")
                    };
                    
                    conn.Add(banneds);
                    conn.SaveChanges();
                }
                return;
            

        }

        static void Main()
        {
            
            MainAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}
