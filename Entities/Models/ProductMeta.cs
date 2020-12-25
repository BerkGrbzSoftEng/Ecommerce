using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("ProductMeta")]
    public class ProductMeta:IEntity
    {
        public int ID { get; set; }
        public int ProductID { get; set; }

        [StringLength(75)]
        public string Key { get; set; }
        [Column(TypeName = "text")]
        public string Content { get; set; }
 
    }
}
