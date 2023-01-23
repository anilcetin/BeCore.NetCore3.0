using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductDetail : IEntity
    {
        public Guid ProductDetailId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public string Url { get; set; }
        public DateTime InsertedTime { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
