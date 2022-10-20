using ObserverTask.Commands;
using ObserverTask.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.ViewModels
{
    public class UserInfoViewModel:BaseViewModel
    {
        public ObservableCollection<Post> Posts { get; set; }

        public RelayCommand BackCommand { get; set; }
        public UserInfoViewModel()
        {
            BackPage = App.MyGrid.Children[0];

            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });
        }



    }
}
