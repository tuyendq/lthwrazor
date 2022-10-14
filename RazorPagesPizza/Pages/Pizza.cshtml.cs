using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;

namespace RazorPagesPizza.Pages
{
    public class PizzaModel : PageModel
    {
      [BindProperty]
      public Pizza NewPizza { get; set; }
        public void OnGet()
        {
        }
    }
}
