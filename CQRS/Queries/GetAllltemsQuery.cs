using CQRS.Data.context;
using CQRS.Data.Models;
using MediatR;

namespace CQRS.Queries
{
    public class GetAllltemsQuery : IRequest<List<Item>>
    {
    }

    public class GetAllltemsQueryHandler : IRequestHandler<GetAllltemsQuery, List<Item>>
    {
        private readonly AppDbContext _dbContext;

        public GetAllltemsQueryHandler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public  async Task<List<Item>> Handle(GetAllltemsQuery request, CancellationToken cancellationToken)
        {
            var result = _dbContext.Items.ToList();

            if (result.Any())
                return result;
            else
                return new List<Item>();

        }
    }
}
