using CQRS.Data.context;
using CQRS.Data.Models;
using CQRS.Repositories;
using MediatR;

namespace CQRS.Queries
{
    public class GetAllltemsQuery : IRequest<List<Item>>
    {
    }

    public class GetAllltemsQueryHandler : IRequestHandler<GetAllltemsQuery, List<Item>>
    {
        private readonly IItemRepository _ItemRepo;

        public GetAllltemsQueryHandler(IItemRepository itemRepo)
        {
            _ItemRepo = itemRepo;
        }

        public  async Task<List<Item>> Handle(GetAllltemsQuery request, CancellationToken cancellationToken)
        {
            var result = _ItemRepo.GetAllItems();

            if (result.Any())
                return result;
            else
                return new List<Item>();

        }
    }
}
