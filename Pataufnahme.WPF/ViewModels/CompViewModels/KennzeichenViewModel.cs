using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pataufnahme.WPF.ViewModels.CompViewModels
{
    public class KennzeichenViewModel : BaseViewModel
    {
        private string _pfSperre;

        public string Pfsperre
        {

            get { return _pfSperre; }
            set
            {
                _pfSperre = value;
                OnPropertyChanged();
            }
        }

        private string _orSpender;

        public string OrSpender
        {

            get { return _orSpender; }
            set
            {
                _orSpender = value;
                OnPropertyChanged();
            }
        }

        public ICommand PatAnlegen { get; }
        public ICommand PatSuchen { get; }
        public KennzeichenViewModel(string pf = null, string or = null)
        {
            Pfsperre = pf;
            OrSpender = or;
        }
    }
}
