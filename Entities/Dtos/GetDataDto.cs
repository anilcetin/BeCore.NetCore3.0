using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class GetDataDto : IDto
    {
        public string HexId { get; set; }
        public string DiscordId { get; set; }
        public string ServerName { get; set; }
        public string ReasonName { get; set; }
        public string ReasonDate { get; set; }

    }
}
