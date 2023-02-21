using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace App1
{
    public partial class QuotesPage : ContentPage
    {
        string sliderValue = "16";
        public QuotesPage()
        {
            InitializeComponent();
            sliderValue = slider1.Value.ToString() ;
            fontSize.Text = "Font Size - " + sliderValue;
            quote.Text = "You can't blame gravity for falling in love";
            quote.FontSize = Convert.ToDouble(sliderValue);
        }

        void slider1_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            sliderValue = slider1.Value.ToString(); ;
            fontSize.Text = "Font Size - " + sliderValue;
            quote.FontSize = Convert.ToDouble(sliderValue);
        }
    }
}

