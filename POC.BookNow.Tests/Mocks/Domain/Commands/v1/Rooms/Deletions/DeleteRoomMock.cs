using Bogus;
using POC.BookNow.Domain.Commands.v1.Rooms.Deletions;

namespace POC.BookNow.Tests.Mocks.Domain.Commands.v1.Rooms.Deletions
{
    public static class DeleteRoomMock
    {
        public static DeleteRoomCommand CreateDeleteMock()
        {
            return new Faker<DeleteRoomCommand>("pt_BR")
                .CustomInstantiator(fake => new DeleteRoomCommand(
                    fake.Random.Int(1, 100)
                ))
                .Generate();
        }
    }
}