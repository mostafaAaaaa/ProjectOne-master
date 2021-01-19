using Microsoft.AspNetCore.Mvc;
using ProjectOne.DTOs;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.ApplicationServices.IServices
{
 public   interface IVendorServices
    {
        List<TagDto> GetListTagServices();

        List<VendorDto> GetListVendorServices();

        JsonResult InsertNewVendor(Vendor vendor);

    }
}
