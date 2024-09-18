using Pataufnahme.WPF.ViewModels.CompViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pataufnahme.WPF.ViewModels
{
    public class PatinfoViewModel : BaseViewModel
    {
		private BaseViewModel _anschriftVM;

		public BaseViewModel AnschriftVM
		{
			get { return _anschriftVM; }
			set 
			{ 
				_anschriftVM = value;
				OnPropertyChanged();
			}
		}


        private BaseViewModel _nameVM;

        public BaseViewModel NameVM
        {
            get { return _nameVM; }
            set
            {
                _nameVM = value;
                OnPropertyChanged();
            }
        }


        private BaseViewModel _vipVM;

        public BaseViewModel VipVM
        {
            get { return _vipVM; }
            set
            {
                _vipVM = value;
                OnPropertyChanged();
            }
        }


        private BaseViewModel _kennzeichenVM;

        public BaseViewModel KennzeichenVM
        {
            get { return _kennzeichenVM; }
            set
            {
                _kennzeichenVM = value;
                OnPropertyChanged();
            }
        }


        public PatinfoViewModel()
        {
            //AnschriftVM = new AnschriftViewModel();
            NameVM = new NameViewModel("Mehmet","Demirayak","Demirayak",new DateTime(1997,5,15),"männlich");
            //VipVM = new VipViewModel();
            KennzeichenVM = new KennzeichenViewModel();
         
        }
    }
}
