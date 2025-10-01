namespace POC.BookNow.Domain.Entities.v1
{
    public class Room
    {
        public Room(
            int id, 
            string name, 
            int capacity, 
            List<string> resources
        )
        {
            if (name == null)
                throw new ArgumentNullException("O nome não pode ser nulo.");

            if (capacity <= 0)
                throw new ArgumentException(
                    $"Capacity inválido. O valor é: {capacity}"
                );

            Id = id;
            Name = name;
            Capacity = capacity;
            Resources = resources;
        }

        public int Id { get; }
        public string Name { get; }
        public int Capacity { get; }
        public List<string> Resources { get;} = [];
    }
}