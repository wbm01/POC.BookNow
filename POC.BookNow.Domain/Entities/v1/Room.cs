namespace POC.BookNow.Domain.Entities.v1
{
    public class Room(
        int id, 
        string name, 
        int capacity, 
        List<string> resources
    )
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public int Capacity { get; set; } = capacity;
        public List<string> Resources { get; set; } = resources;
    }
}