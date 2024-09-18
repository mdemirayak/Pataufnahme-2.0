using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pataufnahme.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel 
    {

        //public BaseViewModel Content => new PatinfoViewModel();

        public BaseViewModel Content
        {
            get { return new PatinfoViewModel(); }
        }

        public MainViewModel()
        {
			
        }



    }
}
