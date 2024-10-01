using ContactManager.Domain.Entities;
using ContactManager.UseCases.Repositories;

namespace ContactManager.UseCases.Services
{
    public class ContactService(IContactRepository contactRepository) : IContactService
    {
        public async Task<IEnumerable<Contact>> LoadAllContacts()
        {
            return await contactRepository.GetAll();
        }

        public Task<Contact> AddNewContact(Contact newContact)
        {
            var result = contactRepository.CreateNew(newContact);
            return result;
        }

        public async Task<Contact> UpdateContact(Contact editedContact)
        {
            
            await contactRepository.Update(editedContact);
            return editedContact;

        }

        public async Task<bool> DeleteContact(Contact deleteContact)
        {
            var result = await contactRepository.Delete(deleteContact);
            return result;
        }
    }
}
