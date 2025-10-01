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

        public async Task<int> InsertRoomAsync(
            Room room,
            CancellationToken cancellationToken
        )
        {
            try
            {
                return await _roomRepository.InsertRoomAsync(
                    room,
                    cancellationToken
                );
            }
            catch (ArgumentException exception)
            {
                throw new ArgumentException(
                    "Erro ao inserir dado no database.",
                    exception
                );
            }
        }

        public async Task<bool> DeleteRoomAsync(
            int roomId,
            CancellationToken cancellationToken
        )
        {
            return await _roomRepository.DeleteRoomAsync(roomId, cancellationToken);
        }
    }
}