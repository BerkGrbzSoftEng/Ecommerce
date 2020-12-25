using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("OptionGroup")]
    public class OptionGroup:IEntity
    {
 
        public int ID { get; set; }
        [StringLength(50)]
        public string GroupName { get; set; }
 
    }
}
