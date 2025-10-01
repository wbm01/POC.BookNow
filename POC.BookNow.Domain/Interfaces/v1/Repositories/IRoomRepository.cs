using POC.BookNow.Domain.Entities.v1;

namespace POC.BookNow.Domain.Interfaces.v1.Repositories
{
    public interface IRoomRepository
    {
        Task<int> InsertRoomAsync(Room entityRoom, CancellationToken cancellationToken);
        Task<bool> DeleteRoomAsync(int roomId, CancellationToken cancellationToken);
    }
}