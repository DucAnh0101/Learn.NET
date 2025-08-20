using ApplicationUI.Services;
using DataAccessLayer.ResDTO;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApplicationUI.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductApiClient _apiClient;
        public IEnumerable<ProductRes>? Products { get; set; }

        public IndexModel(ProductApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task OnGet()
        {
            Products = await _apiClient.GetProducts();
        }
    }
}
