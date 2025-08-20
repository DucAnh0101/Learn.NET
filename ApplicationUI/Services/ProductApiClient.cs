using DataAccessLayer.ReqDTO;
using DataAccessLayer.ResDTO;

namespace ApplicationUI.Services
{
    public class ProductApiClient
    {
        private readonly HttpClient _http;

        public ProductApiClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<IEnumerable<ProductRes>> GetProducts()
        {
            var result = await _http.GetFromJsonAsync<IEnumerable<ProductRes>>("api/product");
            return result ?? new List<ProductRes>();
        }

        public async Task<ProductRes> GetProductById(int id)
        {
            var result = await _http.GetFromJsonAsync<ProductRes>($"api/product/{id}");
            return result ?? throw new Exception($"Không tìm thấy product với id={id}");
        }

        public async Task<ProductRes> CreateProduct(ProductCreateReq req)
        {
            var res = await _http.PostAsJsonAsync("api/product", req);
            res.EnsureSuccessStatusCode();
            var result = await res.Content.ReadFromJsonAsync<ProductRes>();
            return result ?? throw new Exception("API trả về null khi tạo product");
        }
    }
}
