using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinSample.Models;
using XamarinSample.Tools;

namespace XamarinSample.ViewModels
{
    public class ListPersonneViewModel : ViewModelBase
    {
        public ObservableCollection<Personne> liste { get; set; }

        private Personne _selectedPerson;

        public Personne SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                if (_selectedPerson != value)
                {
                    _selectedPerson = value;
                    App.Current.MainPage.Navigation.PushModalAsync(new DetailView(_selectedPerson));
                }
            }
        }

        public ListPersonneViewModel()
        {
            liste = new ObservableCollection<Personne>
            {
                new Personne { Email = "steve@mail.com", Nom ="Steve", Telephone = "0123/45.67.89"},
                new Personne { Email = "michael@mail.com", Nom ="Michael", Telephone = "0321/45.12.89"},
                new Personne { Email = "khun@mail.com", Nom ="Khun", Telephone = "0789/45.67.32"}
            };
        }
    }
}
