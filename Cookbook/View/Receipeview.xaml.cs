using Cookbook.Model;
using Cookbook.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cookbook.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Receipeview : ContentPage
    {
        Receipeviewmodel vm;
        public Receipeview()
        {
            InitializeComponent();
            vm = new Receipeviewmodel();
            //dishes.ItemsSource = vm.Dishes;
            BindingContext = vm;
        }
        public void Mylist(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Receipe;
            Navigation.PushAsync(new Detailsview(details.Name, details.Ingredients, details.Procedure, details.Imageurl));
            //App.Current.MainPage = new Detailsview(details.Name, details.Descrip);
        }



    }
}