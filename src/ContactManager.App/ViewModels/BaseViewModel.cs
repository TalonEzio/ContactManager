using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ContactManager.App.ViewModels
{
    public class BaseViewModel : BindableObject
    {
        public virtual Task LoadAsync()
        {
            return Task.CompletedTask;
        }

    }
}
