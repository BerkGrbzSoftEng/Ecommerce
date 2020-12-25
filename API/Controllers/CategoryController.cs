using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using DataAccess.Abstract;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryDal _categoryDal;

        public CategoryController(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        [HttpGet("CategoryList")]
        public async Task<IActionResult> GetCategoryList()
        {
            var result = _categoryDal.GetList();
            ICollection<CategoryModel> modelView=new List<CategoryModel>();
            foreach (var item in result.Result)
            {
                CategoryModel categoryModel=new CategoryModel();
                categoryModel.CategoryName = item.CategoryName;
                categoryModel.ID = item.ID;
                categoryModel.MetaTitle = item.MetaTitle;
                categoryModel.UrlRoute = item.UrlRoute;
                categoryModel.Description = item.Description;
                modelView.Add(categoryModel);
                
            }
            return Ok(modelView.ToList());
        }
    }
}
