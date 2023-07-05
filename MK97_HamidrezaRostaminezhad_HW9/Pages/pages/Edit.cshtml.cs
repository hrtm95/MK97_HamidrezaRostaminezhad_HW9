using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Interface;

namespace MK97_HamidrezaRostaminezhad_HW9.Pages.pages
{
    public class EditModel : PageModel
    {

        private IProductRepository _productRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel(IProductRepository productRepository , IWebHostEnvironment webHostEnvironment)
        {
            _productRepository = productRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public Product product { get; set; }
        [BindProperty]
        public IFormFile Photo { get; set; }

        public void OnGet(int id)
        {
            product = _productRepository.GetProductById(id);
        }
        public IActionResult OnPost(Product product)
        {
            if (Photo != null)
            {
                if (product.PhotoUrl != null)
                {
                    string FileFolder =
                    Path.Combine(_webHostEnvironment.WebRootPath, "css", product.PhotoUrl);
                    System.IO.File.Delete(FileFolder);

                }
                product.PhotoUrl = ProcessUploadFile();
            }
            _productRepository.Edit(product);
            return RedirectToPage("Index");
        }



        private string ProcessUploadFile()
        {
            string uniqueFileName = null;

            if (Photo != null)
            {
                string UploadsFolder =
                    Path.Combine(_webHostEnvironment.WebRootPath, "img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(UploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}
