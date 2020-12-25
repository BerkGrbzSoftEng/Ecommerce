using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("MainCategory")]
    public class MainCategory : IEntity
    {
        
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string MainCategoryName { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [StringLength(50)]
        public string UrlRoute { get; set; }
        [StringLength(50)]
        public string MetaTitle { get; set; }
        [StringLength(50)]
        public string SubTitle { get; set; }
        public bool Active { get; set; }
        public Nullable<DateTime> CreatedAT { get; set; }
        public Nullable<int> Order { get; set; }
 
    }
}
