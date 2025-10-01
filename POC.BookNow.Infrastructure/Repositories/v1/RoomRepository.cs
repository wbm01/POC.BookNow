using POC.BookNow.Domain.Entities.v1;
using POC.BookNow.Domain.Interfaces.v1.Repositories;

namespace POC.BookNow.Infrastructure.Repositories.v1
{
    public class RoomRepository : IRoomRepository
    {
        public List<Room> Rooms { get; set; } = [];

        public async Task<int> InsertRoomAsync(
            Room entityRoom, 
            CancellationToken cancellationToken
        )
        {
            try
            {
                foreach (var room in Rooms)
                {
                    if (room.Name == entityRoom.Name)
                    {
                        throw new ArgumentException($"Name já cadastrado no database.");
                    }
                }

                Rooms.Add(entityRoom);

                return await Task.FromResult(entityRoom.Id);
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> DeleteRoomAsync(
            int roomId,
            CancellationToken cancellationToken
        )
        {
            try
            {
                Rooms.RemoveAll(room => room.Id == roomId);

                return await Task.FromResult(true);
            }
            catch
            {
                throw;
            }
        }
    }
}