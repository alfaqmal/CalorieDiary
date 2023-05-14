using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalorieDiary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyProtein : ContentPage
    {
        public DailyProtein()
        {
            InitializeComponent();
        }

        void OnCalculateProtein(object sender, EventArgs e)
        {
            var weight = 0.0;
            var proteinintake = 0.0;

            if ((Double.TryParse(inputWeight.Text, out weight)))
            {
                proteinintake = weight * 0.8;
                outputResult.Text = string.Format("{0:##.00}", proteinintake);
            }
            else
            {
                outputResult.Text = "Please enter a valid value";
            }

        }

        void OnReset(object sender, EventArgs e)
        {
            inputWeight.Text = null;
            outputResult.Text = "0.00";

        }
    }
}