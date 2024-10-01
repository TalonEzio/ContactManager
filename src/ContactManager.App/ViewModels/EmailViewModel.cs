namespace ContactManager.App.ViewModels
{
    public class EmailViewModel : BindableObject
    {
        private int _id;
        public int Id
        {
            get => _id; set => SetField(ref _id, value);
        }

        private EmailModelType _type;

        public EmailModelType Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        private string _emailAddress = string.Empty;

        public string EmailAddress
        {
            get => _emailAddress;
            set => SetField(ref _emailAddress, value);
        }
    }

    public enum EmailModelType
    {
        Personal,
        Company
    }
}