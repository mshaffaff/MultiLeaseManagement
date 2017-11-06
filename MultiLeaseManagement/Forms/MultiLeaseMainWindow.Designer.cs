namespace MultiLeaseManagement.Forms
{
    partial class MultiLeaseMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Customers = new System.Windows.Forms.TabPage();
            this.txtCustomerPhoneNumberSearch = new System.Windows.Forms.MaskedTextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerInsert = new System.Windows.Forms.Button();
            this.txtCustomerPostalCode = new System.Windows.Forms.TextBox();
            this.txtCustomerProvince = new System.Windows.Forms.TextBox();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerLastname = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Vehicles = new System.Windows.Forms.TabPage();
            this.txtVehicleId = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbVehicleTypeSearch = new System.Windows.Forms.ComboBox();
            this.cmbVehicleModelSearch = new System.Windows.Forms.ComboBox();
            this.chkbVehicleBeforeLeased = new System.Windows.Forms.CheckBox();
            this.cmbVehicleColor = new System.Windows.Forms.ComboBox();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.cmbVehicleModel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkbHasPowerLock = new System.Windows.Forms.CheckBox();
            this.chkbVehicleAutoTransmission = new System.Windows.Forms.CheckBox();
            this.chkbHasAirCondition = new System.Windows.Forms.CheckBox();
            this.btnVehicleSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVehicleDelete = new System.Windows.Forms.Button();
            this.btnVehicleUpdate = new System.Windows.Forms.Button();
            this.btnVehicleInsert = new System.Windows.Forms.Button();
            this.txtVehicleValue = new System.Windows.Forms.TextBox();
            this.txtVehicleKM = new System.Windows.Forms.TextBox();
            this.txtVehicleYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Leaseing = new System.Windows.Forms.TabPage();
            this.txtLeaseVehicleId = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnLeaseVehicleSearch = new System.Windows.Forms.Button();
            this.btnLeaseCustomerSearch = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLeaseMonthlyPaymentNumber = new System.Windows.Forms.TextBox();
            this.txtLeaseMonthlyPatmentAmount = new System.Windows.Forms.TextBox();
            this.txtLeasePremium = new System.Windows.Forms.TextBox();
            this.dtLeaseFirstPayment = new System.Windows.Forms.DateTimePicker();
            this.dtLeaseDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLeaseMileage = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnLeaseDelete = new System.Windows.Forms.Button();
            this.cmbLeaseYears = new System.Windows.Forms.ComboBox();
            this.btnLeaseInsert = new System.Windows.Forms.Button();
            this.btnLeaseUpdate = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.TabPage();
            this.btnPaymentInsert = new System.Windows.Forms.Button();
            this.txtPaymentLeaseId = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.dtPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtPaymentLeaseIdSearch = new System.Windows.Forms.TextBox();
            this.btnPaymentLeaseIdSearch = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.txtLeaseCustomerPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblLeaseCutomerId = new System.Windows.Forms.Label();
            this.lblLeaseTermId = new System.Windows.Forms.Label();
            this.btnLeaseLeaseIdSearch = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.txtLeaseLeaseIdSearch = new System.Windows.Forms.TextBox();
            this.lblLeaseId = new System.Windows.Forms.Label();
            this.btnLeaseCancelSearch = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Customers.SuspendLayout();
            this.Vehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Leaseing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(878, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Customers);
            this.tabControl1.Controls.Add(this.Vehicles);
            this.tabControl1.Controls.Add(this.Leaseing);
            this.tabControl1.Controls.Add(this.Payment);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 729);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.txtCustomerPhoneNumberSearch);
            this.Customers.Controls.Add(this.lblCustomerId);
            this.Customers.Controls.Add(this.txtCustomerPhoneNumber);
            this.Customers.Controls.Add(this.button4);
            this.Customers.Controls.Add(this.label8);
            this.Customers.Controls.Add(this.btnCustomerDelete);
            this.Customers.Controls.Add(this.btnCustomerUpdate);
            this.Customers.Controls.Add(this.btnCustomerInsert);
            this.Customers.Controls.Add(this.txtCustomerPostalCode);
            this.Customers.Controls.Add(this.txtCustomerProvince);
            this.Customers.Controls.Add(this.txtCustomerCity);
            this.Customers.Controls.Add(this.txtCustomerAddress);
            this.Customers.Controls.Add(this.txtCustomerLastname);
            this.Customers.Controls.Add(this.txtCustomerFirstname);
            this.Customers.Controls.Add(this.label7);
            this.Customers.Controls.Add(this.label6);
            this.Customers.Controls.Add(this.label5);
            this.Customers.Controls.Add(this.label4);
            this.Customers.Controls.Add(this.label3);
            this.Customers.Controls.Add(this.label2);
            this.Customers.Controls.Add(this.label1);
            this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customers.Location = new System.Drawing.Point(4, 29);
            this.Customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customers.Size = new System.Drawing.Size(865, 696);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers Page";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // txtCustomerPhoneNumberSearch
            // 
            this.txtCustomerPhoneNumberSearch.Location = new System.Drawing.Point(212, 359);
            this.txtCustomerPhoneNumberSearch.Mask = "(999) 000-0000";
            this.txtCustomerPhoneNumberSearch.Name = "txtCustomerPhoneNumberSearch";
            this.txtCustomerPhoneNumberSearch.Size = new System.Drawing.Size(214, 27);
            this.txtCustomerPhoneNumberSearch.TabIndex = 57;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(691, 32);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerId.TabIndex = 56;
            this.lblCustomerId.Visible = false;
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(212, 271);
            this.txtCustomerPhoneNumber.Mask = "(999) 000-0000";
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(324, 27);
            this.txtCustomerPhoneNumber.TabIndex = 55;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 357);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 34);
            this.button4.TabIndex = 19;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Search By Phone";
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(432, 310);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(104, 34);
            this.btnCustomerDelete.TabIndex = 16;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(323, 310);
            this.btnCustomerUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(104, 34);
            this.btnCustomerUpdate.TabIndex = 15;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerInsert
            // 
            this.btnCustomerInsert.Location = new System.Drawing.Point(212, 310);
            this.btnCustomerInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomerInsert.Name = "btnCustomerInsert";
            this.btnCustomerInsert.Size = new System.Drawing.Size(104, 34);
            this.btnCustomerInsert.TabIndex = 14;
            this.btnCustomerInsert.Text = "Insert";
            this.btnCustomerInsert.UseVisualStyleBackColor = true;
            this.btnCustomerInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerPostalCode
            // 
            this.txtCustomerPostalCode.Location = new System.Drawing.Point(212, 231);
            this.txtCustomerPostalCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerPostalCode.Name = "txtCustomerPostalCode";
            this.txtCustomerPostalCode.Size = new System.Drawing.Size(324, 27);
            this.txtCustomerPostalCode.TabIndex = 12;
            // 
            // txtCustomerProvince
            // 
            this.txtCustomerProvince.Location = new System.Drawing.Point(212, 192);
            this.txtCustomerProvince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerProvince.Name = "txtCustomerProvince";
            this.txtCustomerProvince.Size = new System.Drawing.Size(324, 27);
            this.txtCustomerProvince.TabIndex = 11;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(212, 153);
            this.txtCustomerCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(324, 27);
            this.txtCustomerCity.TabIndex = 10;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(212, 112);
            this.txtCustomerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(324, 27);
            this.txtCustomerAddress.TabIndex = 9;
            // 
            // txtCustomerLastname
            // 
            this.txtCustomerLastname.Location = new System.Drawing.Point(212, 71);
            this.txtCustomerLastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerLastname.Name = "txtCustomerLastname";
            this.txtCustomerLastname.Size = new System.Drawing.Size(324, 27);
            this.txtCustomerLastname.TabIndex = 8;
            // 
            // txtCustomerFirstname
            // 
            this.txtCustomerFirstname.Location = new System.Drawing.Point(212, 32);
            this.txtCustomerFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerFirstname.Name = "txtCustomerFirstname";
            this.txtCustomerFirstname.Size = new System.Drawing.Size(324, 27);
            this.txtCustomerFirstname.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "PostalCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Province";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // Vehicles
            // 
            this.Vehicles.Controls.Add(this.txtVehicleId);
            this.Vehicles.Controls.Add(this.label27);
            this.Vehicles.Controls.Add(this.dataGridView1);
            this.Vehicles.Controls.Add(this.label17);
            this.Vehicles.Controls.Add(this.label11);
            this.Vehicles.Controls.Add(this.cmbVehicleTypeSearch);
            this.Vehicles.Controls.Add(this.cmbVehicleModelSearch);
            this.Vehicles.Controls.Add(this.chkbVehicleBeforeLeased);
            this.Vehicles.Controls.Add(this.cmbVehicleColor);
            this.Vehicles.Controls.Add(this.cmbVehicleType);
            this.Vehicles.Controls.Add(this.cmbVehicleModel);
            this.Vehicles.Controls.Add(this.groupBox1);
            this.Vehicles.Controls.Add(this.btnVehicleSearch);
            this.Vehicles.Controls.Add(this.label9);
            this.Vehicles.Controls.Add(this.btnVehicleDelete);
            this.Vehicles.Controls.Add(this.btnVehicleUpdate);
            this.Vehicles.Controls.Add(this.btnVehicleInsert);
            this.Vehicles.Controls.Add(this.txtVehicleValue);
            this.Vehicles.Controls.Add(this.txtVehicleKM);
            this.Vehicles.Controls.Add(this.txtVehicleYear);
            this.Vehicles.Controls.Add(this.label10);
            this.Vehicles.Controls.Add(this.label12);
            this.Vehicles.Controls.Add(this.label13);
            this.Vehicles.Controls.Add(this.label14);
            this.Vehicles.Controls.Add(this.label15);
            this.Vehicles.Controls.Add(this.label16);
            this.Vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehicles.Location = new System.Drawing.Point(4, 29);
            this.Vehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vehicles.Size = new System.Drawing.Size(865, 696);
            this.Vehicles.TabIndex = 1;
            this.Vehicles.Text = "Vehicles Page";
            this.Vehicles.UseVisualStyleBackColor = true;
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Location = new System.Drawing.Point(209, 27);
            this.txtVehicleId.Mask = "aaaaa-aaaaa-aaaaa-aaaaa";
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.Size = new System.Drawing.Size(324, 27);
            this.txtVehicleId.TabIndex = 56;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(41, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 20);
            this.label27.TabIndex = 52;
            this.label27.Text = "Vehicle Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 524);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(855, 110);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 442);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 50;
            this.label17.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Model";
            // 
            // cmbVehicleTypeSearch
            // 
            this.cmbVehicleTypeSearch.FormattingEnabled = true;
            this.cmbVehicleTypeSearch.Location = new System.Drawing.Point(209, 431);
            this.cmbVehicleTypeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVehicleTypeSearch.Name = "cmbVehicleTypeSearch";
            this.cmbVehicleTypeSearch.Size = new System.Drawing.Size(324, 28);
            this.cmbVehicleTypeSearch.TabIndex = 48;
            // 
            // cmbVehicleModelSearch
            // 
            this.cmbVehicleModelSearch.FormattingEnabled = true;
            this.cmbVehicleModelSearch.Location = new System.Drawing.Point(209, 389);
            this.cmbVehicleModelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVehicleModelSearch.Name = "cmbVehicleModelSearch";
            this.cmbVehicleModelSearch.Size = new System.Drawing.Size(324, 28);
            this.cmbVehicleModelSearch.TabIndex = 47;
            // 
            // chkbVehicleBeforeLeased
            // 
            this.chkbVehicleBeforeLeased.AutoSize = true;
            this.chkbVehicleBeforeLeased.Location = new System.Drawing.Point(604, 226);
            this.chkbVehicleBeforeLeased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbVehicleBeforeLeased.Name = "chkbVehicleBeforeLeased";
            this.chkbVehicleBeforeLeased.Size = new System.Drawing.Size(154, 24);
            this.chkbVehicleBeforeLeased.TabIndex = 46;
            this.chkbVehicleBeforeLeased.Text = "Leased Before";
            this.chkbVehicleBeforeLeased.UseVisualStyleBackColor = true;
            // 
            // cmbVehicleColor
            // 
            this.cmbVehicleColor.FormattingEnabled = true;
            this.cmbVehicleColor.Location = new System.Drawing.Point(209, 146);
            this.cmbVehicleColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVehicleColor.Name = "cmbVehicleColor";
            this.cmbVehicleColor.Size = new System.Drawing.Size(324, 28);
            this.cmbVehicleColor.TabIndex = 45;
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Location = new System.Drawing.Point(209, 106);
            this.cmbVehicleType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(324, 28);
            this.cmbVehicleType.TabIndex = 44;
            // 
            // cmbVehicleModel
            // 
            this.cmbVehicleModel.FormattingEnabled = true;
            this.cmbVehicleModel.Location = new System.Drawing.Point(209, 66);
            this.cmbVehicleModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVehicleModel.Name = "cmbVehicleModel";
            this.cmbVehicleModel.Size = new System.Drawing.Size(324, 28);
            this.cmbVehicleModel.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkbHasPowerLock);
            this.groupBox1.Controls.Add(this.chkbVehicleAutoTransmission);
            this.groupBox1.Controls.Add(this.chkbHasAirCondition);
            this.groupBox1.Location = new System.Drawing.Point(604, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(244, 133);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkbHasPowerLock
            // 
            this.chkbHasPowerLock.AutoSize = true;
            this.chkbHasPowerLock.Location = new System.Drawing.Point(21, 93);
            this.chkbHasPowerLock.Name = "chkbHasPowerLock";
            this.chkbHasPowerLock.Size = new System.Drawing.Size(129, 24);
            this.chkbHasPowerLock.TabIndex = 59;
            this.chkbHasPowerLock.Text = "Power Lock";
            this.chkbHasPowerLock.UseVisualStyleBackColor = true;
            // 
            // chkbVehicleAutoTransmission
            // 
            this.chkbVehicleAutoTransmission.AutoSize = true;
            this.chkbVehicleAutoTransmission.Location = new System.Drawing.Point(20, 33);
            this.chkbVehicleAutoTransmission.Name = "chkbVehicleAutoTransmission";
            this.chkbVehicleAutoTransmission.Size = new System.Drawing.Size(188, 24);
            this.chkbVehicleAutoTransmission.TabIndex = 57;
            this.chkbVehicleAutoTransmission.Text = "Auto Transmission";
            this.chkbVehicleAutoTransmission.UseVisualStyleBackColor = true;
            // 
            // chkbHasAirCondition
            // 
            this.chkbHasAirCondition.AutoSize = true;
            this.chkbHasAirCondition.Location = new System.Drawing.Point(20, 63);
            this.chkbHasAirCondition.Name = "chkbHasAirCondition";
            this.chkbHasAirCondition.Size = new System.Drawing.Size(140, 24);
            this.chkbHasAirCondition.TabIndex = 58;
            this.chkbHasAirCondition.Text = "Air Condition";
            this.chkbHasAirCondition.UseVisualStyleBackColor = true;
            // 
            // btnVehicleSearch
            // 
            this.btnVehicleSearch.Location = new System.Drawing.Point(209, 473);
            this.btnVehicleSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVehicleSearch.Name = "btnVehicleSearch";
            this.btnVehicleSearch.Size = new System.Drawing.Size(324, 34);
            this.btnVehicleSearch.TabIndex = 39;
            this.btnVehicleSearch.Text = "Search";
            this.btnVehicleSearch.UseVisualStyleBackColor = true;
            this.btnVehicleSearch.Click += new System.EventHandler(this.btnVehicleSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = ".: Search By Model and Type :.";
            // 
            // btnVehicleDelete
            // 
            this.btnVehicleDelete.Enabled = false;
            this.btnVehicleDelete.Location = new System.Drawing.Point(429, 310);
            this.btnVehicleDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVehicleDelete.Name = "btnVehicleDelete";
            this.btnVehicleDelete.Size = new System.Drawing.Size(104, 34);
            this.btnVehicleDelete.TabIndex = 36;
            this.btnVehicleDelete.Text = "Delete";
            this.btnVehicleDelete.UseVisualStyleBackColor = true;
            // 
            // btnVehicleUpdate
            // 
            this.btnVehicleUpdate.Enabled = false;
            this.btnVehicleUpdate.Location = new System.Drawing.Point(319, 310);
            this.btnVehicleUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVehicleUpdate.Name = "btnVehicleUpdate";
            this.btnVehicleUpdate.Size = new System.Drawing.Size(104, 34);
            this.btnVehicleUpdate.TabIndex = 35;
            this.btnVehicleUpdate.Text = "Update";
            this.btnVehicleUpdate.UseVisualStyleBackColor = true;
            // 
            // btnVehicleInsert
            // 
            this.btnVehicleInsert.Enabled = false;
            this.btnVehicleInsert.Location = new System.Drawing.Point(209, 310);
            this.btnVehicleInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVehicleInsert.Name = "btnVehicleInsert";
            this.btnVehicleInsert.Size = new System.Drawing.Size(104, 34);
            this.btnVehicleInsert.TabIndex = 34;
            this.btnVehicleInsert.Text = "Insert";
            this.btnVehicleInsert.UseVisualStyleBackColor = true;
            this.btnVehicleInsert.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtVehicleValue
            // 
            this.txtVehicleValue.Location = new System.Drawing.Point(209, 260);
            this.txtVehicleValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVehicleValue.Name = "txtVehicleValue";
            this.txtVehicleValue.Size = new System.Drawing.Size(324, 27);
            this.txtVehicleValue.TabIndex = 33;
            // 
            // txtVehicleKM
            // 
            this.txtVehicleKM.Location = new System.Drawing.Point(209, 223);
            this.txtVehicleKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVehicleKM.Name = "txtVehicleKM";
            this.txtVehicleKM.Size = new System.Drawing.Size(324, 27);
            this.txtVehicleKM.TabIndex = 31;
            // 
            // txtVehicleYear
            // 
            this.txtVehicleYear.Location = new System.Drawing.Point(209, 186);
            this.txtVehicleYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVehicleYear.Name = "txtVehicleYear";
            this.txtVehicleYear.Size = new System.Drawing.Size(324, 27);
            this.txtVehicleYear.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Current Value";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "KM Traveled";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Year";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Color";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Model";
            // 
            // Leaseing
            // 
            this.Leaseing.Controls.Add(this.btnLeaseCancelSearch);
            this.Leaseing.Controls.Add(this.lblLeaseId);
            this.Leaseing.Controls.Add(this.txtLeaseLeaseIdSearch);
            this.Leaseing.Controls.Add(this.btnLeaseLeaseIdSearch);
            this.Leaseing.Controls.Add(this.label32);
            this.Leaseing.Controls.Add(this.lblLeaseTermId);
            this.Leaseing.Controls.Add(this.lblLeaseCutomerId);
            this.Leaseing.Controls.Add(this.txtLeaseCustomerPhoneNumber);
            this.Leaseing.Controls.Add(this.txtLeaseVehicleId);
            this.Leaseing.Controls.Add(this.dataGridView2);
            this.Leaseing.Controls.Add(this.btnLeaseVehicleSearch);
            this.Leaseing.Controls.Add(this.btnLeaseCustomerSearch);
            this.Leaseing.Controls.Add(this.label21);
            this.Leaseing.Controls.Add(this.groupBox2);
            this.Leaseing.Controls.Add(this.btnLeaseDelete);
            this.Leaseing.Controls.Add(this.cmbLeaseYears);
            this.Leaseing.Controls.Add(this.btnLeaseInsert);
            this.Leaseing.Controls.Add(this.btnLeaseUpdate);
            this.Leaseing.Controls.Add(this.label25);
            this.Leaseing.Controls.Add(this.label26);
            this.Leaseing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leaseing.Location = new System.Drawing.Point(4, 29);
            this.Leaseing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Leaseing.Name = "Leaseing";
            this.Leaseing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Leaseing.Size = new System.Drawing.Size(865, 696);
            this.Leaseing.TabIndex = 2;
            this.Leaseing.Text = "Leasing Page";
            this.Leaseing.UseVisualStyleBackColor = true;
            // 
            // txtLeaseVehicleId
            // 
            this.txtLeaseVehicleId.Location = new System.Drawing.Point(319, 18);
            this.txtLeaseVehicleId.Mask = "aaaaa-aaaaa-aaaaa-aaaaa";
            this.txtLeaseVehicleId.Name = "txtLeaseVehicleId";
            this.txtLeaseVehicleId.Size = new System.Drawing.Size(324, 27);
            this.txtLeaseVehicleId.TabIndex = 80;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 571);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(855, 119);
            this.dataGridView2.TabIndex = 79;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnLeaseVehicleSearch
            // 
            this.btnLeaseVehicleSearch.Location = new System.Drawing.Point(649, 14);
            this.btnLeaseVehicleSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaseVehicleSearch.Name = "btnLeaseVehicleSearch";
            this.btnLeaseVehicleSearch.Size = new System.Drawing.Size(104, 34);
            this.btnLeaseVehicleSearch.TabIndex = 78;
            this.btnLeaseVehicleSearch.Text = "Search";
            this.btnLeaseVehicleSearch.UseVisualStyleBackColor = true;
            this.btnLeaseVehicleSearch.Click += new System.EventHandler(this.btnLeaseVehicleSearch_Click);
            // 
            // btnLeaseCustomerSearch
            // 
            this.btnLeaseCustomerSearch.Location = new System.Drawing.Point(649, 58);
            this.btnLeaseCustomerSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaseCustomerSearch.Name = "btnLeaseCustomerSearch";
            this.btnLeaseCustomerSearch.Size = new System.Drawing.Size(104, 32);
            this.btnLeaseCustomerSearch.TabIndex = 77;
            this.btnLeaseCustomerSearch.Text = "Search";
            this.btnLeaseCustomerSearch.UseVisualStyleBackColor = true;
            this.btnLeaseCustomerSearch.Click += new System.EventHandler(this.btnLeaseCustomerSearch_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label21.Location = new System.Drawing.Point(41, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(140, 20);
            this.label21.TabIndex = 73;
            this.label21.Text = "Number of Year";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLeaseMonthlyPaymentNumber);
            this.groupBox2.Controls.Add(this.txtLeaseMonthlyPatmentAmount);
            this.groupBox2.Controls.Add(this.txtLeasePremium);
            this.groupBox2.Controls.Add(this.dtLeaseFirstPayment);
            this.groupBox2.Controls.Add(this.dtLeaseDate);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtLeaseMileage);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(40, 151);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(623, 325);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lease Term";
            // 
            // txtLeaseMonthlyPaymentNumber
            // 
            this.txtLeaseMonthlyPaymentNumber.Location = new System.Drawing.Point(273, 277);
            this.txtLeaseMonthlyPaymentNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLeaseMonthlyPaymentNumber.Name = "txtLeaseMonthlyPaymentNumber";
            this.txtLeaseMonthlyPaymentNumber.Size = new System.Drawing.Size(324, 27);
            this.txtLeaseMonthlyPaymentNumber.TabIndex = 78;
            // 
            // txtLeaseMonthlyPatmentAmount
            // 
            this.txtLeaseMonthlyPatmentAmount.Location = new System.Drawing.Point(273, 229);
            this.txtLeaseMonthlyPatmentAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLeaseMonthlyPatmentAmount.Name = "txtLeaseMonthlyPatmentAmount";
            this.txtLeaseMonthlyPatmentAmount.Size = new System.Drawing.Size(324, 27);
            this.txtLeaseMonthlyPatmentAmount.TabIndex = 77;
            // 
            // txtLeasePremium
            // 
            this.txtLeasePremium.Enabled = false;
            this.txtLeasePremium.Location = new System.Drawing.Point(273, 181);
            this.txtLeasePremium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLeasePremium.Name = "txtLeasePremium";
            this.txtLeasePremium.Size = new System.Drawing.Size(324, 27);
            this.txtLeasePremium.TabIndex = 76;
            // 
            // dtLeaseFirstPayment
            // 
            this.dtLeaseFirstPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLeaseFirstPayment.Location = new System.Drawing.Point(273, 86);
            this.dtLeaseFirstPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtLeaseFirstPayment.Name = "dtLeaseFirstPayment";
            this.dtLeaseFirstPayment.Size = new System.Drawing.Size(324, 27);
            this.dtLeaseFirstPayment.TabIndex = 75;
            // 
            // dtLeaseDate
            // 
            this.dtLeaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLeaseDate.Location = new System.Drawing.Point(273, 37);
            this.dtLeaseDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtLeaseDate.Name = "dtLeaseDate";
            this.dtLeaseDate.Size = new System.Drawing.Size(324, 27);
            this.dtLeaseDate.TabIndex = 74;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label20.Location = new System.Drawing.Point(5, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 20);
            this.label20.TabIndex = 62;
            this.label20.Text = "Premium";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label19.Location = new System.Drawing.Point(5, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 20);
            this.label19.TabIndex = 61;
            this.label19.Text = "Max. Mileage";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 20);
            this.label18.TabIndex = 60;
            this.label18.Text = "Contract Date";
            // 
            // txtLeaseMileage
            // 
            this.txtLeaseMileage.Enabled = false;
            this.txtLeaseMileage.Location = new System.Drawing.Point(273, 133);
            this.txtLeaseMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLeaseMileage.Name = "txtLeaseMileage";
            this.txtLeaseMileage.Size = new System.Drawing.Size(324, 27);
            this.txtLeaseMileage.TabIndex = 58;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(172, 20);
            this.label24.TabIndex = 53;
            this.label24.Text = "First Payment Date";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 231);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(221, 20);
            this.label23.TabIndex = 54;
            this.label23.Text = "Monthly Payment Amount";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 281);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(223, 20);
            this.label22.TabIndex = 55;
            this.label22.Text = "Monthly Payment Number";
            // 
            // btnLeaseDelete
            // 
            this.btnLeaseDelete.Location = new System.Drawing.Point(533, 481);
            this.btnLeaseDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaseDelete.Name = "btnLeaseDelete";
            this.btnLeaseDelete.Size = new System.Drawing.Size(104, 34);
            this.btnLeaseDelete.TabIndex = 62;
            this.btnLeaseDelete.Text = "Delete";
            this.btnLeaseDelete.UseVisualStyleBackColor = true;
            this.btnLeaseDelete.Click += new System.EventHandler(this.btnLeaseDelete_Click);
            // 
            // cmbLeaseYears
            // 
            this.cmbLeaseYears.FormattingEnabled = true;
            this.cmbLeaseYears.Location = new System.Drawing.Point(319, 103);
            this.cmbLeaseYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLeaseYears.Name = "cmbLeaseYears";
            this.cmbLeaseYears.Size = new System.Drawing.Size(324, 28);
            this.cmbLeaseYears.TabIndex = 67;
            this.cmbLeaseYears.SelectedIndexChanged += new System.EventHandler(this.cmbLeaseYears_SelectedIndexChanged);
            this.cmbLeaseYears.TabIndexChanged += new System.EventHandler(this.cmbLeaseYears_TabIndexChanged);
            // 
            // btnLeaseInsert
            // 
            this.btnLeaseInsert.Location = new System.Drawing.Point(313, 481);
            this.btnLeaseInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaseInsert.Name = "btnLeaseInsert";
            this.btnLeaseInsert.Size = new System.Drawing.Size(104, 34);
            this.btnLeaseInsert.TabIndex = 60;
            this.btnLeaseInsert.Text = "Insert";
            this.btnLeaseInsert.UseVisualStyleBackColor = true;
            this.btnLeaseInsert.Click += new System.EventHandler(this.btnLeaseInsert_Click);
            // 
            // btnLeaseUpdate
            // 
            this.btnLeaseUpdate.Location = new System.Drawing.Point(424, 481);
            this.btnLeaseUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaseUpdate.Name = "btnLeaseUpdate";
            this.btnLeaseUpdate.Size = new System.Drawing.Size(104, 34);
            this.btnLeaseUpdate.TabIndex = 61;
            this.btnLeaseUpdate.Text = "Update";
            this.btnLeaseUpdate.UseVisualStyleBackColor = true;
            this.btnLeaseUpdate.Click += new System.EventHandler(this.btnLeaseUpdate_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 20);
            this.label25.TabIndex = 52;
            this.label25.Text = "Customer Phone";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(41, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 20);
            this.label26.TabIndex = 51;
            this.label26.Text = "Vehicle Id";
            // 
            // Payment
            // 
            this.Payment.Controls.Add(this.dataGridView3);
            this.Payment.Controls.Add(this.btnPaymentInsert);
            this.Payment.Controls.Add(this.txtPaymentLeaseId);
            this.Payment.Controls.Add(this.label31);
            this.Payment.Controls.Add(this.txtPaymentAmount);
            this.Payment.Controls.Add(this.dtPaymentDate);
            this.Payment.Controls.Add(this.label29);
            this.Payment.Controls.Add(this.label30);
            this.Payment.Controls.Add(this.txtPaymentLeaseIdSearch);
            this.Payment.Controls.Add(this.btnPaymentLeaseIdSearch);
            this.Payment.Controls.Add(this.label28);
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(4, 29);
            this.Payment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(865, 696);
            this.Payment.TabIndex = 3;
            this.Payment.Text = "Payments Page";
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // btnPaymentInsert
            // 
            this.btnPaymentInsert.Location = new System.Drawing.Point(167, 267);
            this.btnPaymentInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaymentInsert.Name = "btnPaymentInsert";
            this.btnPaymentInsert.Size = new System.Drawing.Size(324, 34);
            this.btnPaymentInsert.TabIndex = 90;
            this.btnPaymentInsert.Text = "Insert";
            this.btnPaymentInsert.UseVisualStyleBackColor = true;
            // 
            // txtPaymentLeaseId
            // 
            this.txtPaymentLeaseId.Location = new System.Drawing.Point(167, 131);
            this.txtPaymentLeaseId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentLeaseId.Name = "txtPaymentLeaseId";
            this.txtPaymentLeaseId.Size = new System.Drawing.Size(324, 27);
            this.txtPaymentLeaseId.TabIndex = 89;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(34, 134);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(81, 20);
            this.label31.TabIndex = 88;
            this.label31.Text = "Lease Id";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(167, 227);
            this.txtPaymentAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(324, 27);
            this.txtPaymentAmount.TabIndex = 87;
            // 
            // dtPaymentDate
            // 
            this.dtPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPaymentDate.Location = new System.Drawing.Point(167, 180);
            this.dtPaymentDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPaymentDate.Name = "dtPaymentDate";
            this.dtPaymentDate.Size = new System.Drawing.Size(324, 27);
            this.dtPaymentDate.TabIndex = 86;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(34, 227);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 20);
            this.label29.TabIndex = 85;
            this.label29.Text = "Amount";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(34, 180);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 20);
            this.label30.TabIndex = 84;
            this.label30.Text = "Date";
            // 
            // txtPaymentLeaseIdSearch
            // 
            this.txtPaymentLeaseIdSearch.Location = new System.Drawing.Point(167, 21);
            this.txtPaymentLeaseIdSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentLeaseIdSearch.Name = "txtPaymentLeaseIdSearch";
            this.txtPaymentLeaseIdSearch.Size = new System.Drawing.Size(324, 27);
            this.txtPaymentLeaseIdSearch.TabIndex = 83;
            // 
            // btnPaymentLeaseIdSearch
            // 
            this.btnPaymentLeaseIdSearch.Location = new System.Drawing.Point(497, 17);
            this.btnPaymentLeaseIdSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaymentLeaseIdSearch.Name = "btnPaymentLeaseIdSearch";
            this.btnPaymentLeaseIdSearch.Size = new System.Drawing.Size(104, 34);
            this.btnPaymentLeaseIdSearch.TabIndex = 82;
            this.btnPaymentLeaseIdSearch.Text = "Search";
            this.btnPaymentLeaseIdSearch.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(34, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(81, 20);
            this.label28.TabIndex = 81;
            this.label28.Text = "Lease Id";
            // 
            // txtLeaseCustomerPhoneNumber
            // 
            this.txtLeaseCustomerPhoneNumber.Location = new System.Drawing.Point(319, 61);
            this.txtLeaseCustomerPhoneNumber.Mask = "(999) 000-0000";
            this.txtLeaseCustomerPhoneNumber.Name = "txtLeaseCustomerPhoneNumber";
            this.txtLeaseCustomerPhoneNumber.Size = new System.Drawing.Size(324, 27);
            this.txtLeaseCustomerPhoneNumber.TabIndex = 81;
            // 
            // lblLeaseCutomerId
            // 
            this.lblLeaseCutomerId.AutoSize = true;
            this.lblLeaseCutomerId.Location = new System.Drawing.Point(760, 62);
            this.lblLeaseCutomerId.Name = "lblLeaseCutomerId";
            this.lblLeaseCutomerId.Size = new System.Drawing.Size(0, 20);
            this.lblLeaseCutomerId.TabIndex = 82;
            this.lblLeaseCutomerId.Visible = false;
            // 
            // lblLeaseTermId
            // 
            this.lblLeaseTermId.AutoSize = true;
            this.lblLeaseTermId.Location = new System.Drawing.Point(650, 113);
            this.lblLeaseTermId.Name = "lblLeaseTermId";
            this.lblLeaseTermId.Size = new System.Drawing.Size(0, 20);
            this.lblLeaseTermId.TabIndex = 83;
            this.lblLeaseTermId.Visible = false;
            // 
            // btnLeaseLeaseIdSearch
            // 
            this.btnLeaseLeaseIdSearch.Location = new System.Drawing.Point(533, 519);
            this.btnLeaseLeaseIdSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaseLeaseIdSearch.Name = "btnLeaseLeaseIdSearch";
            this.btnLeaseLeaseIdSearch.Size = new System.Drawing.Size(104, 34);
            this.btnLeaseLeaseIdSearch.TabIndex = 85;
            this.btnLeaseLeaseIdSearch.Text = "Search";
            this.btnLeaseLeaseIdSearch.UseVisualStyleBackColor = true;
            this.btnLeaseLeaseIdSearch.Click += new System.EventHandler(this.btnLeaseLeaseIdSearch_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(45, 524);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(231, 20);
            this.label32.TabIndex = 84;
            this.label32.Text = "Search Lease By Lease Id";
            // 
            // txtLeaseLeaseIdSearch
            // 
            this.txtLeaseLeaseIdSearch.Location = new System.Drawing.Point(313, 523);
            this.txtLeaseLeaseIdSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLeaseLeaseIdSearch.Name = "txtLeaseLeaseIdSearch";
            this.txtLeaseLeaseIdSearch.Size = new System.Drawing.Size(214, 27);
            this.txtLeaseLeaseIdSearch.TabIndex = 86;
            // 
            // lblLeaseId
            // 
            this.lblLeaseId.AutoSize = true;
            this.lblLeaseId.Location = new System.Drawing.Point(650, 519);
            this.lblLeaseId.Name = "lblLeaseId";
            this.lblLeaseId.Size = new System.Drawing.Size(0, 20);
            this.lblLeaseId.TabIndex = 87;
            this.lblLeaseId.Visible = false;
            // 
            // btnLeaseCancelSearch
            // 
            this.btnLeaseCancelSearch.Location = new System.Drawing.Point(643, 519);
            this.btnLeaseCancelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeaseCancelSearch.Name = "btnLeaseCancelSearch";
            this.btnLeaseCancelSearch.Size = new System.Drawing.Size(104, 34);
            this.btnLeaseCancelSearch.TabIndex = 88;
            this.btnLeaseCancelSearch.Text = "Cancel";
            this.btnLeaseCancelSearch.UseVisualStyleBackColor = true;
            this.btnLeaseCancelSearch.Click += new System.EventHandler(this.btnLeaseCancelSearch_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(4, 361);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(855, 260);
            this.dataGridView3.TabIndex = 91;
            // 
            // MultiLeaseMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 771);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MultiLeaseMainWindow";
            this.Text = "MultiLeaseMainWindow";
            this.Load += new System.EventHandler(this.MultiLeaseMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            this.Vehicles.ResumeLayout(false);
            this.Vehicles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Leaseing.ResumeLayout(false);
            this.Leaseing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Payment.ResumeLayout(false);
            this.Payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Button btnCustomerInsert;
        private System.Windows.Forms.TextBox txtCustomerPostalCode;
        private System.Windows.Forms.TextBox txtCustomerProvince;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerLastname;
        private System.Windows.Forms.TextBox txtCustomerFirstname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Vehicles;
        private System.Windows.Forms.TabPage Leaseing;
        private System.Windows.Forms.TabPage Payment;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbVehicleTypeSearch;
        private System.Windows.Forms.ComboBox cmbVehicleModelSearch;
        private System.Windows.Forms.CheckBox chkbVehicleBeforeLeased;
        private System.Windows.Forms.ComboBox cmbVehicleColor;
        private System.Windows.Forms.ComboBox cmbVehicleType;
        private System.Windows.Forms.ComboBox cmbVehicleModel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVehicleSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnVehicleDelete;
        private System.Windows.Forms.Button btnVehicleUpdate;
        private System.Windows.Forms.Button btnVehicleInsert;
        private System.Windows.Forms.TextBox txtVehicleValue;
        private System.Windows.Forms.TextBox txtVehicleKM;
        private System.Windows.Forms.TextBox txtVehicleYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLeaseYears;
        private System.Windows.Forms.Button btnLeaseDelete;
        private System.Windows.Forms.Button btnLeaseUpdate;
        private System.Windows.Forms.Button btnLeaseInsert;
        private System.Windows.Forms.TextBox txtLeaseMileage;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLeaseMonthlyPaymentNumber;
        private System.Windows.Forms.TextBox txtLeaseMonthlyPatmentAmount;
        private System.Windows.Forms.TextBox txtLeasePremium;
        private System.Windows.Forms.DateTimePicker dtLeaseFirstPayment;
        private System.Windows.Forms.DateTimePicker dtLeaseDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnLeaseVehicleSearch;
        private System.Windows.Forms.Button btnLeaseCustomerSearch;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtPaymentLeaseIdSearch;
        private System.Windows.Forms.Button btnPaymentLeaseIdSearch;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtPaymentLeaseId;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.DateTimePicker dtPaymentDate;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.MaskedTextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.MaskedTextBox txtVehicleId;
        private System.Windows.Forms.Button btnPaymentInsert;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.MaskedTextBox txtCustomerPhoneNumberSearch;
        private System.Windows.Forms.CheckBox chkbHasPowerLock;
        private System.Windows.Forms.CheckBox chkbVehicleAutoTransmission;
        private System.Windows.Forms.CheckBox chkbHasAirCondition;
        private System.Windows.Forms.MaskedTextBox txtLeaseVehicleId;
        private System.Windows.Forms.MaskedTextBox txtLeaseCustomerPhoneNumber;
        private System.Windows.Forms.Label lblLeaseCutomerId;
        private System.Windows.Forms.Label lblLeaseTermId;
        private System.Windows.Forms.TextBox txtLeaseLeaseIdSearch;
        private System.Windows.Forms.Button btnLeaseLeaseIdSearch;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblLeaseId;
        private System.Windows.Forms.Button btnLeaseCancelSearch;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}