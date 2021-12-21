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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

         void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Log in","Successfully logged in","Ok");
            Navigation.PushAsync(new MainPage());
        }
    }
}