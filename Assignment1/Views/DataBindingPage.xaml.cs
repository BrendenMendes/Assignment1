using System;
using Assignment1.ViewModels;

using Xamarin.Forms;

namespace Assignment1.Views
{
    public partial class DataBindingPage : ContentPage
    {
        public DataBindingPage()
        {
            DataBindingViewModel dbvm = new DataBindingViewModel();
            BindingContext = dbvm;
            Device.StartTimer(new TimeSpan(0, 0, 01), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    dbvm.updateTime();
                    Console.WriteLine(dbvm.dateTime);
                    InitializeComponent();
                });
                return true;
            });
            
        }
    }
}
