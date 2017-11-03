using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiLeaseManagement.Forms
{

    public partial class MultiLeaseMainWindow : Form
    {


        public MultiLeaseMainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var context = new LeasingModel();
            var customer = new Customer
            {
                First_Name = txtCustomerFirstname.Text,
                Last_Name = txtCustomerLastname.Text,
                Address = txtCustomerAddress.Text,
                City = txtCustomerCity.Text,
                Province = txtCustomerProvince.Text,
                Postal_Code = txtCustomerPostalCode.Text,
                Phone_Number = txtCustomerPhoneNumber.Text,
            };
            context.Customers.Add(customer);
            context.SaveChanges();

            MessageBox.Show("Customer Successfuly Inserted ", "Insert", MessageBoxButtons.OK);
            txtCustomerFirstname.Text = "";
            txtCustomerLastname.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerProvince.Text = "";
            txtCustomerPostalCode.Text = "";
            txtCustomerPhoneNumber.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var context = new LeasingModel();
            
            try
            {
               var customer = context.Customers.Single(c => (c.Phone_Number == txtCustomerPhoneNumberSearch.Text && c.Active !=false));
                btnCustomerInsert.Enabled = false;
                btnCustomerUpdate.Enabled = true;
                btnCustomerDelete.Enabled = true;
                lblCustomerId.Text = customer.Customer_ID.ToString();
                txtCustomerFirstname.Text = customer.First_Name;
                txtCustomerLastname.Text = customer.Last_Name;
                txtCustomerAddress.Text = customer.Address;
                txtCustomerCity.Text = customer.City;
                txtCustomerProvince.Text = customer.Province;
                txtCustomerPostalCode.Text = customer.Postal_Code;
                txtCustomerPhoneNumber.Text = customer.Phone_Number;
            }
            catch (Exception)
            {
                MessageBox.Show("This Customer Does Not Exist !!! ", "Not Found ", MessageBoxButtons.OK);
            }

           
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            var context = new LeasingModel();
            int customerId = Convert.ToInt32(lblCustomerId.Text);
            var customer = context.Customers.Single(c => c.Customer_ID == customerId);

            //customer.Customer_ID = Convert.ToInt32(lblCustomerId.Text);
            customer.First_Name = txtCustomerFirstname.Text;
            customer.Last_Name = txtCustomerLastname.Text;
            customer.Address = txtCustomerAddress.Text;
            customer.City = txtCustomerCity.Text;
            customer.Province = txtCustomerProvince.Text;
            customer.Postal_Code = txtCustomerPostalCode.Text;
            customer.Phone_Number = txtCustomerPhoneNumber.Text;

            context.SaveChanges();

            MessageBox.Show("Customer Successfuly Updated ", "Update", MessageBoxButtons.OK);
            txtCustomerFirstname.Text = "";
            txtCustomerLastname.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerProvince.Text = "";
            txtCustomerPostalCode.Text = "";
            txtCustomerPhoneNumber.Text = "";
            btnCustomerInsert.Enabled = true;
            btnCustomerUpdate.Enabled = false;
            btnCustomerDelete.Enabled = false;



        }

        private void MultiLeaseMainWindow_Load(object sender, EventArgs e)
        {
            //var context = new LeasingModel();
            btnCustomerDelete.Enabled = false;
            btnCustomerUpdate.Enabled = false;


        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            var context = new LeasingModel();
            int CustomerId = Convert.ToInt32(lblCustomerId.Text);
            try
            {
                var customer = context.Customers.Single(c => c.Customer_ID == CustomerId);
                customer.Active = false;
                context.SaveChanges();
                MessageBox.Show("The Customer Is Deleted ... ","Delete",MessageBoxButtons.OK);
                txtCustomerFirstname.Text = "";
                txtCustomerLastname.Text = "";
                txtCustomerAddress.Text = "";
                txtCustomerCity.Text = "";
                txtCustomerProvince.Text = "";
                txtCustomerPostalCode.Text = "";
                txtCustomerPhoneNumber.Text = "";
                btnCustomerInsert.Enabled = true;
                btnCustomerUpdate.Enabled = false;
                btnCustomerDelete.Enabled = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Something Goes Wrong !!! ", "Delete", MessageBoxButtons.OK);

            }
        }
    }
}
