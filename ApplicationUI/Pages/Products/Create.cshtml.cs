using ApplicationUI.Services;
using DataAccessLayer.ReqDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApplicationUI.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ProductApiClient _apiClient;

        [BindProperty]
        public required ProductCreateReq Product { get; set; }

        public CreateModel(ProductApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _apiClient.CreateProduct(Product);
            return RedirectToPage("Index");
        }
    }
}
