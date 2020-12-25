using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Models
{
    public class ProductCatHiearchy:IEntity
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int CatHiearchyID { get; set; }
 

 
    }
}
