using Avalonia.Controls;
using System.Collections.Generic;
using System;
using Myography.ViewModels;

namespace Myography.Views
{
    public partial class MainWindow : Window
    {
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