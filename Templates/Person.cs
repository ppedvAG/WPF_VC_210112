using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Templates
{
    public class Person : INotifyPropertyChanged
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        private int alter;
        public int Alter
        {
            get { return alter; }
            set 
            { 
                alter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));
            }
        }

        public List<DateTime> Adressen { get; set; } = new List<DateTime>()
        {
            new DateTime(2003, 12, 3)
        };

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
