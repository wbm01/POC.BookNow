using POC.BookNow.Domain.Entities.v1;

namespace POC.BookNow.Domain.Interfaces.v1.Services
{
    public interface IRoomService
    {
        Task<int> InsertRoomAsync(Room room, CancellationToken cancellationToken);
        Task<bool> DeleteRoomAsync(int roomId, CancellationToken cancellationToken);
    }
}