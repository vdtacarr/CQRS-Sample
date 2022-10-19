using API.CQRS.Sample.Data;
using API.CQRS.Sample.RequestModels.CommandRequestModels;
using MediatR;
using System.Linq;
using System.Threading.Tasks;
namespace API.CQRS.Sample.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductRequestModel, int>
    {
        public readonly MyWorldDbContext _myWorldDbContext;
        public DeleteProductCommandHandler(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        public async Task<int> Handle(DeleteProductRequestModel model, System.Threading.CancellationToken cancellationToken)
        {
            var products = _myWorldDbContext.Products.ToList();
            var product = _myWorldDbContext.Products.AsQueryable().FirstOrDefault(x => x.ProductId == model.Id);

            _myWorldDbContext.Products.Remove(product);
            await _myWorldDbContext.SaveChangesAsync();
            return model.Id;
        }
    }
    //public class ProductMapper : Profile
    //{
    //}
}
