using Moq;
using POC.BookNow.Domain.Commands.v1.Rooms.Creates;
using POC.BookNow.Domain.Interfaces.v1.Services;
using POC.BookNow.Tests.Mocks.Domain.Commands.v1.Rooms.Creates;
using POC.BookNow.Tests.Mocks.Domain.Entities.v1;

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
        public async Task ShouldInsertRomAsync()
        {
            var commandRoomMock = CreateRoomCommandMock.CreateRoomMock();
            var roomMock = RoomMock.CreateRoomEntityMock();
            var roomServiceMock = new Mock<IRoomService>();
            var insertRoomInt = commandRoomMock.Id;

            roomServiceMock.Setup(
                service => 
                service.InsertRoomAsync(
                    roomMock, 
                    CancellationToken.None
                )
            ).Returns(
                Task.FromResult(
                    insertRoomInt
                )
            );

            var handle = EstablishContext(roomServiceMock.Object);

            var result = await handle.Handle(commandRoomMock, CancellationToken.None);

            Assert.Equal(result, insertRoomInt);
        }
    }
}