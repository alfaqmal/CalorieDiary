using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalorieDiary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyCalorie : ContentPage
    {
        public DailyCalorie()
        {
            InitializeComponent();
        }

        async void CalorieCalculator(object sender, EventArgs args)
        {
            await Browser.OpenAsync("https://www.mayoclinic.org/healthy-lifestyle/weight-loss/in-depth/calorie-calculator/itt-20402304", BrowserLaunchMode.SystemPreferred);

        }


    }


}