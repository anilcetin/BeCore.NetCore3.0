using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Title : IEntity
    {
        [Key]
        public Guid TitleId { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
    }
}