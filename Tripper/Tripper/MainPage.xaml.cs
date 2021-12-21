using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace Tripper
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
          
        }

         void cart_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Trip Bucket", "Pack Your Bags", "Aboard:)");
            Navigation.PushAsync(new AddCart());
        }

        private void detail_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new Detail2());    
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Detail1());
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Details());
        }
    }

}