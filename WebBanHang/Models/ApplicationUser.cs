using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class ApplicationUser:IdentityUser
    {
        public String Fullname { set; get; }
        public DateTime Birhday { set; get; }
        public Boolean Sex { get; set; }

    }
}
