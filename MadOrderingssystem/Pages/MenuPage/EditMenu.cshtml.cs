using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using MadOrderingssystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace MadOrderingssystem.Pages.MenuPage
{
    public class EditMenuModel : PageModel
    {

        public Customer CustomerSession { get; set; }

        [BindProperty]
        public Menu Menu { get; set; }


        public void OnGet(string id)
        {
            ProductHandler pH = new ProductHandler();
            Menu = pH.Get(id);
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }


        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ProductHandler pH = new ProductHandler();
            pH.Update(Menu, Menu.Id);

            return RedirectToPage("MenuTable");

        }
    }

}
