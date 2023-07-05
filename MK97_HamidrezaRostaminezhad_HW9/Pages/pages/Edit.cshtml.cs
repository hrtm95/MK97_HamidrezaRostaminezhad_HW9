using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Interface;

namespace MK97_HamidrezaRostaminezhad_HW9.Pages.pages
{
    public class EditModel : PageModel
    {

        private IProductRepository _productRepository;

        public EditModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [BindProperty]
        public Product product { get; set; }

        public void OnGet(int id)
        {
            product = _productRepository.GetProductById(id);
        }
        public IActionResult OnPost(Product product)
        {
            _productRepository.Edit(product);
            return RedirectToPage("Index");
        }
    }
}
