using simrs.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simrs.Setting
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        void setDaftarRoles()
        {
            Dictionary<int, string> daftarRoles = new Dictionary<int, string>();

            daftarRoles.Add(-1, "- PILIH ROLE -");
            daftarRoles.Add(1, "SUPERADMIN");
            daftarRoles.Add(2, "DOKTER");
            daftarRoles.Add(3, "PASIEN");

            this.cmbRoles.DataSource = new BindingSource(daftarRoles, null);
            this.cmbRoles.DisplayMember = "Value";
            this.cmbRoles.ValueMember = "Key";

        }

        void populateData()
        {
            DataBase DB = new DataBase();
            DB.Connect();

            string sql = "SELECT id, username, nama_lengkap, default_role, nomor_hp, email, created_at, updated_at FROM users";

            DataSet dataSet = DB.GetDataSet(sql);

            this.dgUsers.DataSource = dataSet.Tables[0];

            this.dgUsers.Columns[0].HeaderText = "ID";
            this.dgUsers.Columns[0].Width = 50;
            this.dgUsers.Columns[1].HeaderText = "USERNAME";
            this.dgUsers.Columns[1].Width = 150;
            this.dgUsers.Columns[2].HeaderText = "NAMA LENGKAP";
            this.dgUsers.Columns[2].Width = 170;
            this.dgUsers.Columns[3].HeaderText = "DEFAULT ROLE";
            this.dgUsers.Columns[3].Width = 80;
            this.dgUsers.Columns[4].HeaderText = "NOMOR HP";
            this.dgUsers.Columns[4].Width = 80;
            this.dgUsers.Columns[5].HeaderText = "EMAIL";
            this.dgUsers.Columns[5].Width = 110;
            this.dgUsers.Columns[6].HeaderText = "CREATED";
            this.dgUsers.Columns[6].Width = 60;
            this.dgUsers.Columns[7].HeaderText = "UPDATED";
            this.dgUsers.Columns[7].Width = 60;

        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                this.setDaftarRoles();
                this.populateData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            try
            {
                DB.Connect();
                this.populateData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { 
                DB.Close();
            }
        }
    }
}
