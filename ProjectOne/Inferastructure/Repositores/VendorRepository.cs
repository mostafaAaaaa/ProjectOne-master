using ProjectOne.Contexts;
using ProjectOne.DTOs;
using ProjectOne.Inferastructure.IRepositores;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Inferastructure.Repositores
{
    public class VendorRepository : IVendorRepository
    {
        private readonly ConvectionContext _ConvectionContext;
        public VendorRepository(ConvectionContext ConvectionContext)
        {
            _ConvectionContext = ConvectionContext;
        }
        public List<Tag> GetListTagRepository()
        {
          return  _ConvectionContext.Tags.ToList();
        
        }   

        public List<Vendor> GetListVendorRepository()
        {
            return _ConvectionContext.vendors.ToList();
           
        }

        public int InsertVendorRepository(Vendor vendor)
        {
             _ConvectionContext.vendors.Add(vendor);
            return _ConvectionContext.SaveChanges();
        }
    }
}
