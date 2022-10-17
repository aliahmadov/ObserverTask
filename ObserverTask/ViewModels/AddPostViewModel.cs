using Microsoft.Win32;
using ObserverTask.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ObserverTask.ViewModels
{
    public class AddPostViewModel : BaseViewModel
    {
        public RelayCommand ChooseImageCommand { get; set; }

        public RelayCommand BackCommand { get; set; }

        private string selectedImagePath;

        public string SelectedImagePath
        {
            get { return selectedImagePath; }
            set { selectedImagePath = value; OnPropertyChanged(); }
        }


        public AddPostViewModel()
        {
            ChooseImageCommand = new RelayCommand(c =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == true)
                {
                    var file = openFileDialog.FileName;
                    if (file.EndsWith(".jpg") || file.EndsWith(".png"))
                    {
                        SelectedImagePath = file;
                    }
                    else
                    {
                        MessageBox.Show("Picture in wrong format - .jpg or .png", "Info",System.Windows.MessageBoxButton.OK,MessageBoxImage.Information);
                    }

                }
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
