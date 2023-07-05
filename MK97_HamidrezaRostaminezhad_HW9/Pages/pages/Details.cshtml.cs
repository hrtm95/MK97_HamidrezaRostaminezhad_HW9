using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Interface;

namespace MK97_HamidrezaRostaminezhad_HW9.Pages.pages
{
    public class DetailsModel : PageModel
    {
        private IProductRepository _productRepository;

        public DetailsModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [BindProperty]
        public Product product { get; set; }


        public IActionResult OnGet(int id)
        {
            product = _productRepository.GetProductById(id);
            if (product == null)
            { 
                return RedirectToPage("404");
            }
            return Page();
        }
    }
}
