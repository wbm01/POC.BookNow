using MediatR;
using POC.BookNow.Domain.Interfaces.v1.Services;

namespace POC.BookNow.Domain.Commands.v1.Rooms.Deletions
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, bool>
    {
        private readonly IRoomService _roomService;

        public DeleteRoomCommandHandler(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task<bool> Handle(
            DeleteRoomCommand command, 
            CancellationToken cancellationToken
        )
        {
            return await _roomService.DeleteRoomAsync(command.Id, cancellationToken);
        }
    }
}