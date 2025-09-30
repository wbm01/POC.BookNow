using System.Data;

namespace POC.BookNow.Domain.Entities.v1
{
    public class ReserveRoom(
        int id, int salaId, 
        string responsable, 
        DateTime dateBegin, 
        DateTime dateEnd
    )
    {
        public int Id { get; set; } = id;
        public int SalaId { get; set; } = salaId;
        public string Responsable { get; set; } = responsable;
        public DateTime DateBegin { get; set; } = dateBegin;
        public DateTime DateEnd { get; set; } = dateEnd;
    }
}