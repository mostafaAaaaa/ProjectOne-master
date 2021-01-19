using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectOne.ApplicationServices.IServices;
using ProjectOne.DTOs;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorServices _IVendorServices ;

       

        public VendorController(IVendorServices iVendorServices)
        {
            _IVendorServices = iVendorServices;
        }

        [HttpGet]
        public IActionResult GetAllVendors()
        {
            return Ok(_IVendorServices.GetListVendorServices());
          //  return null;
          
        }

        [HttpPost]
        public IActionResult AddVendor(Vendor dto)
        {
            return _IVendorServices.InsertNewVendor( dto);
        }

        [HttpPut]
        public IActionResult UpdateVendor()
        {
            return null;
        }


        [HttpDelete]
        public IActionResult DeleteVendor()
        {
            return null;
        }
    }
}
