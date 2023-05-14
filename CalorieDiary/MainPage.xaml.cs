using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace CalorieDiary
{
    public partial class MainPage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();

        //string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CalorieHistory.txt");
        public MainPage()
        {
            InitializeComponent();
        }

        void OnReset(object sender, EventArgs e)
        {
            inputMeal.Text = null;
            inputCalorie.Text = null;
            inputProtein.Text = null;
           
        }

        void onDatePickerSelected(object sender, DateChangedEventArgs e)
        {
            var selectedDate = e.NewDate.ToString();
        }

        async void OnSaveHistory(object sender, EventArgs e)
        {
            /*var writerRecord = selectDate.Date.ToString("dd/MM/yyyy") + "\nMeals: " + inputMeal.Text + "\nCalorie: " + inputCalorie.Text  + "Kcal" + "\nProtein: " + inputProtein.Text + "g" + "\n";
             File.AppendAllText(fileName, writerRecord + Environment.NewLine);*/

            var selectdate = selectDate.Date.ToString("dd/MM/yyyy");
            string Meal = inputMeal.Text;
            var Calorie = Double.Parse(inputCalorie.Text);
            var Protein = Double.Parse(inputProtein.Text);
            await firebaseHelper.AddRecord(selectdate, Meal, Calorie, Protein);
            await DisplayAlert("Record Saved", "Your Data has been saved", "OK");

        }

    }
    }
