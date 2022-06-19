using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Contact : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string LocationPin { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool isFreelance { get; set; }
        public string LocationMaps { get; set; }
        public Guid UserId { get; set; }
    }
}