using CQRS.Data.Models;
using CQRS.Repositories;
using MediatR;

namespace CQRS.commands
{
    public class AddItemsCommand : IRequest<Item>
    {
        public Item item { get; set; }
    }

    public class AddItemCommandHandler : IRequestHandler<AddItemsCommand, Item>
    {
        private readonly IItemRepository _itemRepository;

        public AddItemCommandHandler(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<Item> Handle(AddItemsCommand request, CancellationToken cancellationToken)
        {
           _itemRepository.AddItem(request.item);

            return request.item;
        }
    }

}
