using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiLeaseManagement.Forms;


namespace MultiLeaseManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int counter = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (counter < 3)

            {

                if ((txtUsername.Text == "") || (txtPassword.Text == ""))
                {
                    MessageBox.Show("The field is Empty", "Attention", MessageBoxButtons.OK);
                    counter++;
                }
                else
                {
                    try
                    {
                        var context = new LeasingModel();

                        var user = context.Users.Single(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

                        if (user == null)
                        {
                            counter++;
                            MessageBox.Show("Username or Password is Incorect", "Attention", MessageBoxButtons.OK);
                        }

                        else
                        {
                            this.Hide();
                            MultiLeaseMainWindow m = new MultiLeaseMainWindow(user.Group);
                            m.Show();
                            
                        }

                    }
                    catch (Exception)
                    {
                        counter++;
                        MessageBox.Show("Username or Password is Incorect", "Attention", MessageBoxButtons.OK);
                    }

                }
            }
            else
            {
                MessageBox.Show("3 Unsuccessful Attempt ", "Attention", MessageBoxButtons.OK);
                Application.Exit();
            }


        }








    }
}
