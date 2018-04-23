using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_App8.Models
{
    public class Address : INotifyPropertyChanged
    {
        private string _Street;
        public string Street
        {
            get { return _Street; }
            set { if (_Street != value)
                {
                    _Street = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Street"));
                }
            }
        }
        private string _City;
        public string City
        {
            get { return _City; }
            set
            {
                if (_City !=value)
                {
                    _City = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("City"));
                }
                    
            }

        }
        private string _State;
        public string State
        {
            get { return _State; }
            set
            {
                if (_State != value)
                {
                    _State = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("State"));
                }
            }
        }
        private string _Zip;
        public string Zip
        { 
            get { return _Zip; }
            set
            {
                if (_Zip != value)
                {
                    _Zip = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Zip"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
