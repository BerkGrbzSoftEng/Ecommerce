using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("CompanyContact")]
    public class CompanyContact:IEntity
    {
        public int ID { get; set; }
        [Required]
        [StringLength(15)]
        public string Phone1 { get; set; }
        [Required]
        [StringLength(15)]
        public string Phone2 { get; set; }
        [Required]
        [StringLength(15)]
        public string Address { get; set; }
        [Required]
        [StringLength(15)]
        public string Email { get; set; }
        [StringLength(75)]
        public string FacebookUrl { get; set; }
        [StringLength(75)]
        public string InstagramUrl { get; set; }
        [StringLength(75)]
        public string LinkedInUrl { get; set; }
        [StringLength(75)]
        public string TwitterUrl { get; set; }
    }
}
