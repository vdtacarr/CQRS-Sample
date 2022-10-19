using API.CQRS.Sample.Contracts.CommandHandlers;
using API.CQRS.Sample.Contracts.QueryHandlers;
using API.CQRS.Sample.RequestModels.CommandRequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.CQRS.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IAllProductsQueryHandler _allProductsQueryHandler;
        private readonly IMediator _mediator;

        public ProductController(
            IAllProductsQueryHandler allProductsQueryHandler, IMediator mediator)
        {
            _allProductsQueryHandler = allProductsQueryHandler;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> SaveProductAsync(SaveProductRequestModel requestModel)
        {
            //var result = await _saveProductCommandHandler.SaveAsync(requestModel);
            var result = await _mediator.Send(requestModel);
            return Ok(result);
        }
        [HttpDelete]
        [Route("[action]")]
        public async Task<IActionResult> DeleteProduct(DeleteProductRequestModel model)
        {
            var result = await _mediator.Send(model);
            return Ok(result);
        }
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> AllProducts()
        {
            var result = await _allProductsQueryHandler.GetListAsync();
            return Ok(result);
        }
    }
}
