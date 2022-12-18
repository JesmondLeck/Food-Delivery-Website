using M.O.FoodDelivery.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Areas.Identity.Pages.DirectedPages
{
    [Authorize(Roles = "Owner")]

    public class RegisterRestaurantModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegisterRestaurantModel(
            UserManager<ApplicationUser> userManager
            )
        { 
            _userManager = userManager;
        }

        [BindProperty]
        public RestaurantModel Restaurant { get; set; }

        public string ReturnUrl { get; set; }


        public class RestaurantModel
        {
            [Required]
            [StringLength(30, ErrorMessage = "The name can only be up to 30 characters long")]
            [Display(Name = "Name")]
            public string Name { get; set; }

            [Required]
            [StringLength(150, ErrorMessage = "The description can only be up to 150 characters long")]
            [Display(Name = "Description")]
            public string Description { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The address can only be up to 100 characters long")]
            [Display(Name = "Address")]
            public string Address { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/owner/home");
            if (ModelState.IsValid)
            {
                var restaurant = new Restaurant
                {
                    Name = Restaurant.Name,
                    Description = Restaurant.Description,
                    Address = Restaurant.Address,
                    Owner = await _userManager.GetUserAsync(HttpContext.User)
                };
                //NOTE: Modify it so that when restaurant is created, navigate to restaurant owners' home page
                //var result = await _userManager.CreateAsync(user, Input.Password);
                //if (result.Succeeded)
                //{

                //}
                return LocalRedirect(returnUrl);
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

    }
}
