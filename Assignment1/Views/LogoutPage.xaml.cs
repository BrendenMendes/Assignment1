using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment1.Views
{
    public partial class LogoutPage : ContentPage
    {
        private App myApp = Application.Current as App;
        public LogoutPage()
        {
            InitializeComponent();
        }
        private void logoutOption(object sender, EventArgs e)
        {
            myApp.navigationMain("login");
        }
    }
}
