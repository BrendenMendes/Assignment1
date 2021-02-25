using System;
using Xamarin.Forms;

namespace Assignment1.ViewModels
{
    public class DataBindingViewModel : ContentPage
    {
        public string dateTime { get; set; }

        public DataBindingViewModel()
        {
            updateTime();
        }

        public void updateTime() {
            dateTime = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}

