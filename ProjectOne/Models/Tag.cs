using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int VendorId { get; set; }
        public Vendor vendor { get; set; }

    }
}
