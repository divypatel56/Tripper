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
    public partial class Details : ContentPage
    {
        public Details()
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
      

      
    }
}