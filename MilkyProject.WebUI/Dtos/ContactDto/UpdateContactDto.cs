namespace MilkyProject.WebUI.Dtos.ContactDto
{
    public class UpdateContactDto
    {
        public int ContactId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
