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
                    var bannedServer = e.Guild.Name;
                    var serverId = e.Guild.Id;
                    var dates = e.Message.Timestamp;
                    _date = $"{dates.DateTime}";
                    
                    
                    Regex regexStatement = new Regex("m:.[a-z]+");
                    Match matchStatement = regexStatement.Match(content);
                    _matchStatement = matchStatement.Value.Remove(0,3);

                    // Web servise gidilip Server kontrolü yapılacak eğer kontrol sonucu false ise web servise post atılarak server eklenecek server id dönüş yapılacak

                    //Ban olduğunu anlarız
                    if (matchStatement.Success)
                    { 
                        //Diğer maplenecek alanları ardından sorgularız
                        Regex regexHexId = new Regex(":[A-Za-z0-9_]+[0-9]");
                        Match matchedHexId = regexHexId.Match(content);
                        if (matchedHexId.Success)
                        {
                            _hexId = matchedHexId.Value.Remove(0,1);
                        }

                        Regex regexDiscordId = new Regex("![A-Za-z0-9_]+[0-9]");
                        Match matchedDiscordId = regexDiscordId.Match(content);
                        if (matchedDiscordId.Success)
                        {
                            _matchedDiscordId = matchedDiscordId.Value.Remove(0, 1);
                        }

                        Regex regexReason = new Regex("p:.[a-z].+l");
                        Match matchedReason = regexReason.Match(content);
                        if (matchedReason.Success)
                        {
                            _matchedReason = matchedReason.Value.Remove(0, 3);
                        }

                        var sonuc = e.Guild.Members.Any(x => x.Id.ToString() == _matchedDiscordId);
                        if (sonuc)
                        {
                            InsertDiscordBanneds(bannedServer, serverId.ToString(), _hexId.ToString(), _matchedDiscordId, _date , _matchedReason);
                        }
                    }
                }
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        static void InsertDiscordBanneds(string bannedUser, string serverId, string hexId, string matchedDiscordId, string date, string matchedReason)
        {
            try
            {
                using (var conn = new ApplicationDbContext())
                {
                    Datas banneds = new Datas{

                        HexId = hexId,
                        DiscordId = matchedDiscordId,
                        Reason = matchedReason,
                        ServerId = serverId,
                        ReasonDate = date
                    };
                    
                    conn.Add(banneds);
                    conn.SaveChanges();
                }
                return;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

        }

        static void Main()
        {
            
            MainAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }
    }
}
