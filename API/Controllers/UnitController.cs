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
        private IUnitService _unitService;

        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }


        [HttpGet("GetListUnit")]
        public async Task<ActionResult> GetList()
        {
            var result = await _unitService.GetAll();
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

        [HttpPost("Add")]
        public async Task<bool> AddUnit(Unit model)
        {
            return await _unitService.Add(model);
        }

        [HttpPut("Update")]
        public async Task<bool>Update(Unit unit)
        {
            return await _unitService.Update(unit);
        }

        [HttpDelete("Delete")]
        public async Task<bool> Delete(Unit unit)
        {
            return await _unitService.Delete(unit);
        }
        [HttpDelete("Delete/{unitId:int}")]
        public async Task<bool> Delete(int unitId)
        {
            return await _unitService.Delete(unitId);
        }
    }
}
