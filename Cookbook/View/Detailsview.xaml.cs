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
    public partial class Detailsview : ContentPage
    {
        
        //private Receipe receipe;
        Detailsviewmodel v;
        //private string name;
        //private string descrip;

        public Detailsview()
        {
            InitializeComponent();
            v = new Detailsviewmodel();
            //dishes.ItemsSource = vm.Dishes;
            BindingContext = v;
        }

        public Detailsview(string name, string descrip, string steps, string image)
        {
            InitializeComponent();
            
            dishname.Text = name;
            ing.Text = descrip;
            pro.Text = steps;
            img.Source = image;
        }
    }
}