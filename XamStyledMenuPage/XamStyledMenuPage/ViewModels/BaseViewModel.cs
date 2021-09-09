using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamStyledMenuPage.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
