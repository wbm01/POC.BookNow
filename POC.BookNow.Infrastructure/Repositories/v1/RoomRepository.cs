using POC.BookNow.Domain.Entities.v1;
using POC.BookNow.Domain.Interfaces.v1.Repositories;

namespace POC.BookNow.Infrastructure.Repositories.v1
{
    public class RoomRepository : IRoomRepository
    {
        public List<Room> Rooms { get; set; } = new List<Room>();

        public Task<Guid> InsertRoom(Room entityRoom, CancellationToken cancellationToken)
        {
            try
            {
                foreach (var room in Rooms)
                {
                    if (room.Name == entityRoom.Name)
                    {
                        throw new Exception();
                    }
                }

                Rooms.Add(entityRoom);

                return Task.FromResult(Guid.NewGuid());
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao inserir sala: " + entityRoom.Name);
            }
        }
    }
}