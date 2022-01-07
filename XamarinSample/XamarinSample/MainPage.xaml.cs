using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //DateTime myDate = new DateTime();
            //myDate = DateTime.Now;
            
            InitializeComponent();
            //maDate.MaximumDate = myDate;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            label1.Text = "Charleroi > Liege";
            
        }

    }
}
