using ObserverTask.Commands;
using ObserverTask.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.ViewModels
{
    public class HomeViewModel
    {

        public RelayCommand YoutuberCommand { get; set; }

        public RelayCommand SubscriberCommand { get; set; }


        public HomeViewModel()
        {
            YoutuberCommand = new RelayCommand(c =>
            {
                var youtuberMainUC = new YoutuberMainViewUC();
                var youtuberMainViewModel=new YoutuberMainViewModel();
                youtuberMainUC.DataContext=youtuberMainViewModel;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(youtuberMainUC);

            });
        }
    }
}
