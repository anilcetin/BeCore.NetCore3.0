using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Certificate : IEntity
    {
        [Key]
        public int CertificateId { get; set; }
        public string Title { get; set; }
        public string MembershipId { get; set; }
        public string Logo { get; set; }
        public string Date { get; set; }
        public Guid UserId { get; set; }
    }
}