﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FromPractice.Views.DataBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicCodeBindingPage : ContentPage
    {
        public BasicCodeBindingPage()
        {
            InitializeComponent();

            //1、在cs中实现绑定
            label.BindingContext = slider;  //源
            label.SetBinding(Label.RotationProperty, "Value");

        }
    }
}