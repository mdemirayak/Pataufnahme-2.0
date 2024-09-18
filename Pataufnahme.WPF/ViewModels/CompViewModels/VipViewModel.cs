using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pataufnahme.WPF.ViewModels.CompViewModels
{
    public class VipViewModel : BaseViewModel
    {
        private string _titel;

        public string Titel
        {

            get { return _titel; }
            set
            {
                _titel = value;
                OnPropertyChanged();
            }
        }

        private string _bemerkung;

        public string Bemerkung
        {

            get { return _bemerkung; }
            set
            {
                _bemerkung = value;
                OnPropertyChanged();
            }
        }


        private string _patientenWunsch;

        public string PatientenWunsch
        {

            get { return _patientenWunsch; }
            set
            {
                _patientenWunsch = value;
                OnPropertyChanged();
            }
        }

        public VipViewModel(string t, string b, string patwunsch)
        {
            Titel = t;
            Bemerkung = b;
            PatientenWunsch = patwunsch;
        }
    }
}
