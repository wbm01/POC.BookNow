using MediatR;
using POC.BookNow.Domain.Entities.v1;
using POC.BookNow.Domain.Interfaces.v1.Services;

namespace POC.BookNow.Domain.Commands.v1.Rooms.Creates
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, int>
    {
        private readonly IRoomService _roomService;

        public CreateRoomCommandHandler(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task<int> Handle(
            CreateRoomCommand command, 
            CancellationToken cancellationToken
        )
        {
            var entity = new Room(
                command.Id,
                command.Name,
                command.Capacity,
                command.Resources
                );

            return await _roomService.InsertRoomAsync(
                entity, 
                cancellationToken
            );
        }
    }
}