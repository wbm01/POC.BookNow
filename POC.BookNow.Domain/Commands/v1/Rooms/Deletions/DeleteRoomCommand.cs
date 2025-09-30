using MediatR;

namespace POC.BookNow.Domain.Commands.v1.Rooms.Deletions
{
    public class DeleteRoomCommand : IRequest<bool>
    {
        public DeleteRoomCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}