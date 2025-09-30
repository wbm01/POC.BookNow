using MediatR;
using POC.BookNow.Domain.Interfaces.v1.Services;

namespace POC.BookNow.Domain.Commands.v1.Rooms.Creates
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, Guid>
    {
        private readonly IRoomService _roomService;

        public CreateRoomCommandHandler(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task<Guid> Handle(CreateRoomCommand roomCommand, CancellationToken cancellationToken)
        {
            return await _roomService.InsertRoomAsync(roomCommand, cancellationToken);
        }
    }
}