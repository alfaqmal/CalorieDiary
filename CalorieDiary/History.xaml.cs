using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalorieDiary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class History : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        //string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CalorieHistory.txt");
        public History()
        {
            InitializeComponent();

            //displayHistory.Text = File.ReadAllText(fileName);

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            displayHistory.ItemsSource = await firebaseHelper.GetAllDailyCalorie();
        }
    }
}