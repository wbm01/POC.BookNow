using MediatR;

namespace POC.BookNow.Domain.Commands.v1.Rooms.Updates
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, int>
    {
        public Task<int> Handle(UpdateRoomCommand command, CancellationToken cancellationToken)
        {
            return Task.FromResult(command.Id);
        }
    }
}