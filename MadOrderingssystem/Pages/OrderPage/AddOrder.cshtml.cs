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

namespace MadOrderingssystem.Pages.OrderPage
{
    /*
     * Lavet af:    Andreas
     * Bidraget af: Mikkel
    */
    public class AddOrderModel : PageModel
    {
        [BindProperty]
        public Order Order { get; set; } = new Order();
        [BindProperty]
        public Customer Customer { get; set; }
        [BindProperty]
        public Customer CustomerSession {get;set;}
        public List<Product> OrderListBasketSession { get; set; }
        public IActionResult OnGet()
        {
            try
            {
                OrderListBasketSession = JsonConvert.DeserializeObject<List<Product>>(HttpContext.Session.GetString("basket"));
            }
            catch (ArgumentNullException ex) { }
            try
            {
                CustomerSession = JsonConvert.DeserializeObject<Customer>(HttpContext.Session.GetString("user"));
            }
            catch (ArgumentNullException ex) { }

            if (CustomerSession != null)
            {
                Order.customer = CustomerSession;
            }
            Order.products = OrderListBasketSession;
            foreach(Product product in Order.products)
            {
                Order.TotalPrice = Order.TotalPrice + product.Price;
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (CustomerSession != null)
            {
                Order.customer = CustomerSession;
                Order.TotalPrice = Order.TotalPrice * 0.85;
            }
            else
            {
                Order.customer = Customer;
            }

            OrderHandler orderHandler = new OrderHandler();
            orderHandler.Create(Order);
            return RedirectToPage("/Index");
        }
    }
}
