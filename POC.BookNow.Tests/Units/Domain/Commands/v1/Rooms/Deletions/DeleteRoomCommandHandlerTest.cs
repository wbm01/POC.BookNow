using Moq;
using POC.BookNow.Domain.Commands.v1.Rooms.Deletions;
using POC.BookNow.Domain.Interfaces.v1.Services;

namespace POC.BookNow.Tests.Units.Domain.Commands.v1.Rooms.Deletions
{
    public class DeleteRoomCommandHandlerTest
    {
        public DeleteRoomCommandHandler EstablishContext(IRoomService? roomService = null)
        {
            roomService ??= new Mock<IRoomService>().Object;

            return new DeleteRoomCommandHandler(roomService);
        }

        [Fact(DisplayName = "Should Delete Room")]
        public async Task ShouldDeleteRoomAsync()
        {

        }
    }
}