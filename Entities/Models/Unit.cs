using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class Unit:IEntity   
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string UnitName { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }
    }
}
