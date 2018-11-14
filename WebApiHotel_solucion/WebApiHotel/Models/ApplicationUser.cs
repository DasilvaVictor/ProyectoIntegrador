using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Models
{
    public class ApplicationUser:IdentityUser
    {
        public int DNI { get; set; }
    }
}
