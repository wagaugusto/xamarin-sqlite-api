﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppSample.Models;
using AppSample.ViewModels;

namespace AppSample.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Person Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}