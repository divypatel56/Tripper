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
    public partial class Detail2 : ContentPage
    {
        public Detail2()
        {
            InitializeComponent();
            var listView = new ListView();
            listView.ItemsSource = new string[]
            {
            "Nice Place",
            "Great place",
            " Lots of walking so bring the kids and wear them out."

            };
        }

        

         async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Database.SaveBookingAsync(new Booking
            {
               Place=place.Text,
               Value=value.Text,
               
            });
            place.Text = value.Text=String.Empty;

            
        }
    }
}