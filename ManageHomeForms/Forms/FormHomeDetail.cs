using LettingApiLib.Models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ManageHomeForms.Forms
{
    public partial class FormHomeDetail : Form, INotifyPropertyChanged
    {

        private readonly Landlord[] _landlords;
        private House  _house;
        public FormHomeDetail(House house, Landlord[] landlords)
        {
            InitializeComponent();
            House = house;
            _landlords = landlords;
            houseBindingSource.DataSource = House;
            landlordBindingSource.DataSource = _landlords;
            comboBoxLandlord.DataSource = landlords;
            comboBoxLandlord.DisplayMember = "Name";
            comboBoxLandlord.ValueMember = "Id";
            comboBoxLandlord.SelectedValue = _house.LandlordId;
        }
        

   

        public House House
        {
            get { return  _house; }
            set 
            {  
                _house = value;
                NotifyPropertyChanged();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var selectedLandlord = (Landlord)comboBoxLandlord.SelectedItem;
            House.LandlordId = selectedLandlord.Id;

            DialogResult = DialogResult.Yes;
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
