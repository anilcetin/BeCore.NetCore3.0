using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Portfolio : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string PortfolioImg { get; set; }
        public string PortfolioTitle { get; set; }
        public string PortfolioUrl { get; set; }
        public Guid UserId { get; set; }
    }
}