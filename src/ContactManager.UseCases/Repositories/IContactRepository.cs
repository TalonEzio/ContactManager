using ContactManager.Domain.Entities;

namespace ContactManager.UseCases.Repositories
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAll();

        Task<Contact> CreateNew(Contact newContact);
        Task Update(Contact editedContact);
        Task<bool> Delete(Contact deleteContact);

        Task<Contact?> FindContact(int contactId);

    }
}
