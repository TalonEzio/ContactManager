using System.Text.Json;
using ContactManager.Domain.Entities;
using ContactManager.UseCases.Repositories;

namespace ContactManager.Infrastructure.InFiles.Repositories
{
    public class ContactInFileRepository : IContactRepository
    {
        private const string FilePath = "contacts.json";
        private List<Contact> _contacts = [];


        public async Task<IEnumerable<Contact>> LoadFromFiles(string filePath)
        {
            if (!Path.Exists(filePath))
            {
                throw new FileNotFoundException("Không tìm thấy dữ liệu!");
            }

            var jsonContent = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<Contact>>(jsonContent) ?? [];

        }

        public Task SaveContactsToFiles(string filePath)
        {
            var stream = new FileStream(filePath, FileMode.Truncate, FileAccess.Write);
            var contactsJsonSaveTask = JsonSerializer.SerializeAsync(stream, _contacts);

            return contactsJsonSaveTask;
        }
        public async Task<IEnumerable<Contact>> GetAll()
        {
            if (!_contacts.Any())
            {
                _contacts = (await LoadFromFiles(FilePath)).ToList();
            }

            return _contacts;
        }

        public async Task<Contact> CreateNew(Contact newContact)
        {
            if (!_contacts.Any())
            {
                _contacts = (await LoadFromFiles(FilePath)).ToList();
            }

            newContact.Id = _contacts.Count + 1;

            _contacts.Add(newContact);

            await SaveContactsToFiles(FilePath);

            return newContact;
        }

        public async Task Update(Contact editedContact)
        {
            if (!_contacts.Any())
            {
                _contacts = (await LoadFromFiles(FilePath)).ToList();
            }

            var contact = await FindContact(editedContact.Id);

            if (contact == null)
            {
                throw new Exception("Không tìm thấy");
            }

            contact.Alias = editedContact.Alias;

            contact.ContactName = editedContact.ContactName;
            contact.DateOfBirth = editedContact.DateOfBirth;

            contact.Emails.Clear();
            contact.Emails.AddRange(editedContact.Emails);

            contact.FirstName = editedContact.FirstName;
            contact.LastName = editedContact.LastName;

            contact.Phones.Clear();
            contact.Phones.AddRange(editedContact.Phones);

            await SaveContactsToFiles(FilePath);

        }

        public async Task<bool> Delete(Contact deleteContact)
        {

            if (!_contacts.Any())
            {
                _contacts = (await LoadFromFiles(FilePath)).ToList();
            }

            var contact = await FindContact(deleteContact.Id);

            if (contact == null)
            {
                throw new Exception("Không tìm thấy");
            }

            _contacts.Remove(deleteContact);
            await SaveContactsToFiles(FilePath);

            return true;
        }

        public async Task<Contact?> FindContact(int contactId)
        {
            if (!_contacts.Any())
            {
                _contacts = (await LoadFromFiles(FilePath)).ToList();
            }

            return _contacts.FirstOrDefault(x => x.Id == contactId);
        }
    }
}
