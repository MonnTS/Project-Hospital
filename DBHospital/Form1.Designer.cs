namespace DBHospital
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fKQualificationStaffStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKStaffHospitalNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet = new DBHospital.ProjectDBDataSet();
            this.fKFurnitureHospitalNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKMedicalResourcesHospitalNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKEquipmentHospitalNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospital_namesTableAdapter = new DBHospital.ProjectDBDataSetTableAdapters.Hospital_namesTableAdapter();
            this.equipmentTableAdapter = new DBHospital.ProjectDBDataSetTableAdapters.EquipmentTableAdapter();
            this.furnitureTableAdapter = new DBHospital.ProjectDBDataSetTableAdapters.FurnitureTableAdapter();
            this.medical_resourcesTableAdapter = new DBHospital.ProjectDBDataSetTableAdapters.Medical_resourcesTableAdapter();
            this.staffTableAdapter = new DBHospital.ProjectDBDataSetTableAdapters.StaffTableAdapter();
            this.qualification_staffTableAdapter = new DBHospital.ProjectDBDataSetTableAdapters.Qualification_staffTableAdapter();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchEquipment = new System.Windows.Forms.Button();
            this.SearchStaff = new System.Windows.Forms.Button();
            this.idEquip = new System.Windows.Forms.TextBox();
            this.idStaff = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDstaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDeqDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journalEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.iDeqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDREQDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDpropert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.IDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDREQDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.IDnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDREQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDproper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.equipmentTableAdapter1 = new DBHospital.ProjectDBDataSetTableAdapters.EquipmentTableAdapter();
            this.journalEquipmentTableAdapter = new DBHospital.ProjectDBDataSetTableAdapters.JournalEquipmentTableAdapter();
            this.qualificationStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDREQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDREQDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fKQualificationStaffStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStaffHospitalNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFurnitureHospitalNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMedicalResourcesHospitalNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEquipmentHospitalNamesBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalEquipmentBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fKQualificationStaffStaffBindingSource
            // 
            this.fKQualificationStaffStaffBindingSource.DataMember = "FK_Qualification staff_Staff";
            this.fKQualificationStaffStaffBindingSource.DataSource = this.fKStaffHospitalNamesBindingSource;
            // 
            // fKStaffHospitalNamesBindingSource
            // 
            this.fKStaffHospitalNamesBindingSource.DataMember = "FK_Staff_Hospital names";
            this.fKStaffHospitalNamesBindingSource.DataSource = this.hospitalNamesBindingSource;
            // 
            // hospitalNamesBindingSource
            // 
            this.hospitalNamesBindingSource.DataMember = "Hospital names";
            this.hospitalNamesBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.projectDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKFurnitureHospitalNamesBindingSource
            // 
            this.fKFurnitureHospitalNamesBindingSource.DataMember = "FK_Furniture_Hospital names";
            this.fKFurnitureHospitalNamesBindingSource.DataSource = this.hospitalNamesBindingSource;
            // 
            // fKMedicalResourcesHospitalNamesBindingSource
            // 
            this.fKMedicalResourcesHospitalNamesBindingSource.DataMember = "FK_Medical resources_Hospital names";
            this.fKMedicalResourcesHospitalNamesBindingSource.DataSource = this.hospitalNamesBindingSource;
            // 
            // fKEquipmentHospitalNamesBindingSource
            // 
            this.fKEquipmentHospitalNamesBindingSource.DataMember = "FK_Equipment_Hospital names";
            this.fKEquipmentHospitalNamesBindingSource.DataSource = this.hospitalNamesBindingSource;
            // 
            // hospital_namesTableAdapter
            // 
            this.hospital_namesTableAdapter.ClearBeforeFill = true;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // furnitureTableAdapter
            // 
            this.furnitureTableAdapter.ClearBeforeFill = true;
            // 
            // medical_resourcesTableAdapter
            // 
            this.medical_resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // qualification_staffTableAdapter
            // 
            this.qualification_staffTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView9);
            this.tabPage5.Controls.Add(this.dataGridView8);
            this.tabPage5.Controls.Add(this.SearchEquipment);
            this.tabPage5.Controls.Add(this.SearchStaff);
            this.tabPage5.Controls.Add(this.idEquip);
            this.tabPage5.Controls.Add(this.idStaff);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.dataGridView7);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(953, 880);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Journal";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AutoGenerateColumns = false;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDREQ,
            this.nameDataGridViewTextBoxColumn5,
            this.Profession,
            this.Contact});
            this.dataGridView8.DataSource = this.staffBindingSource;
            this.dataGridView8.Location = new System.Drawing.Point(8, 468);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowHeadersWidth = 51;
            this.dataGridView8.RowTemplate.Height = 24;
            this.dataGridView8.Size = new System.Drawing.Size(848, 150);
            this.dataGridView8.TabIndex = 7;
            this.dataGridView8.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView8_CellContentClick);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.bindingSource1;
            // 
            // SearchEquipment
            // 
            this.SearchEquipment.Location = new System.Drawing.Point(145, 693);
            this.SearchEquipment.Name = "SearchEquipment";
            this.SearchEquipment.Size = new System.Drawing.Size(75, 23);
            this.SearchEquipment.TabIndex = 6;
            this.SearchEquipment.Text = "Search";
            this.SearchEquipment.UseVisualStyleBackColor = true;
            this.SearchEquipment.Click += new System.EventHandler(this.SearchEquipment_Click);
            // 
            // SearchStaff
            // 
            this.SearchStaff.Location = new System.Drawing.Point(145, 439);
            this.SearchStaff.Name = "SearchStaff";
            this.SearchStaff.Size = new System.Drawing.Size(75, 23);
            this.SearchStaff.TabIndex = 5;
            this.SearchStaff.Text = "Search";
            this.SearchStaff.UseVisualStyleBackColor = true;
            this.SearchStaff.Click += new System.EventHandler(this.SearchStaff_Click);
            // 
            // idEquip
            // 
            this.idEquip.Location = new System.Drawing.Point(8, 693);
            this.idEquip.Name = "idEquip";
            this.idEquip.Size = new System.Drawing.Size(100, 22);
            this.idEquip.TabIndex = 4;
            // 
            // idStaff
            // 
            this.idStaff.Location = new System.Drawing.Point(8, 439);
            this.idStaff.Name = "idStaff";
            this.idStaff.Size = new System.Drawing.Size(100, 22);
            this.idStaff.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 673);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "IDequipment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "IDstaff";
            // 
            // dataGridView7
            // 
            this.dataGridView7.AutoGenerateColumns = false;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDstaffDataGridViewTextBoxColumn,
            this.iDeqDataGridViewTextBoxColumn1,
            this.causeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView7.DataSource = this.journalEquipmentBindingSource;
            this.dataGridView7.Location = new System.Drawing.Point(8, 16);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.Size = new System.Drawing.Size(937, 360);
            this.dataGridView7.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDstaffDataGridViewTextBoxColumn
            // 
            this.iDstaffDataGridViewTextBoxColumn.DataPropertyName = "IDstaff";
            this.iDstaffDataGridViewTextBoxColumn.HeaderText = "IDstaff";
            this.iDstaffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDstaffDataGridViewTextBoxColumn.Name = "iDstaffDataGridViewTextBoxColumn";
            this.iDstaffDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDeqDataGridViewTextBoxColumn1
            // 
            this.iDeqDataGridViewTextBoxColumn1.DataPropertyName = "IDeq";
            this.iDeqDataGridViewTextBoxColumn1.HeaderText = "IDeq";
            this.iDeqDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDeqDataGridViewTextBoxColumn1.Name = "iDeqDataGridViewTextBoxColumn1";
            this.iDeqDataGridViewTextBoxColumn1.Width = 125;
            // 
            // causeDataGridViewTextBoxColumn
            // 
            this.causeDataGridViewTextBoxColumn.DataPropertyName = "Cause";
            this.causeDataGridViewTextBoxColumn.HeaderText = "Cause";
            this.causeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.causeDataGridViewTextBoxColumn.Name = "causeDataGridViewTextBoxColumn";
            this.causeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // journalEquipmentBindingSource
            // 
            this.journalEquipmentBindingSource.DataMember = "JournalEquipment";
            this.journalEquipmentBindingSource.DataSource = this.bindingSource1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView6);
            this.tabPage1.Controls.Add(this.dataGridView5);
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(953, 880);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(9, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "IDHosp: Center - 1, East - 2, Children\'s - 3";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Staff\'s qualification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Staff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Medical resources";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Furniture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Equipment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hospital name";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDeqDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.fKQualificationStaffStaffBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(454, 637);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(183, 167);
            this.dataGridView6.TabIndex = 5;
            this.dataGridView6.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView6_UserDeletingRow);
            // 
            // iDeqDataGridViewTextBoxColumn
            // 
            this.iDeqDataGridViewTextBoxColumn.DataPropertyName = "IDeq";
            this.iDeqDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.iDeqDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDeqDataGridViewTextBoxColumn.Name = "iDeqDataGridViewTextBoxColumn";
            this.iDeqDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.iDREQDataGridViewTextBoxColumn2,
            this.IDpropert,
            this.nameDataGridViewTextBoxColumn4,
            this.professionDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.fKStaffHospitalNamesBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(457, 464);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(485, 150);
            this.dataGridView5.TabIndex = 4;
            this.dataGridView5.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView5_UserDeletingRow);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // iDREQDataGridViewTextBoxColumn2
            // 
            this.iDREQDataGridViewTextBoxColumn2.DataPropertyName = "IDREQ";
            this.iDREQDataGridViewTextBoxColumn2.HeaderText = "IDREQ";
            this.iDREQDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDREQDataGridViewTextBoxColumn2.Name = "iDREQDataGridViewTextBoxColumn2";
            this.iDREQDataGridViewTextBoxColumn2.Width = 125;
            // 
            // IDpropert
            // 
            this.IDpropert.DataPropertyName = "IDpropert";
            this.IDpropert.HeaderText = "IDHosp";
            this.IDpropert.MinimumWidth = 6;
            this.IDpropert.Name = "IDpropert";
            this.IDpropert.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            this.nameDataGridViewTextBoxColumn4.Width = 125;
            // 
            // professionDataGridViewTextBoxColumn
            // 
            this.professionDataGridViewTextBoxColumn.DataPropertyName = "Profession";
            this.professionDataGridViewTextBoxColumn.HeaderText = "Profession";
            this.professionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.professionDataGridViewTextBoxColumn.Name = "professionDataGridViewTextBoxColumn";
            this.professionDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDID,
            this.iDREQDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn2,
            this.amountDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.fKFurnitureHospitalNamesBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(495, 274);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(447, 150);
            this.dataGridView4.TabIndex = 3;
            this.dataGridView4.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView4_UserDeletingRow);
            // 
            // IDID
            // 
            this.IDID.DataPropertyName = "ID";
            this.IDID.HeaderText = "ID";
            this.IDID.MinimumWidth = 6;
            this.IDID.Name = "IDID";
            this.IDID.Width = 125;
            // 
            // iDREQDataGridViewTextBoxColumn1
            // 
            this.iDREQDataGridViewTextBoxColumn1.DataPropertyName = "IDREQ";
            this.iDREQDataGridViewTextBoxColumn1.HeaderText = "IDREQ";
            this.iDREQDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDREQDataGridViewTextBoxColumn1.Name = "iDREQDataGridViewTextBoxColumn1";
            this.iDREQDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDproper";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDHosp";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDnum,
            this.dataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn3,
            this.amountDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.fKMedicalResourcesHospitalNamesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 464);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(407, 150);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // IDnum
            // 
            this.IDnum.DataPropertyName = "ID";
            this.IDnum.HeaderText = "ID";
            this.IDnum.MinimumWidth = 6;
            this.IDnum.Name = "IDnum";
            this.IDnum.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDproper";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDHosp";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn2
            // 
            this.amountDataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn2.Name = "amountDataGridViewTextBoxColumn2";
            this.amountDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.iDREQDataGridViewTextBoxColumn,
            this.IDproper,
            this.nameDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn,
            this.qualificationDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKEquipmentHospitalNamesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(9, 274);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(447, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // iDREQDataGridViewTextBoxColumn
            // 
            this.iDREQDataGridViewTextBoxColumn.DataPropertyName = "IDREQ";
            this.iDREQDataGridViewTextBoxColumn.HeaderText = "IDREQ";
            this.iDREQDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDREQDataGridViewTextBoxColumn.Name = "iDREQDataGridViewTextBoxColumn";
            this.iDREQDataGridViewTextBoxColumn.Width = 125;
            // 
            // IDproper
            // 
            this.IDproper.DataPropertyName = "IDproper";
            this.IDproper.HeaderText = "IDHosp";
            this.IDproper.MinimumWidth = 6;
            this.IDproper.Name = "IDproper";
            this.IDproper.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // qualificationDataGridViewTextBoxColumn
            // 
            this.qualificationDataGridViewTextBoxColumn.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qualificationDataGridViewTextBoxColumn.Name = "qualificationDataGridViewTextBoxColumn";
            this.qualificationDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hospitalNamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(533, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 320;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 909);
            this.tabControl1.TabIndex = 1;
            // 
            // equipmentTableAdapter1
            // 
            this.equipmentTableAdapter1.ClearBeforeFill = true;
            // 
            // journalEquipmentTableAdapter
            // 
            this.journalEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // qualificationStaffBindingSource
            // 
            this.qualificationStaffBindingSource.DataMember = "Qualification staff";
            this.qualificationStaffBindingSource.DataSource = this.bindingSource1;
            // 
            // IDREQ
            // 
            this.IDREQ.DataPropertyName = "IDREQ";
            this.IDREQ.HeaderText = "IDREQ";
            this.IDREQ.MinimumWidth = 6;
            this.IDREQ.Name = "IDREQ";
            this.IDREQ.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn5
            // 
            this.nameDataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn5.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn5.Name = "nameDataGridViewTextBoxColumn5";
            this.nameDataGridViewTextBoxColumn5.Width = 125;
            // 
            // Profession
            // 
            this.Profession.DataPropertyName = "Profession";
            this.Profession.HeaderText = "Profession";
            this.Profession.MinimumWidth = 6;
            this.Profession.Name = "Profession";
            this.Profession.Width = 125;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "Contact";
            this.Contact.MinimumWidth = 6;
            this.Contact.Name = "Contact";
            this.Contact.Width = 125;
            // 
            // dataGridView9
            // 
            this.dataGridView9.AutoGenerateColumns = false;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDREQDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn6,
            this.qualificationDataGridViewTextBoxColumn1});
            this.dataGridView9.DataSource = this.equipmentBindingSource;
            this.dataGridView9.Location = new System.Drawing.Point(8, 722);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.RowHeadersWidth = 51;
            this.dataGridView9.RowTemplate.Height = 24;
            this.dataGridView9.Size = new System.Drawing.Size(848, 150);
            this.dataGridView9.TabIndex = 8;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.bindingSource1;
            // 
            // iDREQDataGridViewTextBoxColumn3
            // 
            this.iDREQDataGridViewTextBoxColumn3.DataPropertyName = "IDREQ";
            this.iDREQDataGridViewTextBoxColumn3.HeaderText = "IDREQ";
            this.iDREQDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.iDREQDataGridViewTextBoxColumn3.Name = "iDREQDataGridViewTextBoxColumn3";
            this.iDREQDataGridViewTextBoxColumn3.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn6
            // 
            this.nameDataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn6.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn6.Name = "nameDataGridViewTextBoxColumn6";
            this.nameDataGridViewTextBoxColumn6.Width = 125;
            // 
            // qualificationDataGridViewTextBoxColumn1
            // 
            this.qualificationDataGridViewTextBoxColumn1.DataPropertyName = "Qualification";
            this.qualificationDataGridViewTextBoxColumn1.HeaderText = "Qualification";
            this.qualificationDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.qualificationDataGridViewTextBoxColumn1.Name = "qualificationDataGridViewTextBoxColumn1";
            this.qualificationDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 909);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HospitalDB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKQualificationStaffStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStaffHospitalNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFurnitureHospitalNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMedicalResourcesHospitalNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEquipmentHospitalNamesBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalEquipmentBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qualificationStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private ProjectDBDataSet projectDBDataSet;
        private System.Windows.Forms.BindingSource hospitalNamesBindingSource;
        private ProjectDBDataSetTableAdapters.Hospital_namesTableAdapter hospital_namesTableAdapter;
        private System.Windows.Forms.BindingSource fKEquipmentHospitalNamesBindingSource;
        private ProjectDBDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.BindingSource fKFurnitureHospitalNamesBindingSource;
        private ProjectDBDataSetTableAdapters.FurnitureTableAdapter furnitureTableAdapter;
        private System.Windows.Forms.BindingSource fKMedicalResourcesHospitalNamesBindingSource;
        private ProjectDBDataSetTableAdapters.Medical_resourcesTableAdapter medical_resourcesTableAdapter;
        private System.Windows.Forms.BindingSource fKStaffHospitalNamesBindingSource;
        private ProjectDBDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource fKQualificationStaffStaffBindingSource;
        private ProjectDBDataSetTableAdapters.Qualification_staffTableAdapter qualification_staffTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private ProjectDBDataSetTableAdapters.EquipmentTableAdapter equipmentTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDeqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREQDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDpropert;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREQDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDproper;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.BindingSource journalEquipmentBindingSource;
        private ProjectDBDataSetTableAdapters.JournalEquipmentTableAdapter journalEquipmentTableAdapter;
        private System.Windows.Forms.Button SearchEquipment;
        private System.Windows.Forms.Button SearchStaff;
        private System.Windows.Forms.TextBox idEquip;
        private System.Windows.Forms.TextBox idStaff;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDeqDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn causeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.BindingSource qualificationStaffBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name123;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDREQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDREQDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualificationDataGridViewTextBoxColumn1;
    }
}

