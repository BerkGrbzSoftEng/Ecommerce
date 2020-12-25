using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("Address")]
    public class Address:IEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        [StringLength(120)]
        public string Address1 { get; set; }
        [StringLength(120)]
        public string Address2 { get; set; }
        public int CountryID { get; set; }
        public int CityID { get; set; }
        public int DistrictID { get; set; }
        [StringLength(10)]
        public string PostCode { get; set; }

    }
}
