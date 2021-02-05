using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XCTShieldSample
{
    public partial class MainPage : ContentPage
    {
        public Command TappedShield { get; set; }

        public MainPage()
        {
            InitializeComponent();

            TappedShield = new Command(() => DisplayAlert("Subscribed", "You're now subscribed, thanks!", "OK"));

            BindingContext = this;
        }
    }
}
