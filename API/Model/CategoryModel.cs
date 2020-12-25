using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string UrlRoute { get; set; }
        public string SubTitle { get; set; }
        public string MetaTitle { get; set; }
    }
}
