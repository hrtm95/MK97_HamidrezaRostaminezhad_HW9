using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Interface;

namespace MK97_HamidrezaRostaminezhad_HW9.Pages.pages
{
    public class IndexModel : PageModel
    {
        private IProductRepository _productRepository;

        public IEnumerable<Product> products;

        [BindProperty]
        public int id { get; set; }

        public IndexModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void OnGet()
        {
            products = _productRepository.GetAllProduct();
        }
        public IActionResult OnPost()
        {
            _productRepository.Delete(id);
            return RedirectToPage("Index", products);
        }
    }
}
