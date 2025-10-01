using Bogus;
using POC.BookNow.Domain.Entities.v1;

namespace POC.BookNow.Tests.Mocks.Domain.Entities.v1
{
    public static class RoomMock
    {
        public static Room CreateRoomEntityMock()
        {
            return new Faker<Room>("pt_BR")
                .CustomInstantiator (fake => new Room(
                  fake.Random.Int(1, 1000),
                    fake.Commerce.Department(),
                    fake.Random.Int(1, 100),
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