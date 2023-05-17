namespace PinternAPI.Core.Application.Dto
{
    public class InternListDto
    {
        public int Id { get; set; }
        public string? NameSurname { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Definition { get; set; }
        public DateTime? StartDate { get; set; }
        public Boolean? isActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get;set; }
    }
}
