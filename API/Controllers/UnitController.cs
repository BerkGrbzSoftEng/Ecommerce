using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private IUnitDal _unitDal;

        public UnitController(IUnitDal unitDal)
        {
            _unitDal = unitDal;
        }
        [HttpGet("GetListUnit")]
        public async Task<ActionResult> GetList()
        {
            var result = await _unitDal.GetList();
            List<UnitModel> model = new List<UnitModel>();
            if (result != null)
            {
                foreach (var item in result)
                {
                    UnitModel obj=new UnitModel();
                    obj.ID = item.ID;
                    obj.UnitName = item.UnitName;
                    obj.Code = item.Code;
                    model.Add(obj);
                   
                }
                return Ok(model);
            }

            return BadRequest("No Value");
        }

        [HttpGet("GetUnit")]
        public async Task<ActionResult> Get()
        {
            var result = await _unitDal.Get(2);
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest("No Value");
        }
        [HttpGet("UnitAdd")]
        public async Task<ActionResult> Add()
        {
            Unit model = new Unit();
            model.UnitName = "Kilogram";
            model.Code = "kg";

            var result = await _unitDal.Add(model);
            if (result)
            {
                return Ok("Kayit Başarılı");
            }

            return BadRequest("Kayıt Başarısız");
        }

        [HttpGet("UnitUpdate")]
        public async Task<ActionResult> Update()
        {
            
            Unit model = new Unit();
            model.ID = 1;
            model.UnitName = "Hakkımetre";
            model.Code = "hm";

            var result = await _unitDal.Update(model);
            if (result)
            {
                return Ok("Güncelleme Başarılı");
            }

            return BadRequest("Güncelleme Başarısız");
        }

        [HttpGet("UnitDelete")]
        public async Task<ActionResult> Delete()
        {

            Unit model = new Unit();
            model.ID = 1;
            model.UnitName = "Hakkımetre";
            model.Code = "hm";

            var result = await _unitDal.Delete(model);
            if (result)
            {
                return Ok("Silme İşlemi Başarılı");
            }

            return BadRequest("Silme İşlemi Başarısız");
        }
    }
}
