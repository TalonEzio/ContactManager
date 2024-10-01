namespace ContactManager.Domain.Entities
{
    [Serializable]
    public class Phone
    {
        public int Id { get; set; }
        public PhoneType Type { get; set; }
        public required string PhoneNumber { get; set; }
    }

    public enum PhoneType
    {
        Personal,
        Company
    }
}
