using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBHospital
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            journalEquipmentTableAdapter.Fill(projectDBDataSet.JournalEquipment);

            var connectionString = @"Data Source=DESKTOP-UOFK5U6\SQLEXPRESS;Initial Catalog=ProjectDB;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            
            await sqlConnection.OpenAsync();

            #region Hide

            qualification_staffTableAdapter.Fill(projectDBDataSet.Qualification_staff);
            staffTableAdapter.Fill(projectDBDataSet.Staff);
            medical_resourcesTableAdapter.Fill(projectDBDataSet.Medical_resources);
            furnitureTableAdapter.Fill(projectDBDataSet.Furniture);
            equipmentTableAdapter.Fill(projectDBDataSet.Equipment);
            hospital_namesTableAdapter.Fill(projectDBDataSet.Hospital_names);

            #endregion
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dr = MessageBox.Show("Delete this hospital?", "Delete", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dr = MessageBox.Show("Delete this equipment?", "Delete", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dr = MessageBox.Show("Delete this furniture?", "Delete", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dr = MessageBox.Show("Delete this resource?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView5_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dr = MessageBox.Show("Delete this staff?", "Delete", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView6_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var dr = MessageBox.Show("Delete this qualification?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void SearchStaff_Click(object sender, EventArgs e)
        {
            try
            {
                staffBindingSource.Filter = "Convert(IDREQ, 'System.String') like '%" + idStaff.Text + "%'";
            }
            catch (Exception)
            {
                MessageBox.Show("Search failed");
            }        
        }

        private void SearchEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                equipmentBindingSource.Filter = "Convert(IDREQ, 'System.String') like '%" + idEquip.Text + "%'";
            }
            catch (Exception)
            {
                MessageBox.Show("Search failed");
            }
        }
    }
}
