using MediatR;

namespace POC.BookNow.Domain.Commands.v1.Rooms.Updates
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, Guid>
    {
        public Task<Guid> Handle(UpdateRoomCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid());
        }
    }
}