using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pataufnahme.WPF.ViewModels.CompViewModels
{
	public class NameViewModel : BaseViewModel
	{

        private string _vorname;

        public string Vorname
        {
            get { return _vorname; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _vorname = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _nachname;

		public string Nachname
		{
			get { return _nachname; }
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
                    _nachname = value;
                    OnPropertyChanged();
                }
			}
		}


		private string _geburtsname;

		public string Geburtsname
		{
			get { return _geburtsname; }
			set
			{
				_geburtsname = value;
				OnPropertyChanged();
			}
		}

		private DateTime _geburtsdatum;

		public DateTime Geburtsdatum
		{
            get { return _geburtsdatum; }
            set
            {
                
                _geburtsdatum = value;
                OnPropertyChanged();
                //OnPropertyChanged(nameof(GeburtsdatumString));
            }
        }

        private string _geschlecht;

        public string Geschlecht
        {

            get { return _geschlecht; }
            set
            {
                _geschlecht = value;
                OnPropertyChanged();
            }
        }

        /*public string GeburtsdatumString
        {
            get { return _geburtsdatum.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture); }
            set
            {
                DateTime parsedDate;
                if (DateTime.TryParseExact(value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    Geburtsdatum = parsedDate;
                }
                else
                {
                    throw new ArgumentException("Ungültiges Datumsformat. Bitte verwenden Sie 'dd.MM.yyyy'.");
                }
            }
        }*/

        public NameViewModel(string vn,string n,string geburtsna,DateTime gebsda,string gesch)
        {
            Vorname = vn;
            Nachname = n;
            Geburtsname = geburtsna;
            Geburtsdatum = gebsda;
            Geschlecht = gesch;
        }


    }
}
