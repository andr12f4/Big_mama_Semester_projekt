using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadOrderingssystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MadOrderingssystem.Pages.Login
{
    public class log_inModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }

        public void OnGet()
        {
            //HttpContext.Session.Set(HttpContext.Session.Id,);
        }
    }
}
