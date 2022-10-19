using API.CQRS.Sample.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.CQRS.Sample.Contracts.QueryHandlers
{
    public interface IAllProductsQueryHandler
    {
        Task<List<AllProductsResponseModel>> GetListAsync();
    }
}
