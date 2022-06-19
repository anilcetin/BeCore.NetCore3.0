using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Content : IEntity
    {
        [Key]
        public Guid BlogId { get; set; }
        public string Title { get; set; }
        public string BlogContent { get; set; }
        public string Image { get; set; }
        public string CreatedDate { get; set; }
        public Guid UserId { get; set; }
    }
}