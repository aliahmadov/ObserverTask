using ObserverTask.Commands;
using ObserverTask.Helpers;
using ObserverTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ObserverTask.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {

        public PasswordBox PasswordBox { get; set; }
        public RelayCommand BackCommand { get; set; }

        public RelayCommand RegisterCommand { get; set; }

        private YoutubeSubscriber youtubeSubscriber;

        public YoutubeSubscriber Subscriber
        {
            get { return youtubeSubscriber; }
            set { youtubeSubscriber = value; OnPropertyChanged(); }
        }



        public RegisterViewModel()
        {
            Subscriber = new YoutubeSubscriber();
            BackPage = App.MyGrid.Children[0];
            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });

            RegisterCommand = new RelayCommand(c =>
            {
                Subscriber.Password = PasswordBox.Password;
                App.Youtuber.Subscribers.Add(Subscriber);
                FileHelper.WriteSubscribers(App.Youtuber.Subscribers,"subscribers");

                MessageBox.Show($"You have successfully registered, {Subscriber.Username}");
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });
        }
    }
}
