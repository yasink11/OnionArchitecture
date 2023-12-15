using MediatR;

namespace OnionArchitecture.Application.Features.Products.Queries.GetAllProdcuts
{
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
    {
    }
}