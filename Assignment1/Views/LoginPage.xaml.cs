using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment1.Views
{
    public partial class LoginPage : ContentPage
    {
        private App myApp = Application.Current as App;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {
            if(username.Text == "test" && password.Text == "test")
            {
                myApp.navigationMain("main");
            }
        }
    }
}
