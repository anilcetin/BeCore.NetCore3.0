using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Data: IEntity
    {
        public int Id { get; set; }
        public string HexId { get; set; }
        public string ServerId { get; set; }
        public string ReasonId { get; set; }
        public string ReasonDate { get; set; }
        public string DiscordId { get; set; }
    }
}
