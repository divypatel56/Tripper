using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tripper
{
    public class MainViewModel : INotifyPropertyChanged
    {
        



        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Places> Places;
        private ObservableCollection<Hotels> Hotels;

        public ObservableCollection<Hotels> hotels
        {
            get { return Hotels; }
            set
            {
                Hotels = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("hotels"));
            }
        } public ObservableCollection<Places> places
        {
            get { return Places; }
            set
            {
                Places = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("places"));
            }
        }


        public MainViewModel(){
            
            places = new ObservableCollection<Places>();
            hotels = new ObservableCollection<Hotels>();
            addData();
            addData1();
            
           
        }

       

        private void addData()
        {
            places.Add(new Places
            {

                Id = 0,
                Title = "The beautiful lake",
                Country = "Norway",
                imgSource = "https://images.pexels.com/photos/2217365/pexels-photo-2217365.jpeg"
            });
            places.Add(new Places
            {

                Id = 1,
                Title = "Adventure of snow",
                Country = "Nepal",
                imgSource = "https://images.pexels.com/photos/753772/pexels-photo-753772.jpeg"

            });
            places.Add(new Places
            {

                Id = 2,
                Title = "Beach is where life is",
                Country = "Maldives",
                imgSource = "https://images.pexels.com/photos/6023784/pexels-photo-6023784.jpeg"
            });
        }

        private void addData1()
        {
            hotels.Add(new Hotels
            {
                Id=0,
                Title =  "The Marriot",
                Country="NewYork",
                imgSource = "https://images.pexels.com/photos/3678857/pexels-photo-3678857.jpeg"
            });
            hotels.Add(new Hotels
            {
                Id=1,
                Title =  "Eclips Edge",
                Country="LA",
                imgSource = "https://images.pexels.com/photos/3643104/pexels-photo-3643104.jpeg"
            }); 
            hotels.Add(new Hotels
            {
                Id=2,
                Title =  "The Skyline",
                Country="Toronto",
                imgSource = "https://images.pexels.com/photos/771328/pexels-photo-771328.jpeg"
            });
        }

        

       

       
    }
}
