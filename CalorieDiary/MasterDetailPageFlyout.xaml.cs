using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalorieDiary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageFlyout : ContentPage
    {
        public ListView ListView;

        public MasterDetailPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MasterDetailPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPageFlyoutMenuItem> MenuItems { get; set; }

            public MasterDetailPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPageFlyoutMenuItem>(new[]
                {
                    new MasterDetailPageFlyoutMenuItem { Id = 0, Title = "About", TargetType=typeof(aboutPages) },
                    new MasterDetailPageFlyoutMenuItem { Id = 1, Title = "Calorie Intake", TargetType=typeof(MainPage) },
                    new MasterDetailPageFlyoutMenuItem { Id = 2, Title = "History", TargetType=typeof(History)  },
                    new MasterDetailPageFlyoutMenuItem { Id = 3, Title = "Calorie Counter", TargetType=typeof(DailyCalorie) },
                    new MasterDetailPageFlyoutMenuItem { Id = 4, Title = "Protein Counter",TargetType=typeof(DailyProtein) },
                    
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}