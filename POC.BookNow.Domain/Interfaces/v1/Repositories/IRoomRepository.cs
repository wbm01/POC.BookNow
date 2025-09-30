using POC.BookNow.Domain.Entities.v1;

namespace POC.BookNow.Domain.Interfaces.v1.Repositories
{
    public interface IRoomRepository
    {
        public Task<Guid> InsertRoom(Room entityRoom, CancellationToken cancellationToken);
    }
}