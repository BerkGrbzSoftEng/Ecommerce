using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("Country")]
    public class Country:IEntity
    {
 
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string CountryName { get; set; }
        [Required]
        [StringLength(3)]
        public string Code { get; set; }
 
    }
}
