﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace LettingApiLib.Models
{
    public class House : INotifyPropertyChanged
    {
        private int _Id;
        private string _Address1;
        private string _Address2;
        private string _Address3;
        private string _Address4;
        private string _Address5;
        private string _Tenant1;
        private string _Tenant2;
        private DateTime _DateFrom;
        private DateTime _DateTo;
        private int _LandlordId;
        private decimal _Rent;
        private decimal _Deposit;
        private string _Mobile;
        private string _Email;
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
        public string Address1
        {
            get
            {
                return _Address1;
            }
            set
            {
                _Address1 = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
        public string Address2
        {
            get
            {
                return _Address2;
            }
            set
            {
                _Address2 = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
        public string Address3
        {
            get
            {
                return _Address3;
            }
            set
            {
                _Address3 = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
        public string Address4
        {
            get
            {
                return _Address4;
            }
            set
            {
                _Address4 = value;
                NotifyPropertyChanged();
            }
        }
        public string Address5
        {
            get
            {
                return _Address5;
            }
            set
            {
                _Address5 = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
        public string Tenant1
        {
            get
            {
                return _Tenant1;
            }
            set
            {
                _Tenant1 = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
        public string Tenant2
        {
            get
            {
                return _Tenant2;
            }
            set
            {
                _Tenant2 = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
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
        [Required]
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
        public int LandlordId
        {
            get
            {
                return _LandlordId;
            }
            set
            {
                _LandlordId = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
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
        [Required]
        public decimal Deposit
        {
            get
            {
                return _Deposit;
            }
            set
            {
                _Deposit = value;
                NotifyPropertyChanged();
            }
        }
        [Required]
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
        [Required]
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
