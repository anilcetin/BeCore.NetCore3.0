using Castle.Components.DictionaryAdapter;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public Guid CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }

    }
}
