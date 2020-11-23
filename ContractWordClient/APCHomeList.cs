using LettingApiLib.Helper;
using LettingApiLib.Models;
using ManageHomeForms.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Office = Microsoft.Office.Core;

namespace ContractWordClient
{
    partial class APCHomeList : UserControl
    {
        private APIHelper _apiHelper;
        public House[] Houses { get; set; }
        public Landlord[] Landlords { get; set; }
        public List<House> HousesSource { get; set; }
        public APCHomeList()
        {
            InitializeComponent();
            LoadData();
        }
        private async void LoadData()
        {
            _apiHelper = new APIHelper();
             Houses = await _apiHelper.GetHouses();
            Landlords = await _apiHelper.GetLandlords();
           
            houseBindingSource.DataSource = Houses;

           // HousesSource = new List<House>(Houses);
           
        }
        private DisplayContract CopyHomeAndLandlord(House home, Landlord landlord)
        {
            var ShowContract = new DisplayContract
            {
                Id = home.Id,
                Address1 = home.Address1,
                Address2 = home.Address2,
                Address3 = home.Address3,
                Address4 = home.Address4,
                Address5 = home.Address5,
                Tenant1 = home.Tenant1,
                Tenant2 = home.Tenant2,
                DateFrom = home.DateFrom,
                DateTo = home.DateTo,
                LandlordId = home.LandlordId,
                Rent = home.Rent,
                Deposit = home.Deposit,
                Mobile = home.Mobile,
                Email = home.Email,
                LandlordName = landlord.Name,
                LandlordAddress1 = landlord.Address1,
                LandlordAddress2 = landlord.Address2,
                LandlordAddress3 = landlord.Address3,
                LandlordAddress4 = landlord.Address4,
                LandlordAddress5 = landlord.Address5,
            };
            return ShowContract;
        }
        private void houseDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (houseBindingSource.Count > 0)
            {
                House home = (House)houseBindingSource.Current;
                UpdateWordDock(home);
            }
        }

        private async void editHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            House home = (House)houseBindingSource.Current;
            var formDialog = new FormHomeDetail(home, Landlords);
            if(formDialog.ShowDialog() == DialogResult.Yes)
            {
                var updateHome = formDialog.House;
                 await _apiHelper.UpdateHome(updateHome);
                UpdateWordDock(updateHome);
            }
        }
        private void UpdateWordDock(House home)
        {
            var landlord = Landlords.SingleOrDefault(l => l.Id == home.LandlordId);
            var displayContract = CopyHomeAndLandlord(home, landlord);
            Globals.ThisDocument.displayContractBindingSource.DataSource = displayContract;
        }
    }
}
