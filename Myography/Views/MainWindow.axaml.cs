using Avalonia.Controls;
using System.Collections.Generic;
using System;
using Myography.ViewModels;

namespace Myography.Views
{
    public partial class MainWindow : Window
    {
        public List<string> Test3 { get; set; } = new List<string>(new string[] { "4:3", "5:4", "16:9", "16:10", "21:9" });
        //public List<string> Tests { get; set; } = new List<string>(new string[] { "4:3", "5:4", "16:9" });
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();

            Button openButton = this.FindControl<Button>("OpenButton");
            openButton.Click += (sender, e) => OpenButton_Click();
        }
        private void OpenButton_Click()
        {
            ComboBox resolutionBox = this.FindControl<ComboBox>("ResolutionBox");
            string? resolution = resolutionBox.SelectedItem as string;

            TextBox distanceBox = this.FindControl<TextBox>("DistanceBox");
            double distance = Convert.ToDouble(distanceBox.Text);

            ChessWindow fullscreenWindow = new ChessWindow(resolution, distance);
            fullscreenWindow.WindowState = WindowState.FullScreen; // Открыть окно на весь экран
            fullscreenWindow.Show();
        }
    }
}