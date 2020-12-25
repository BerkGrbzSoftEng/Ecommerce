using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class ProductImage:IEntity   
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string ImagePath { get; set; }
        [Required]
        public byte[] Image { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> PublishedAt { get; set; }
        public Nullable<bool> Active { get; set; }
 
    }
}
