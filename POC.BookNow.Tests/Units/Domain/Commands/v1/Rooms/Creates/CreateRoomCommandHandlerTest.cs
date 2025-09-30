using Moq;
using POC.BookNow.Domain.Commands.v1.Rooms.Creates;
using POC.BookNow.Domain.Interfaces.v1.Services;
using POC.BookNow.Tests.Mocks.Domain.Commands.v1.Rooms.Creates;

namespace POC.BookNow.Tests.Units.Domain.Commands.v1.Rooms.Creates
{
    public class CreateRoomCommandHandlerTest
    {
        public CreateRoomCommandHandler EstablishContext(
            IRoomService? roomService = null
        )
        {
            roomService ??= new Mock<IRoomService>().Object;

            return new CreateRoomCommandHandler(roomService);
        }

        [Fact (DisplayName = "Should Insert a Room")]
        public async Task ShouldInsertRom()
        {
            var roomMock = RoomMock.CreateRoomMock();
            var roomServiceMock = new Mock<IRoomService>();
            var insertRoomGuid = Guid.NewGuid();

            roomServiceMock.Setup(
                service => 
                service.InsertRoomAsync(
                    roomMock, 
                    CancellationToken.None
                )
            ).Returns(
                Task.FromResult(
                    insertRoomGuid
                )
            );

            var handle = EstablishContext(roomServiceMock.Object);

            var result = await handle.Handle(roomMock, CancellationToken.None);

            Assert.Equal(result, insertRoomGuid);
        }
    }
}