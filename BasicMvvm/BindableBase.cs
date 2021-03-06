﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicMvvm
{
    public abstract class BindableBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
