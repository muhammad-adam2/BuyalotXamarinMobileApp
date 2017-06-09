﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuyalotXamarinMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesList : ContentPage
    {
        public CategoriesList()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCategoryy());
        }
    }
}
