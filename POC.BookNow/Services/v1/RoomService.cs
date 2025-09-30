using POC.BookNow.Domain.Commands.v1.Rooms.Creates;
using POC.BookNow.Domain.Entities.v1;
using POC.BookNow.Domain.Interfaces.v1.Repositories;
using POC.BookNow.Domain.Interfaces.v1.Services;

namespace POC.BookNow.Domain.Services.v1
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<Guid> InsertRoomAsync(CreateRoomCommand command, CancellationToken cancellationToken)
        {
            try
            {
                if (command.Capacity < 1)
                {
                    throw new Exception();
                }

                var entity = new Room(
                command.Id,
                command.Name,
                command.Capacity,
                command.Resources
                );

                return await _roomRepository.InsertRoom(entity, cancellationToken);
            }
            catch( Exception ex)
            {
                throw new Exception($"Erro ao inserir sala. Capacity é {command.Capacity}");
            }
        }
    }
}