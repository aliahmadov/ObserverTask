﻿using ObserverTask.Commands;
using ObserverTask.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverTask.ViewModels
{
    public class YoutuberMainViewModel : BaseViewModel
    {

        public RelayCommand AddPostCommand { get; set; }
        public RelayCommand ShowSubscribersCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public YoutuberMainViewModel()
        {
            AddPostCommand = new RelayCommand(c =>
            {
                var addPostUC = new AddPostUC();
                var addPostViewModel = new AddPostViewModel();
                addPostUC.DataContext = addPostViewModel;

                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(addPostUC);
            });

            BackPage = App.MyGrid.Children[0];
            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });
        }
    
    }
}