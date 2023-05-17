namespace ProjectP.Core.Application.Dto
{
    public class TransactionListDto
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? checkInOut { get; set; }
        public string? WorkTime { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
