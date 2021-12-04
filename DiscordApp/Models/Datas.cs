using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DiscordApp.Models
{
    public class Datas
    {
        public int Id { get; set; }
        public string HexId { get; set; }
        public string ServerId { get; set; }
        public string Reason { get; set; }
        public string ReasonDate { get; set; }
        public string DiscordId { get; set; }
    }
}
