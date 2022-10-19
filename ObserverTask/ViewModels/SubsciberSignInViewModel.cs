using ObserverTask.Commands;
using ObserverTask.Helpers;
using ObserverTask.Models;
using ObserverTask.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ObserverTask.ViewModels
{
    public class SubsciberSignInViewModel : BaseViewModel
    {

        public PasswordBox PasswordBox { get; set; }

        private YoutubeSubscriber subscriber;
        public YoutubeSubscriber Subscriber
        {
            get { return subscriber; }
            set { subscriber = value; OnPropertyChanged(); }
        }

        public RelayCommand BackCommand { get; set; }

        public RelayCommand SignInCommand { get; set; }

        public SubsciberSignInViewModel()
        {
            Subscriber = new YoutubeSubscriber();
            BackPage = App.MyGrid.Children[0];
            BackCommand = new RelayCommand(c =>
            {
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(BackPage);
            });

            SignInCommand = new RelayCommand(c =>
            {
                Subscriber.Password = PasswordBox.Password;
                var subscribers = FileHelper.ReadSubscribers("subscribers").ToList();
                var youtubeSubsribers = new List<YoutubeSubscriber>();
                foreach (var item in subscribers)
                {
                    if (item is YoutubeSubscriber subs)
                        youtubeSubsribers.Add(subs);
                }
                if (youtubeSubsribers.Any(d => d.Username == Subscriber.Username && d.Password == Subscriber.Password))
                {
                    Subscriber = youtubeSubsribers.Find(d => d.Username == Subscriber.Username && d.Password == Subscriber.Password);
                    var userInfoUC = new UserInfoUC();
                    var userInfoViewModel = new UserInfoViewModel();
                    userInfoViewModel.Posts = new ObservableCollection<Post>(Subscriber.Posts);
                    userInfoUC.DataContext = userInfoViewModel;

                    App.MyGrid.Children.RemoveAt(0);
                    App.MyGrid.Children.Add(userInfoUC);

                }
                else
                {
                    MessageBox.Show("Username or password wrong");
                }

            });
        }

    }
}
