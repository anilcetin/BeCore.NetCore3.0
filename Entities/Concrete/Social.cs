using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Social : IEntity
    {
        [Key]
        public Guid SocialnetworkId { get; set; }
        public string Link { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
    }
}