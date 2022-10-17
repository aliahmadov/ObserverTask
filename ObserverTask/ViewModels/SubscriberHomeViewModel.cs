using ObserverTask.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.ViewModels
{
    public class SubscriberHomeViewModel:BaseViewModel
    {
        public RelayCommand RegisterCommand { get; set; }

        public RelayCommand SignInCommand { get; set; }


        public SubscriberHomeViewModel()
        {

        }
    }
}
