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

namespace MadOrderingssystem.Pages.Login
{
    /*
     * Lavet af:    Andreas
     * Bidraget af: 
    */
    public class EditUserModel : PageModel
    {
        
        public Customer CustomerSession { get; set; }
        [BindProperty]
        public Customer Customer { get; set; }



        public void OnGet(string id)
        {
            CustomerHandler cH = new CustomerHandler();
            Customer = cH.Get(id);
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
            
            CustomerHandler cH = new CustomerHandler();
            cH.Update(Customer,Customer.ID);

            return RedirectToPage("LoginList");

        }
    }
}
