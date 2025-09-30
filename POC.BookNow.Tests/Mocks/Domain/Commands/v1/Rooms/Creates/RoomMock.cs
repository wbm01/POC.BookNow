using Bogus;
using POC.BookNow.Domain.Commands.v1.Rooms.Creates;

namespace POC.BookNow.Tests.Mocks.Domain.Commands.v1.Rooms.Creates
{
    public static class RoomMock
    {
        public static CreateRoomCommand CreateRoomMock()
        {
            var faker = new Faker("pt_BR");

            return new Faker<CreateRoomCommand>("pt_BR")
                .CustomInstantiator(f => new CreateRoomCommand(
                    f.Random.Int(1, 1000),
                    f.Commerce.Department(),
                    f.Random.Int(1, 100),
                    new List<string>
                    {
                        "pc",
                        "monitor"
                    }
                ))
                .Generate();
        }
    }
}