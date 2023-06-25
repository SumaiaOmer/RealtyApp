using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealtyWebApplication.Core.Models;
using RealtyWebApplication.Core.Repository;

namespace RealtyWebApplication.Api.Controllers
{
 
    [ApiController]
    public class RealtiesController : ControllerBase
    {
        private readonly IDynamicRepository<Realty> _realty;
        public RealtiesController(IDynamicRepository<Realty> realty)
        {
            _realty = realty;
        }
        [HttpGet]
        [Route("api/realties/get")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _realty.GetAll());
        }

        [HttpGet]
        [Route("api/realties/getbyid")]
        public async Task<IActionResult> GetById()
        {
            return Ok(await _realty.GetById(2));
        }

        [HttpPost]
        [Route("api/realties/add")]
        public IActionResult Add()
        {
            var data = _realty.AddData(new Realty { OwnerId = 2 ,RealtyName =  "Test 01", RealtyPrice = 4000    });
          
            return Ok();
        }

        [HttpPost]
        [Route("api/realties/modify")]
        public IActionResult Modify()
        {
            var data = _realty.ModifyData(new Realty {  RealtyId = 2   , RealtyName = "Test Modify", RealtyPrice = 9000 });

            return Ok();
        }

        [HttpPost]
        [Route("api/realties/remove")]
        public IActionResult Remove()
        {
            var data = _realty.RemoveData(new Realty { RealtyId = 5 });

            return Ok();
        }

    }
}