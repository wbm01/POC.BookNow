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
        public async Task<int> InsertRoomAsync(
            [FromBody] CreateRoomCommand command,
            CancellationToken cancellationToken
        )
        {
            return await _mediator.Send(command);
        }

        [HttpPut(Name = "UpdateRoom")]
        public async Task<int> UpdateRoomAsync(
            [FromBody]UpdateRoomCommand command,
            CancellationToken cancellationToken
        )
        {
            return await _mediator.Send(command);
        }

        [HttpDelete("{id:int}", Name = "DeleteRoom")]
        public async Task<bool> DeleteRoomAsync(
            [FromRoute]int id,
            CancellationToken cancellationToken
        )
        {
            return await _mediator.Send(new DeleteRoomCommand(id));
        }
    }
}