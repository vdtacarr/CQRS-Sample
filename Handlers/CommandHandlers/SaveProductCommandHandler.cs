using API.CQRS.Sample.Contracts.CommandHandlers;
using API.CQRS.Sample.Data;
using API.CQRS.Sample.Data.Entities;
using API.CQRS.Sample.RequestModels.CommandRequestModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API.CQRS.Sample.Handlers.CommandHandlers
{
    public class SaveProductCommandHandler : IRequestHandler<SaveProductRequestModel, int>
    {
        public readonly MyWorldDbContext _myWorldDbContext;
        public SaveProductCommandHandler(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        public async Task<int> Handle(SaveProductRequestModel request, CancellationToken cancellationToken)
        {
            var newProducts = new Products
            {
                Description = request.Description,
                Manufacturer = request.Manufacturer,
                Name = request.Name,
                Price = request.Price
            };

            _myWorldDbContext.Products.Add(newProducts);
            await _myWorldDbContext.SaveChangesAsync();
            return newProducts.ProductId;
        }
    }
}
