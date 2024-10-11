using CQRS.commands;
using CQRS.Data.Models;
using CQRS.Queries;
using CQRS.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace CQRS_MediatoR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMediator _mediator;

        public ItemController(IItemRepository itemRepository , IMediator mediator)
        {
            _itemRepository = itemRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            var result = await _mediator.Send(new GetAllltemsQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddItem(Item item)
        {
            if (item == null)
                return BadRequest("Empty Item");
            var reuslt = await _mediator.Send(new AddItemsCommand()
            {
                item = item
            });

            return Ok(reuslt);
        }
    }
}
