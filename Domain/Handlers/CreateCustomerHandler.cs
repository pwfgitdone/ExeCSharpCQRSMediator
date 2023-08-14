using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Handlers {
    public class CreateCustomerHandler: IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse {
                Id = Guid.NewGuid(),
                Name = "Name",
                Email = "Email",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}