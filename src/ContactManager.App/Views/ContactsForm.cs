using ContactManager.App.ViewModels;
using ContactManager.Domain.Entities;

namespace ContactManager.App.Views
{
    public partial class ContactsForm : Form
    {
        private readonly ContactsViewModel _contactsViewModel;

        public ContactsForm(ContactsViewModel contactsViewModel)
        {
            InitializeComponent();
            _contactsViewModel = contactsViewModel;
            contactBindingSource.DataSource = _contactsViewModel;


            Load += ContactsForm_Load;

        }

        private void BindingProperties()
        {
            numId.DataBindings.Add(nameof(numId.Value), contactBindingSource, $"{nameof(ContactsViewModel.SelectedContact)}.{nameof(ContactsViewModel.SelectedContact.Id)}", true, DataSourceUpdateMode.OnPropertyChanged);
            txtContactName.DataBindings.Add(nameof(Text), contactBindingSource, $"{nameof(ContactsViewModel.SelectedContact)}.{nameof(ContactsViewModel.SelectedContact.ContactName)}", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAlias.DataBindings.Add(nameof(Text), contactBindingSource, $"{nameof(ContactsViewModel.SelectedContact)}.{nameof(ContactsViewModel.SelectedContact.Alias)}", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFirstName.DataBindings.Add(nameof(Text), contactBindingSource, $"{nameof(ContactsViewModel.SelectedContact)}.{nameof(ContactsViewModel.SelectedContact.FirstName)}", true, DataSourceUpdateMode.OnPropertyChanged);
            txtLastName.DataBindings.Add(nameof(Text), contactBindingSource, $"{nameof(ContactsViewModel.SelectedContact)}.{nameof(ContactsViewModel.SelectedContact.LastName)}", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpDateOfBirth.DataBindings.Add(nameof(dtpDateOfBirth.Value), contactBindingSource, $"{nameof(ContactsViewModel.SelectedContact)}.{nameof(ContactsViewModel.SelectedContact.DateOfBirth)}", true, DataSourceUpdateMode.OnPropertyChanged);

            dgvContacts.DataSource = _contactsViewModel.Contacts;
        }

        private async void ContactsForm_Load(object? sender, EventArgs e)
        {

            await _contactsViewModel.LoadAsync();

            BindingProperties();
        }

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null)
            {
                _contactsViewModel.SelectedContact = (dgvContacts.CurrentRow.DataBoundItem as ContactViewModel)!;
                contactBindingSource.ResetBindings(false);

            }
        }
    }
}
