using LettingApiLib.Helper;
using LettingApiLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Office = Microsoft.Office.Core;
using System.Threading.Tasks;

namespace ExcelClient
{
    partial class APCManageHomes : UserControl
    {
        private APIHelper _apiHelper;
        public House[] Houses { get; set; }
        public Landlord[] Landlords { get; set; }
        public RenewAgreement[] RenewAgreement { get; set; }
        public DatePayment[] DatePayments { get; set; }
        public List<House> HousesSource { get; set; }
        public APCManageHomes()
        {
            InitializeComponent();
            _apiHelper = new APIHelper();
        }

        private async void buttonLoadHomes_Click(object sender, EventArgs e)
        {
            
            Houses = await _apiHelper.GetHouses();
            Globals.Homes.houseBindingSource.DataSource = Houses;
            Landlords = await _apiHelper.GetLandlords();
            Globals.Landlords.landlordBindingSource.DataSource = Landlords;
            Globals.Homes.Activate();
            GetRenewAgreement();
            GetDatePayment();
        }

        private async void buttonLoadLandlords_Click(object sender, EventArgs e)
        {
            Landlords = await _apiHelper.GetLandlords();
            Globals.Landlords.landlordBindingSource.DataSource = Landlords;
            Globals.Landlords.Activate();
        }
        private void GetRenewAgreement()
        {
            RenewAgreement = Houses.Where(h => h.DateTo <= DateTime.Now)
                .Select(
                rh =>
                new RenewAgreement
                { 
                    Tenant = rh.Tenant1,
                    Address =  rh.Address1 + " " + rh.Address4,
                    DateFrom = rh.DateFrom,
                    DateTo = rh.DateTo,
                    Email = rh.Email,
                    Mobile = rh.Mobile,
                    Rent = rh.Rent
                
                }).ToArray() ;
            Globals.RenewAgreementSheet.renewAgreementBindingSource.DataSource = RenewAgreement;

        }
        private async void GetDatePayment()
        {

            DatePayments = await Task.FromResult(Houses.OrderBy(h => h.DateFrom.Day)
                  .Select(dp =>
                  new DatePayment
                  {
                      Day = dp.DateFrom.Day,
                      Address1 = dp.Address1 + " " + dp.Address4,
                      DateFrom = dp.DateFrom,
                      Rent = dp.Rent,
                      LandlordName = Landlords.SingleOrDefault(l => l.Id == dp.LandlordId).Name
                  }).ToArray());
          
            Globals.DatePaymentSheet.datePaymentBindingSource.DataSource = DatePayments;
        }
    }
}
