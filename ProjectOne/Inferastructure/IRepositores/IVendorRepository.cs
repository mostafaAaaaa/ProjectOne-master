using ProjectOne.DTOs;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Inferastructure.IRepositores
{
 public   interface IVendorRepository
    {
        List<Tag> GetListTagRepository();

        List<Vendor> GetListVendorRepository();

        int InsertVendorRepository(Vendor vendor);
    }
}
