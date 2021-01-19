using Microsoft.AspNetCore.Mvc;
using ProjectOne.ApplicationServices.IServices;
using ProjectOne.DTOs;
using ProjectOne.Inferastructure.IRepositores;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProjectOne.ApplicationServices.Services
{
    public class VendorServices : IVendorServices
    {
        private readonly IVendorRepository _vendorRepository;
        

        public VendorServices(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public List<TagDto> GetListTagServices()
        {
            throw new NotImplementedException();
        }

        //public List<TagDto> GetListTagServices()
        //{
        //    throw new NotImplementedException();
        //}

        public List<VendorDto> GetListVendorServices()
        {
            var listVendor = _vendorRepository.GetListVendorRepository();
            var listTag = _vendorRepository.GetListTagRepository();

            var listTagDto = listTag.Select(x => new TagDto
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            var listVendorDto = listVendor.Select(x => new VendorDto
            {
                Id = x.Id,
               Adress=x.Adress,
               Date=x.Date,
               Email=x.Email,
               Title=x.Title,
               PhoneNumber=x.PhoneNumber,
               VendorName=x.VendorName   ,
               tagDtos= listTagDto

            }).ToList();

          

            //List<TagDto> listTagDtos = new List<TagDto>();
            //for(int i=0;i< listTag.Count; i++)
            //{
            //    TagDto tag = new TagDto()
            //    {
            //      Id= listTag[i].Id,
            //      Name = listTag[i].Name
            //    };
            //}

            //List<VendorDto> listVendorDto = new List<VendorDto>();
            //for (int i = 0; i < listVendor.Count; i++)
            //{
            //    VendorDto vendorDto = new VendorDto()
            //    {
            //        Id = listTag[i].Id,
            //        Adress = listTag[i].vendor.Adress,
            //        Email = listTag[i].vendor.Email,
            //        PhoneNumber = listTag[i].vendor.PhoneNumber,
            //        Date = listTag[i].vendor.Date,
            //        Title = listTag[i].vendor.Title,
            //        VendorName = listTag[i].vendor.VendorName,

            //    }

            //    }


            //    GridGetVendorDTO gridGetVendorDTO = new GridGetVendorDTO();
            // gridGetVendorDTO.tagDtos;
            return listVendorDto;
            //throw new NotImplementedException();
        }

        public JsonResult InsertNewVendor(Vendor vendor)
        {
            //List<Tag> listTagDtos = new List<Tag>();
            //for (int i = 0; i < vendor.tagDtos.Count; i++)
            //{
            //    listTagDtos.Add(vendor.tagDtos[i]);
            //}
            //    //for(int i=0;i< listTag.Count; i++)

                //{
                //    TagDto tag = new TagDto()
                //    {
                //      Id= listTag[i].Id,
                //      Name = listTag[i].Name
                //    };
                //}


                int result = _vendorRepository.InsertVendorRepository(vendor);
            if (result>0)
            {
                return new JsonResult(new { HttpStatusCode = HttpStatusCode.OK});
            }
            else { return new JsonResult(new { HttpStatusCode = HttpStatusCode.BadRequest }); }
        }
    }
}
