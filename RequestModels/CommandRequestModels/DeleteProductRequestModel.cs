using MediatR;

namespace API.CQRS.Sample.RequestModels.CommandRequestModels
{
    public class DeleteProductRequestModel :IRequest<int>
    {
        public int Id { get; set; }
    }
}
