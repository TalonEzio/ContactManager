using System.ComponentModel;

namespace ContactManager.App.ViewModels
{
    public class ContactViewModel : BindableObject
    {
        private int _id;
        public int Id
        {
            get => _id; set => SetField(ref _id, value);
        }

        private string _contactName = string.Empty;

        public string ContactName
        {
            get => _contactName;
            set => SetField(ref _contactName, value);
        }

        private string _alias = string.Empty;
        public string Alias
        {
            get => _alias;
            set => SetField(ref _alias, value);
        }

        private string _firstName = string.Empty;
        public string FirstName
        {
            get => _firstName;
            set => SetField(ref _firstName, value);
        }

        private string _lastName = string.Empty;
        public string LastName
        {
            get => _lastName;
            set => SetField(ref _lastName, value);
        }

        private DateTime _dateOfBirth = DateTime.Now;


        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => SetField(ref _dateOfBirth, value);

        }
        public BindingList<EmailViewModel> Emails { get; set; } = [];
        public BindingList<PhoneViewModel> Phones { get; set; } = [];
    }
}