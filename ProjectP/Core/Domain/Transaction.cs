namespace PinternAPI.Core.Domain
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? checkInOut { get; set; }
        public string? WorkTime { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public List<Intern>? Interns { get; set; }
    }
}
