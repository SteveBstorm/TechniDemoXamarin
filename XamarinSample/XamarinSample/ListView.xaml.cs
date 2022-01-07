using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinSample.Models;
using XamarinSample.ViewModels;

namespace XamarinSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
        
        public ListView()
        {
            BindingContext = new ListPersonneViewModel();
           
            InitializeComponent();
        }
    }
}