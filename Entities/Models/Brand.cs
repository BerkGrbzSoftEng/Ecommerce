using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("Brand")]
    public class Brand:IEntity
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(100)]
        public string MetaTitle { get; set; }
   
        [Column(TypeName = "text")]
        public string Content { get; set; }
        public byte[] Image { get; set; }

        [StringLength(100)]
        public string ImagePath { get; set; }

    }
}
