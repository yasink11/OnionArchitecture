using OnionArchitecture.Application.DTO;

namespace OnionArchitecture.Application.Features.Products.Queries.GetAllProdcuts
{
    public class GetAllProductsQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public BrandDto Brand { get; set; }
    }
}