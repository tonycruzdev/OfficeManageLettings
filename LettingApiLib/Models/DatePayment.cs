using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LettingApiLib.Models
{
    public class DatePayment : INotifyPropertyChanged
    {
        private int _Day;
        private string _Address;
        private DateTime _DateFrom;
        private decimal _Rent;
        private string _LandlordName;

        public int Day
        {
            get { return _Day; }
            set { _Day = value; }
        }
        public string LandlordName
        {
            get => _LandlordName;
            set 
            { 
                _LandlordName = value;
                NotifyPropertyChanged();
            }
        }

        public string Address1
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime DateFrom
        {
            get
            {
                return _DateFrom;
            }
            set
            {
                _DateFrom = value;
                NotifyPropertyChanged();
            }
        }
        public decimal Rent
        {
            get
            {
                return _Rent;
            }
            set
            {
                _Rent = value;
                NotifyPropertyChanged();
            }
        }



        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
