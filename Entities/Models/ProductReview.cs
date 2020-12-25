using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class ProductReview:IEntity
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Nullable<int> Rating { get; set; }
        [StringLength(75)]
        public string Title { get; set; }
        public bool Published { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        [Column(TypeName = "text")]
        public string Content { get; set; }
 
    }
}
