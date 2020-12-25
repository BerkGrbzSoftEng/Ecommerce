using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class City:IEntity
    {
 
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string CityName { get; set; }
        public int CountryID { get; set; }
        [Required]
        [StringLength(12)]
        public string PlaqueNo { get; set; }
        [Required]
        [StringLength(12)]
        public string PhoneCode { get; set; }

 
    }
}
