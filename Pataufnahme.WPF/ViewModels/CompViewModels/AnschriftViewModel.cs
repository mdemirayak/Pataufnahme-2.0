using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pataufnahme.WPF.ViewModels.CompViewModels
{
    public class AnschriftViewModel : BaseViewModel
    {
        private string _straße;

        public string Straße
        {

            get { return _straße; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _straße = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _land;

        public string Land
        {

            get { return _land; }
            set
            {
                _land = value;
                OnPropertyChanged();
            }
        }

        private string _plzOrt;

        public string PlzOrt
        {

            get { return _plzOrt; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _plzOrt = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _region;

        public string Region
        {

            get { return _region; }
            set
            {
                _region = value;
                OnPropertyChanged();
            }
        }

        private string _telefon;

        public string Telefon
        {

            get { return _telefon; }
            set
            {
                _telefon = value;
                OnPropertyChanged();
            }
        }

        private string _email;

        public string Email
        {

            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public AnschriftViewModel(string straße,string plzOrt, string land = null , string region = null, string telefon = null, string email = null)
        {
            Straße = straße;
            PlzOrt = plzOrt;
            Land = land;
            Region = region;
            Telefon = telefon;
            Email = email;
        }

        

        
    }
}
