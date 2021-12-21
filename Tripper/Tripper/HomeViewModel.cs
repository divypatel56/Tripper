using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tripper
{
   
    public class HomeViewModel
    {
        public ICommand NewNavigationCommand { get; set; }

        public HomeViewModel()
        {
            NewNavigationCommand = new Command(async () => await NewNavigationAction());
        }

        async Task NewNavigationAction()
        {
            await Shell.Current.GoToAsync(nameof(AddCart));
        }
    }

}
