﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkillPool.Core.Views.IM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatView : ContentPage
    {
        public ChatView()
        {
            InitializeComponent();

            //NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}