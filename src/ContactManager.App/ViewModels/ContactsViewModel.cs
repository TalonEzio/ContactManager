using AutoMapper;

using System.ComponentModel;
using ContactManager.UseCases.Services;

namespace ContactManager.App.ViewModels
{
    public class ContactsViewModel(IContactService contactService, IMapper mapper) : BaseViewModel
    {
        public BindingList<ContactViewModel> Contacts = [];

        private ContactViewModel _selectedContact = new();
        public ContactViewModel SelectedContact
        {
            get => _selectedContact;
            set => SetField(ref _selectedContact, value);
        }
        public override async Task LoadAsync()
        {
            var data = await contactService.LoadAllContacts();
            foreach (var contact in data)
            {
                var contactModel = mapper.Map<ContactViewModel>(contact);
                Contacts.Add(contactModel);
            }

            _selectedContact = Contacts.First();
        }
    }
}
