using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class ProductOption:IEntity
    {
 
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int OptionID { get; set; }
        public decimal OpitonPriceIncrement { get; set; }
        public int OptionGroupID { get; set; }
        public bool Active { get; set; }
 
    }
}
