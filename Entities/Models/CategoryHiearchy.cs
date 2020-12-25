using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    [Table("CategoryHiearchy")]
    public class CategoryHiearchy:IEntity   
    {
     
        public int ID { get; set; }
        public int MainCatID { get; set; }
        public int CatID { get; set; }
        public int SubCatID { get; set; }
        public Nullable<bool> Active { get; set; }
        public int Sort { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
  
    }
}
