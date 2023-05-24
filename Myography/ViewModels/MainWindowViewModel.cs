using System.Collections.Generic;
using System.ComponentModel;

namespace Myography.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _selectedItem;
        public List<string> Items { get; } = new List<string> { "4:3", "5:4", "16:9", "16:10", "21:9" };
        public string SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}