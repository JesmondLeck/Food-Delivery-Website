using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Models
{
    public class ApplicationRole: IdentityRole<int>
    {
        public ApplicationRole() { }

        public ApplicationRole(string name)
        {
            Name = name;
        }
    }
}
