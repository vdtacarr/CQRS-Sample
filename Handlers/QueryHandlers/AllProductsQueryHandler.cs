using API.CQRS.Sample.Contracts.QueryHandlers;
using API.CQRS.Sample.Data;
using API.CQRS.Sample.ResponseModels.QueryResponseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.CQRS.Sample.Handlers.QueryHandlers
{
    public class AllProductsQueryHandler :IAllProductsQueryHandler
    {
        private readonly MyWorldDbContext _myWorldDbContext;
        public AllProductsQueryHandler(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        public async Task<List<AllProductsResponseModel>> GetListAsync()
        {
            return await _myWorldDbContext.Products
            .Select(_ => new AllProductsResponseModel
            {
                Description = _.Description,
                ProductId = _.ProductId,
                Manufacturer = _.Manufacturer,
                Name = _.Name,
                Price = _.Price
            }).ToListAsync();
        }
    }
}
