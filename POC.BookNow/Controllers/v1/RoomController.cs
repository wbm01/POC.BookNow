using MediatR;
using Microsoft.AspNetCore.Mvc;
using POC.BookNow.Domain.Commands.v1.Rooms.Creates;
using POC.BookNow.Domain.Commands.v1.Rooms.Deletions;
using POC.BookNow.Domain.Commands.v1.Rooms.Updates;

namespace POC.BookNow.Controllers.v1
{
    [Route("api/v1/room")]
    [ApiController]
    public class RoomController : Controller
    {
        private IMediator _mediator;

        public RoomController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "InsertRoom")]
        public async Task<Guid> InsertRoomAsync([FromBody] CreateRoomCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut("{id:guid}", Name = "UpdateRoom")]
        public async Task<Guid> UpdateRoomAsync([FromRoute]Guid id, [FromBody]UpdateRoomCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpDelete("{id:guid}", Name = "DeleteRoom")]
        public async Task<bool> DeleteRoomAsync([FromRoute]Guid id, [FromBody]DeleteRoomCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
