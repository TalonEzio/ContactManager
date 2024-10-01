using ContactManager.Domain.Entities;

namespace ContactManager.UseCases.Services
{
    public interface IContactService
    {
        public Task<IEnumerable<Contact>> LoadAllContacts();

        public Task<Contact> AddNewContact(Contact newContact);
        public Task<Contact> UpdateContact(Contact editedContact);
        public Task<bool> DeleteContact(Contact deleteContact);
    }
}
