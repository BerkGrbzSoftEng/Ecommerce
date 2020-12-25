using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("Option")]
    public class Option:IEntity
    {
 
        public int ID { get; set; }
        public int OptionGroupID { get; set; }
        [StringLength(50)]
        public string OptionName { get; set; }
 
    }
}
