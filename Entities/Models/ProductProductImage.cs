using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class ProductProductImage:IEntity
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int ProductImageID { get; set; }
        public int? ProductOptionID { get; set; }

 
    }
}
