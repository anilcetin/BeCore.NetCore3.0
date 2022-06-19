using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Knowledge : IEntity
    {
        [Key]
        public Guid KnowledgeId { get; set; }
        public string Title { get; set; }
        public Guid UserId { get; set; }
    }
}