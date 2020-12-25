using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public partial class ProductBrand:IEntity
    {
        public int ID { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
 
    }
}
