using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.DTOs
{
    public class GridGetVendorDTO
    {
        public ICollection<VendorDto> vendorDtos { get; set; }
        public ICollection<TagDto> tagDtos { get; set; }
    }
}
