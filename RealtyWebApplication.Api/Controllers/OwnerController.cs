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
    public class OwnerController : ControllerBase
    {
        private readonly IDynamicRepository<Owner> _owner;
        public OwnerController(IDynamicRepository<Owner> owner)
        {
            _owner = owner; 
        }

        [HttpGet]
        [Route("api/Owner/get")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _owner.GetAll());
        }
    }
}