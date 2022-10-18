using ObserverTask.Helpers;
using ObserverTask.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ObserverTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Grid MyGrid;

        public static Youtuber Youtuber;
        public App()
        {
            Youtuber = new Youtuber();

            if (File.Exists("subscribers.json"))
            {
                Youtuber.Subscribers=FileHelper.ReadSubscribers("subscribers").ToList();
            }
        }
    }
}
