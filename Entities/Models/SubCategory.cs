using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class SubCategory : IEntity
    {
   
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string SubCategoryName { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(100)]
        public string UrlRoute { get; set; }
        [StringLength(100)]
        public string SubTitle { get; set; }
        [StringLength(100)]
        public string MetaTitle { get; set; }
        public bool Active { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<int> Order { get; set; }
 

    }
}
