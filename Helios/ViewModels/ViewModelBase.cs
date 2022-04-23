using System;
using System.ComponentModel;

namespace Helios.ViewModels
{
	public class ViewModelBase : INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
