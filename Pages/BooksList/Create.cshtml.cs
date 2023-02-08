using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsWebApp.Model;

namespace ProductsWebApp.Pages.BooksList
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {

        }

        public Book OneBook { get; set; }
    }
}
