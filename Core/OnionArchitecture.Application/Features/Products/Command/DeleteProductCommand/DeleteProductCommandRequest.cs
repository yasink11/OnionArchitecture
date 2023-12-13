using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Products.Command.DeleteProductCommand
{
    public class DeleteProductCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
