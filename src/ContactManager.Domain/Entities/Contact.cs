namespace ContactManager.Domain.Entities
{
    [Serializable]
    public class Contact
    {
        public int Id { get; set; }
        public string ContactName { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public List<Email> Emails { get; set; } = [];
        public List<Phone> Phones { get; set; } = [];
    }
}