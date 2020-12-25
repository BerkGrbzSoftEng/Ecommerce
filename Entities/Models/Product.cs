using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("Product")]
    public class Product : IEntity
    {
  
        public int ID { get; set; }
        [Required]
        [StringLength(75)]
        public string ProductName { get; set; }
        public string Description { get; set; }
        [Required]
        [StringLength(75)]
        public string Title { get; set; }
        [StringLength(100)]
        public string MetaTitle { get; set; }
        [StringLength(100)]
        public string Slug { get; set; }
        [Column(TypeName = "text")]
        public string Summary { get; set; }
        [Required]
        [StringLength(75)]
        public string SKU { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public int Quantity { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> PublishedAt { get; set; }
        public bool Shop { get; set; }
        public Nullable<int> UnitID { get; set; }
        public int MainCatID { get; set; }
        public int CatID { get; set; }
        public int SubCatID { get; set; }
 
    }
}
