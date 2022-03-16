using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            if(userName.Text == "bsmith" && password.Text == "1234")
            {
                Navigation.PushAsync(new OrderPage());
            } else
            {
                DisplayAlert("Incorrect", "Login Details incorrect", "OK");
            }
        }
    }
}