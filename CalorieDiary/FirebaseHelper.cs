using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Essentials;


namespace CalorieDiary
{
    class FirebaseHelper
    {
        FirebaseClient firebase = new
        FirebaseClient("https://caloriediary-f4de0-default-rtdb.firebaseio.com/");

        public async Task AddRecord(string dt, string m, double c, double p)
        {
            await firebase.Child("CalorieHistory").PostAsync(new CalorieHistory()
            {
                DateRecorded = dt,
                Meal = m,
                Calorie = c,
                Protein = p,
            });
        }

        public async Task<List<CalorieHistory>> GetAllDailyCalorie()
        {
            return (await firebase
            .Child("CalorieHistory")
            .OnceAsync<CalorieHistory>()).Select(item => new CalorieHistory
            {
                DateRecorded = item.Object.DateRecorded,
                Meal = item.Object.Meal,
                Calorie = item.Object.Calorie,
                Protein = item.Object.Protein
            }).ToList();
        }
    }

   

}
