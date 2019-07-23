using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App479
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<testViewModel> myModels = new ObservableCollection<testViewModel>();

        testViewModel model;
        public MainPage()
        {
            InitializeComponent();

            myModels.Add(new testViewModel { Name = "age" });
            myModels.Add(new testViewModel { Name = "gender" });
            myModels.Add(new testViewModel { Name = "name" });

            testListView.ItemsSource = myModels;
        }
    }

    class testViewModel 
    {
        public string Name { get; set; }
        public string Desc { get; set; }

    }
}
