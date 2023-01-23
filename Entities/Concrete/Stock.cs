using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Stock : IEntity
    {
        public Guid StockId { get; set; }
        public int StockValue { get; set; }
        public int? MinimumStock { get; set; }
        public int? MaximumStock { get; set; }
        public bool StockControl { get; set; }
    }
}
