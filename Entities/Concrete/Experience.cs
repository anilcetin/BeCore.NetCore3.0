using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Experience : IEntity
    {
        [Key]
        public Guid ExperienceId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Date { get; set; }
        public string Company { get; set; }
        public Guid UserId { get; set; }
    }
}