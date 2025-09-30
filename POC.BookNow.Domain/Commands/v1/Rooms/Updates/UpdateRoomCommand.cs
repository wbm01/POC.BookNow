using MediatR;

namespace POC.BookNow.Domain.Commands.v1.Rooms.Updates
{
    public class UpdateRoomCommand : IRequest<Guid>
    {
        public UpdateRoomCommand(int id, string name, int capacity, List<string> resources)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            Resources = resources;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<string> Resources { get; set; }

    }
}