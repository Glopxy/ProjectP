namespace PinternAPI.Core.Domain
{
    public class Intern
    {
        public int Id { get; set; }
        public string? NameSurname { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Definition { get; set; }
        public DateTime? StartDate { get; set; }
        public Boolean isActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public int AppRoleId { get; set; }
        public AppRole? AppRole { get; set; }
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public Intern()
        {
            Transaction = new Transaction();
        }
    }
}
