using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GApp
{
	public partial class MainPage : ContentPage
	{
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLogin(object sender,EventArgs e)
        {
            unamepassword.Text = uname.Text + "[]" + upassword.Text;
            NavigationPage nav = new NavigationPage(new ProductPage() { Title = "Product Page" });

        }
        //void OnTranslate(object sender, EventArgs e)
        //{
        //    translatedNumber = Core.GAppTranslator.ToNumber(phoneNumberText.Text);
        //    if (!string.IsNullOrWhiteSpace(translatedNumber))
        //    {
        //        callButton.IsEnabled = true;
        //        callButton.Text = "Call " + translatedNumber;
        //    }
        //    else
        //    {
        //        callButton.IsEnabled = false;
        //        callButton.Text = "Call";
        //    }
        //}

        //async void OnCall(object sender, EventArgs e)
        //{
        //    if (await this.DisplayAlert(
        //            "Dial a Number",
        //            "Would you like to call " + translatedNumber + "?",
        //            "Yes",
        //            "No"))
        //    {
        //        var dialer = DependencyService.Get<IDialer>();
        //        if (dialer != null)
        //            dialer.Dial(translatedNumber);
        //    }
        //}
    }
}
