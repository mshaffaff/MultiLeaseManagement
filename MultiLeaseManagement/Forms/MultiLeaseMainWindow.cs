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
                Active = true
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
                var customer = context.Customers.Single(c => (c.Phone_Number == txtCustomerPhoneNumberSearch.Text && c.Active != false));
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
                MessageBox.Show("The Customer Is Deleted ... ", "Delete", MessageBoxButtons.OK);
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

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            cmbVehicleModel.Items.Clear();
            cmbVehicleColor.Items.Clear();
            cmbVehicleType.Items.Clear();
            cmbVehicleModelSearch.Items.Clear();
            cmbVehicleTypeSearch.Items.Clear();
            if (e.TabPageIndex == 1)
            {
                var context = new LeasingModel();
                //List<Model> models = new List<Model>();
                //List<Type> types = new List<Type>();
                //List<Color> colors = new List<Color>();
                foreach (var model in context.Models)
                {
                    cmbVehicleModel.Items.Add(model.Model1);
                    cmbVehicleModelSearch.Items.Add(model.Model1);

                }
                foreach (var type in context.V_Type)
                {
                    cmbVehicleType.Items.Add(type.Type);
                    cmbVehicleTypeSearch.Items.Add(type.Type);

                }
                foreach (var color in context.Colors)
                {
                    cmbVehicleColor.Items.Add(color.Color1);

                }



            }

            if (e.TabPageIndex == 2)
            {
                btnLeaseUpdate.Enabled = false;
                btnLeaseDelete.Enabled = false;
                btnLeaseInsert.Enabled = true;
                txtLeaseVehicleId.Enabled = true;
                txtLeaseCustomerPhoneNumber.Enabled = true;
                btnLeaseVehicleSearch.Enabled = true;
                btnLeaseCustomerSearch.Enabled = true;
                btnLeaseInsert.Enabled = true;



            }



        }

        private void btnVehicleSearch_Click(object sender, EventArgs e)
        {
            var context = new LeasingModel();
            var vehicles = context.Vehicles
                .Where(v => (v.Model.Model1 == cmbVehicleModelSearch.SelectedItem.ToString() && v.V_Type.Type == cmbVehicleTypeSearch.SelectedItem.ToString()))
                .Select(v => new { VehicleId = v.Vehicle_VIN, VehicleModel = v.Model.Model1, Year = v.Year, CurrentValue = v.Current_Vehicle_Val }).ToList();


            if (vehicles == null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            else
                dataGridView1.DataSource = vehicles;






        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void btnLeaseVehicleSearch_Click(object sender, EventArgs e)
        {
            var context = new LeasingModel();

            var vehicles = context.Vehicles
                    .Where(v => (v.Vehicle_VIN == txtLeaseVehicleId.Text) && (v.LeasedBefor == false))
                    .Select(v => new { VehicleId = v.Vehicle_VIN, VehicleModel = v.Model.Model1, Year = v.Year, CurrentValue = v.Current_Vehicle_Val }).ToList();

            if (vehicles.Count == 0)
            {
                MessageBox.Show("The Vehicle was not Found or it Leased before", "Error", MessageBoxButtons.OK);
                txtLeaseVehicleId.Text = "";
            }
            else
                dataGridView2.DataSource = vehicles;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new LeasingModel();
            if (e.RowIndex == -1)
            {
                MessageBox.Show("Please Select the Exact Info ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string myValue = dataGridView1[0, e.RowIndex].Value.ToString();
                var vehicle = context.Vehicles.Find(myValue);
                txtVehicleId.Text = vehicle.Vehicle_VIN;
                cmbVehicleModel.SelectedItem = vehicle.Model.Model1;
                cmbVehicleType.SelectedItem = vehicle.V_Type.Type;
                cmbVehicleColor.SelectedItem = vehicle.Color.Color1;
                txtVehicleYear.Text = vehicle.Year.ToString();
                txtVehicleKM.Text = vehicle.Kilometres_Travelled.ToString();
                txtVehicleValue.Text = vehicle.Current_Vehicle_Val.ToString();
                if (vehicle.LeasedBefor == true)
                    chkbVehicleBeforeLeased.Checked = true;
                else
                    chkbVehicleBeforeLeased.Checked = false;

                if (vehicle.HasAirCondition == true)
                    chkbHasAirCondition.Checked = true;
                else
                    chkbHasAirCondition.Checked = false;

                if (vehicle.HasPowerLock == true)
                    chkbHasPowerLock.Checked = true;
                else
                    chkbHasPowerLock.Checked = false;

                if (vehicle.AutoTransmission == true)
                    chkbVehicleAutoTransmission.Checked = true;
                else
                    chkbVehicleAutoTransmission.Checked = false;
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLeaseCustomerSearch_Click(object sender, EventArgs e)
        {
            var context = new LeasingModel();

            var Customer = context.Customers
                    .Where(c => c.Phone_Number == txtLeaseCustomerPhoneNumber.Text && c.Active != false)
                    .Select(c => new { CustomerID = c.Customer_ID, FirstName = c.First_Name, LastName = c.Last_Name, PstalCode = c.Postal_Code }).ToList();

            if (Customer == null)
            {
                MessageBox.Show("The Customer Not Found", "Error", MessageBoxButtons.OK);
                txtLeaseVehicleId.Text = "";
            }
            else
                dataGridView2.DataSource = Customer;

            foreach (var lease in context.Lease_Terms)
            {
                cmbLeaseYears.Items.Add(lease.Number_of_Years);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var context = new LeasingModel();

            if (e.RowIndex == -1)
            {
                MessageBox.Show("Please Select the Exact Info ", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string CellSelector = dataGridView2.Columns[0].HeaderText;
                if (CellSelector == "VehicleId")
                {
                    string myValue = dataGridView2[0, e.RowIndex].Value.ToString();
                    var vehicle = context.Vehicles.Find(myValue);
                    if (vehicle.LeasedBefor == true)
                        MessageBox.Show("This car was Leased Before and It can not be leased again!!!", "Error", MessageBoxButtons.OK);
                    else
                    {
                        MessageBox.Show("The car is Selected Please Select The Customer... ", "Vehicke Confirmed", MessageBoxButtons.OK);
                        txtVehicleId.Text = vehicle.Vehicle_VIN;
                        dataGridView2.DataSource = null;
                    }

                }
                else if (CellSelector == "CustomerID")
                {
                    string myValue = dataGridView2[0, e.RowIndex].Value.ToString();
                    var customer = context.Customers.Find(Convert.ToInt32(myValue));
                    lblLeaseCutomerId.Text = myValue;

                    MessageBox.Show("The Customer is Selected Please Choose The Terms ... ", "Customer Confirmed", MessageBoxButtons.OK);
                    txtLeaseCustomerPhoneNumber.Text = customer.Phone_Number;
                    dataGridView2.DataSource = null;

                }

            }

        }

        private void cmbLeaseYears_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLeaseYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            var context = new LeasingModel();
            int NumberOfYear = Convert.ToInt32(cmbLeaseYears.SelectedItem);
            var LeaseTerm = context.Lease_Terms.Single(lt => lt.Number_of_Years == NumberOfYear);

            txtLeaseMileage.Text = LeaseTerm.Max_Kilometres.ToString();
            txtLeasePremium.Text = LeaseTerm.Extra_Mileage_Cost.ToString();
            lblLeaseTermId.Text = LeaseTerm.Lease_Terms_ID.ToString();



        }

        private void btnLeaseInsert_Click(object sender, EventArgs e)
        {

            if (Convert.ToDateTime(dtLeaseFirstPayment.Text) <= Convert.ToDateTime(dtLeaseDate.Text))
                MessageBox.Show("The First Payment Should be After Contract Date ", "Error", MessageBoxButtons.OK);
            else
            {
                var context = new LeasingModel();
                var Lease = new Leas
                {
                    Vehicle_VIN = txtLeaseVehicleId.Text,
                    Customer_ID = Convert.ToInt32(lblLeaseCutomerId.Text),
                    Lease_Terms_ID = Convert.ToInt32(lblLeaseTermId.Text),
                    Date_Lease_Begins = dtLeaseDate.Value,
                    First_Payment_Date = dtLeaseFirstPayment.Value,
                    Monthly_Payment_Amount = Convert.ToInt32(txtLeaseMonthlyPatmentAmount.Text),
                    Monthly_Payment_Number = Convert.ToInt32(txtLeaseMonthlyPaymentNumber.Text),

                };

                var vehicle = context.Vehicles.Find(txtLeaseVehicleId.Text);
                vehicle.LeasedBefor = true;
                context.Leases.Add(Lease);
                context.SaveChanges();
                MessageBox.Show("The Lease is Successfuly Inserted ", "Attention", MessageBoxButtons.OK);
                txtLeaseVehicleId.Text = "";
                txtLeaseCustomerPhoneNumber.Text = "";
                cmbLeaseYears.Items.Clear();
                cmbLeaseYears.Text = "";
                txtLeaseMileage.Text = "";
                txtLeasePremium.Text = "";
                txtLeaseMonthlyPatmentAmount.Text = "";
                txtLeaseMonthlyPaymentNumber.Text = "";




            }





        }

        private void btnLeaseLeaseIdSearch_Click(object sender, EventArgs e)
        {

            txtLeaseVehicleId.Text = "";
            txtLeaseCustomerPhoneNumber.Text = "";
            cmbLeaseYears.Items.Clear();
            cmbLeaseYears.Text = "";
            txtLeaseMileage.Text = "";
            txtLeasePremium.Text = "";
            txtLeaseMonthlyPatmentAmount.Text = "";
            txtLeaseMonthlyPaymentNumber.Text = "";
            dataGridView2.DataSource = null;
            btnLeaseDelete.Enabled = false;
            btnLeaseUpdate.Enabled = false;



            var context = new LeasingModel();

            try
            {
               

                int leaseId = Convert.ToInt32(txtLeaseLeaseIdSearch.Text);
                var lease = context.Leases.Single(l => ((l.LeaseID == leaseId) && (l.Active!=false)));

                if (lease != null)
                {
                    txtLeaseVehicleId.Enabled = false;
                    txtLeaseCustomerPhoneNumber.Enabled = false;
                    btnLeaseVehicleSearch.Enabled = false;
                    btnLeaseCustomerSearch.Enabled = false;
                    btnLeaseInsert.Enabled = false;
                    btnLeaseDelete.Enabled = true;
                    btnLeaseUpdate.Enabled = true;

                }

                lblLeaseId.Text = lease.LeaseID.ToString();
                txtLeaseVehicleId.Text = lease.Vehicle_VIN;
                txtLeaseCustomerPhoneNumber.Text = lease.Customer.Phone_Number;

                var Customer = context.Customers
                    .Where(c => c.Phone_Number == txtLeaseCustomerPhoneNumber.Text && c.Active != false)
                    .Select(c => new { CustomerID = c.Customer_ID, FirstName = c.First_Name, LastName = c.Last_Name, PstalCode = c.Postal_Code }).ToList();
                foreach (var c in Customer)
                {
                    lblLeaseCutomerId.Text = c.CustomerID.ToString();
                }


                dataGridView2.DataSource = Customer;

                foreach (var leaseTerm in context.Lease_Terms)
                {
                    cmbLeaseYears.Items.Add(leaseTerm.Number_of_Years);
                }
                cmbLeaseYears.SelectedItem = lease.Lease_Terms.Number_of_Years;

                dtLeaseDate.Value = lease.Date_Lease_Begins;
                dtLeaseFirstPayment.Value = lease.First_Payment_Date;
                txtLeaseMileage.Text = lease.Lease_Terms.Max_Kilometres.ToString();
                txtLeasePremium.Text = lease.Lease_Terms.Extra_Mileage_Cost.ToString();
                txtLeaseMonthlyPatmentAmount.Text = lease.Monthly_Payment_Amount.ToString();
                txtLeaseMonthlyPaymentNumber.Text = lease.Monthly_Payment_Number.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("This Lease Contract was not Found ", "Error", MessageBoxButtons.OK);
            }




        }

        private void btnLeaseUpdate_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtLeaseFirstPayment.Text) <= Convert.ToDateTime(dtLeaseDate.Text))
                MessageBox.Show("The First Payment Should be After Contract Date ", "Error", MessageBoxButtons.OK);
            else
            {
                var context = new LeasingModel();
                var lease = context.Leases.Find(Convert.ToInt32(lblLeaseId.Text));

                lease.Vehicle_VIN = txtLeaseVehicleId.Text;
                lease.Customer_ID = Convert.ToInt32(lblLeaseCutomerId.Text);
                lease.Lease_Terms_ID = Convert.ToInt32(lblLeaseTermId.Text);
                lease.Date_Lease_Begins = dtLeaseDate.Value;
                lease.First_Payment_Date = dtLeaseFirstPayment.Value;
                lease.Monthly_Payment_Amount = Convert.ToDecimal(txtLeaseMonthlyPatmentAmount.Text);
                lease.Monthly_Payment_Number = Convert.ToInt32(txtLeaseMonthlyPaymentNumber.Text);

                context.SaveChanges();
                MessageBox.Show("The Lease is Successfuly Updated ", "Attention", MessageBoxButtons.OK);
                txtLeaseVehicleId.Text = "";
                txtLeaseCustomerPhoneNumber.Text = "";
                cmbLeaseYears.Items.Clear();
                cmbLeaseYears.Text = "";
                txtLeaseMileage.Text = "";
                txtLeasePremium.Text = "";
                txtLeaseMonthlyPatmentAmount.Text = "";
                txtLeaseMonthlyPaymentNumber.Text = "";
                txtLeaseLeaseIdSearch.Text = "";
                dataGridView2.DataSource = null;


            }




        }

        private void btnLeaseDelete_Click(object sender, EventArgs e)
        {
            var context = new LeasingModel();
            var lease = context.Leases.Find(Convert.ToInt32(txtLeaseLeaseIdSearch.Text));

            DialogResult dl = MessageBox.Show("Are you Sure to Delete this Lease ?", "Attention", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                lease.Active = false;
                context.SaveChanges();
                MessageBox.Show("The Lease was Successfuly Deleted ", "Attention", MessageBoxButtons.OK);
                txtLeaseVehicleId.Text = "";
                txtLeaseCustomerPhoneNumber.Text = "";
                cmbLeaseYears.Items.Clear();
                cmbLeaseYears.Text = "";
                txtLeaseMileage.Text = "";
                txtLeasePremium.Text = "";
                txtLeaseMonthlyPatmentAmount.Text = "";
                txtLeaseMonthlyPaymentNumber.Text = "";
                txtLeaseLeaseIdSearch.Text = "";
                dataGridView2.DataSource = null;
            }

            
            
            
        }

        private void btnLeaseCancelSearch_Click(object sender, EventArgs e)
        {
            txtLeaseVehicleId.Text = "";
            txtLeaseCustomerPhoneNumber.Text = "";
            cmbLeaseYears.Items.Clear();
            cmbLeaseYears.Text = "";
            txtLeaseMileage.Text = "";
            txtLeasePremium.Text = "";
            txtLeaseMonthlyPatmentAmount.Text = "";
            txtLeaseMonthlyPaymentNumber.Text = "";
            txtLeaseLeaseIdSearch.Text = "";
            dataGridView2.DataSource = null;
            btnLeaseInsert.Enabled = true;
            btnLeaseDelete.Enabled = false;
            btnLeaseUpdate.Enabled = false;
            txtLeaseVehicleId.Enabled = true;
            txtLeaseCustomerPhoneNumber.Enabled = true;
            btnLeaseVehicleSearch.Enabled = true;
            btnLeaseCustomerSearch.Enabled = true;
        }
    }
}
