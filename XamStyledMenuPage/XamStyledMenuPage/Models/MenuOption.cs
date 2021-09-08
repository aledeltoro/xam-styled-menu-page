using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamStyledMenuPage.Models
{
    public class MenuOption : INotifyPropertyChanged
    {
        public MenuOption(string title, string detail, string image)
        {
            Title = title;
            Image = image;
            Detail = detail;
        }

        public string Title { get; }
        public string Image { get; }
        public string Detail { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
