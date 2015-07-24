using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CatalogueServiceClient.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

        protected void SettingProperty<T>(ref T storage, [CallerMemberName] String propertyName = null)
        {
            OnPropertyChanging(propertyName);
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value)) 
                return false;

            if (propertyName != null)
            {
                OnPropertyChanging(propertyName);
                storage = value;
                OnPropertyChanged(propertyName);
            }
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            var eventHandler = PropertyChanging;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangingEventArgs(propertyName));
            }
        }
    }
}
