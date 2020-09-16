using Cookbook.Model;
using Cookbook.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Receipe = Cookbook.Model.Receipe;

namespace Cookbook.Viewmodel
{
    public class Receipeviewmodel
    {
        public List<Receipe> Dishes { get; set; }

        public Receipeviewmodel()
        {
            Dishes = new Receipe().GetDishes();
        }
        
        
     
    }
}
