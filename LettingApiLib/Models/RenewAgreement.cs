using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LettingApiLib.Models
{
    public class RenewAgreement: INotifyPropertyChanged
    {
        private string _Address;
        private string _PostCode;
        private string _Tenant;
        private DateTime _DateFrom;
        private DateTime _DateTo;
        private decimal _Rent;
        private string _Mobile;
        private string _Email;

        public string Tenant
        {
            get
            {
                return _Tenant;
            }
            set
            {
                _Tenant = value;
                NotifyPropertyChanged();
            }
        }

        public string Address
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

      
        public string PostCode
        {
            get
            {
                return _PostCode;
            }
            set
            {
                _PostCode = value;
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
        public DateTime DateTo
        {
            get
            {
                return _DateTo;
            }
            set
            {
                _DateTo = value;
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

        public string Mobile
        {
            get
            {
                return _Mobile;
            }
            set
            {
                _Mobile = value;
                NotifyPropertyChanged();
            }
        }
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                if (value != this._Email)
                {
                    _Email = value;
                    NotifyPropertyChanged();
                }

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
