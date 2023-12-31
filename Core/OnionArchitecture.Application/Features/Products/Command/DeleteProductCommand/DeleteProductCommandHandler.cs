﻿using MediatR;
using Microsoft.AspNetCore.Http;
using OnionArchitecture.Application.Bases;
using OnionArchitecture.Application.Interfaces.AutoMapper;
using OnionArchitecture.Application.Interfaces.UnitOfWorks;
using OnionArchitecture.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Products.Command.DeleteProductCommand
{
    public class DeleteProductCommandHandler :BaseHandler, IRequestHandler<DeleteProductCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteProductCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            product.IsDeleted = true;

            await unitOfWork.GetWriteRepository<Product>().UpdateAsync(product);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
        
    }
}
