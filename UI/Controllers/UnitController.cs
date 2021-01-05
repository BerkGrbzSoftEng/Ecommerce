using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Models;
using UI.Models;

namespace UI.Controllers
{

    public class UnitController : Controller
    {
        private IUnitService _unitService;

        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        [HttpGet("Unit")]
        public IActionResult UnitList()
        {

            var obj = _unitService.GetAll();
            List<UnitModel> model = new List<UnitModel>();
            foreach (var item in obj.Result)
            {
                UnitModel list = new UnitModel();
                list.ID = item.ID;
                list.UnitName = item.UnitName;
                list.Code = item.Code;
                model.Add(list);
            }
            return View(model);
        }
        [HttpPost("Unit/Add")]
        public IActionResult UnitAdd(UnitModel model)
        {
            Unit unit = new Unit();
            unit.UnitName = model.UnitName;
            unit.Code = model.Code;
            
            Thread.Sleep(2000);
            return Json(new{response="Success"});
        }
    }
}
