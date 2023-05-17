namespace PinternAPI.Core.Domain
{
    public class AppRole
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
        public List<Intern>? Interns { get; set; }
    }
}
