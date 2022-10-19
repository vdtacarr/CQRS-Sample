using API.CQRS.Sample.RequestModels.CommandRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.CQRS.Sample.Contracts.CommandHandlers
{
    public interface ISaveProductCommandHandler
    {
        Task<int> SaveAsync(SaveProductRequestModel requestModel);
    }
}
