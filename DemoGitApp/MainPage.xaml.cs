﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoGitApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.BackgroundColor = Color.Red;
        }
        void MakeYellow(object sender, System.EventArgs e)
        {
            this.BackgroundColor = Color.Yellow;
        }
        void MakeGreen(object sender, System.EventArgs e)
        {
            this.BackgroundColor = Color.Green;
        }
    }
}
