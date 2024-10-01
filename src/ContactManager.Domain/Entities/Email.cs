namespace ContactManager.Domain.Entities
{
    [Serializable]
    public class Email
    {
        public int Id { get; set; }
        public EmailType Type { get; set; }
        public required string EmailAddress { get; set; }
    }

    public enum EmailType
    {
        Personal,
        Company
    }
}