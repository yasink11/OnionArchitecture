using MediatR;
using OnionArchitecture.Application.Interfaces.RedisCache;

namespace OnionArchitecture.Application.Features.Products.Queries.GetAllProdcuts
{
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>, ICacheableQuery
    {
        public string CacheKey => "GetAllProducts";

        public double CacheTime => 60;
    }
}