using MediatR;

namespace POC.BookNow.Domain.Commands.v1.Rooms.Deletions
{
    public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, bool>
    {
        public Task<bool> Handle(DeleteRoomCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}