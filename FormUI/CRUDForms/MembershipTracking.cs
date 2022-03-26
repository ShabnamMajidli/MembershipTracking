using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Core.DependencyResolvers.Ninject;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormUI.CRUDForms
{
    public partial class MembershipTracking : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IPriceService _priceService;
        public MembershipTracking()
        {
            InitializeComponent();
            this._customerService = InstanceFactory
                .GetInstance<ICustomerService>(new BusinessModule());
            this._priceService = InstanceFactory
                .GetInstance<IPriceService>(new BusinessModule());
        }
        private void LoadCustomer()
        {
            this.dgwCustomers.DataSource = this._customerService.GetAll();
        }
        private void LoadPrices()
        {
            this.cmbPrice.DataSource = this._priceService.GetAll();
            this.cmbPrice.DisplayMember = "Type";
            this.cmbPrice.ValueMember = "Id";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this._customerService.Add(new Customer
            {
                Name = this.tbxName.Text,
                Surname = this.tbxSurname.Text,
                PriceId = (int)this.cmbPrice.SelectedValue
            });
            LoadCustomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this._customerService.Update(new Customer
            {
                Id = (int)this.dgwCustomers.CurrentRow?.Cells["Id"].Value,
                Name = this.tbxName.Text,
                Surname = this.tbxSurname.Text,
                PriceId = (int)this.cmbPrice.SelectedValue
            });
            LoadCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this._customerService.Delete(new Customer
            {
                Id = (int)this.dgwCustomers.CurrentRow?.Cells["Id"].Value

            });
            LoadCustomer();
        }

        private void MembershipTracking_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadPrices();

        }

        private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tbxName.Text =
               this.dgwCustomers.CurrentRow?.Cells["Name"].Value.ToString();
            this.tbxSurname.Text =
               this.dgwCustomers.CurrentRow?.Cells["Surname"].Value.ToString();
            this.cmbPrice.SelectedValue =
              this.dgwCustomers.CurrentRow?.Cells["PriceId"].Value;

        }
    }
}
