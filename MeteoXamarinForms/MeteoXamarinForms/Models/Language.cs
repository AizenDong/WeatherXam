using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.CommunityToolkit.Helpers;

namespace MeteoXamarinForms.Models
{
    public class Language : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private LocalizedString _name;

        public LocalizedString Name
        {
                get { return _name; }
                set { _name = value; OnPropertyChanged("Name"); }
        }

        public string CI { get; set; }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
