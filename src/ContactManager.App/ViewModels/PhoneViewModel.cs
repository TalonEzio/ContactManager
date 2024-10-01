namespace ContactManager.App.ViewModels
{
    public class PhoneViewModel : BindableObject
    {
        private int _id;
        public int Id
        {
            get => _id; set => SetField(ref _id, value);
        }

        private PhoneModelType _type;

        public PhoneModelType Type
        {
            get => _type;
            set => SetField(ref _type, value);
        }

        private string _phoneNumber = string.Empty;

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => SetField(ref _phoneNumber, value);
        }
    }

    public enum PhoneModelType
    {
        Personal,
        Company
    }
}
