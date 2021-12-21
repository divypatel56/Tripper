using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tripper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCart : ContentPage
    {
        public AddCart()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetBookingAsync();
        }
    }
}
