﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Money :ContentPage
    {
        public DateTime CurrentDate { get; set; }
        public Money(string username)
        {
            InitializeComponent();
            CurrentDate = DateTime.Now;
            BindingContext = this;
        }

        private void Dollar(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(Dollarinput.Text) > 0)
                    Euro.Text = Convert.ToString(Convert.ToDouble(Dollarinput.Text) * 1.075);
                else
                {
                    Euro.Text = "...";
                }
            }
            catch
            {
                Euro.Text = "...";
            }
        }
    }
}