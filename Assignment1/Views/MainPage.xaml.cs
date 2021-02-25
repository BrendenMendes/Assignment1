using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment1.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public static implicit operator MainPage(LoginPage v)
        {
            throw new NotImplementedException();
        }
    }
}
