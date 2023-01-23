using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public Guid ProductId { get; set; }
        public Guid TenantId { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public Category Category { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public Stock Stock { get; set; }
    }
}