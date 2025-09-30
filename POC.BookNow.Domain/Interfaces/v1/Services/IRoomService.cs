using POC.BookNow.Domain.Commands.v1.Rooms.Creates;

namespace POC.BookNow.Domain.Interfaces.v1.Services
{
    public interface IRoomService
    {
        public Task<Guid> InsertRoomAsync(CreateRoomCommand command, CancellationToken cancellationToken);
    }
}