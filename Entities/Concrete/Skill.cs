using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Skill : IEntity
    {
        [Key]
        public Guid SubSkillId { get; set; }
        public int SkillId { get; set; }
        public string Name { get; set; }
        public int Percentile { get; set; }
        public Guid UserId { get; set; }
    }
}