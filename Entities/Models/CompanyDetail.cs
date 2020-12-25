using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{

    [Table("CompanyDetail")]
    public class CompanyDetail:IEntity
    {
        public int ID { get; set; }
        [Column(TypeName = "text")]
        public string Vision { get; set; }
        [Column(TypeName = "text")]
        public string Mission { get; set; }
        [Column(TypeName = "text")]
        public string AboutUs { get; set; }
    }
}
