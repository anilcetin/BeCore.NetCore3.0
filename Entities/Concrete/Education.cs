using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Education : IEntity
    {
        [Key]
        public Guid EducationId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Date { get; set; }
        public string EducationName { get; set; }
        public Guid UserId { get; set; }
    }
}