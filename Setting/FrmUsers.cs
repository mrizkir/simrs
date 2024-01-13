using simrs.Data;
using simrs.Helper;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace simrs.Setting
{
    public partial class FrmUsers : Form
    {
        int rowIndex = -1;

        public FrmUsers()
        {
            InitializeComponent();
        }

        void setDaftarRoles()
        {
            Dictionary<string, string> daftarRoles = new Dictionary<string, string>();

            daftarRoles.Add("none", "- PILIH ROLE -");
            daftarRoles.Add("superadmin", "SUPERADMIN");
            daftarRoles.Add("dokter", "DOKTER");
            daftarRoles.Add("pasien", "PASIEN");

            this.cmbRoles.DataSource = new BindingSource(daftarRoles, null);
            this.cmbRoles.DisplayMember = "Value";
            this.cmbRoles.ValueMember = "Key";

        }

        void PopulateData()
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
            this.dgUsers.Columns[2].Width = 250;
            
            this.dgUsers.Columns[3].HeaderText = "DEFAULT ROLE";
            this.dgUsers.Columns[3].Width = 120;
            
            this.dgUsers.Columns[4].HeaderText = "NOMOR HP";
            this.dgUsers.Columns[4].Width = 120;
            
            this.dgUsers.Columns[5].HeaderText = "EMAIL";
            this.dgUsers.Columns[5].Width = 200;
            
            this.dgUsers.Columns[6].HeaderText = "CREATED";
            this.dgUsers.Columns[6].Width = 120;
            
            this.dgUsers.Columns[7].HeaderText = "UPDATED";
            this.dgUsers.Columns[7].Width = 120;
            
        }

        /// <summary>
        /// validasi form
        /// </summary>
        /// <param name="mode"></param>
        bool ValidasiFrmUser(string mode, DataBase DB)
        {
            bool isValid = true;

            //cek username
            string userName = this.txtUserName.Text;
            string userEmail= this.txtEmail.Text;
            
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                epUserName.SetError(txtUserName, "Username jangan kosong silahkan isi");
                isValid = false;
            }
            else if(DB.checkRecordIsExist($"SELECT COUNT(id) FROM users WHERE username='{userName}'"))
            {
                epUserName.SetError(txtUserName, $"Username ({userName}) telah tersedia. Silahkan ganti dengan yang lain");
                isValid = false;
            }
            else
            {
                epUserName.SetError(txtUserName, string.Empty);
            }

            //cek user password
            if (string.IsNullOrEmpty(txtUserPassword.Text.Trim()))
            {
                epUserPassword.SetError(txtUserPassword, "Password user jangan kosong silahkan isi");
                isValid = false;
            }
            else if (txtUserPassword.Text.Trim().Length < 8)    
            {
                epUserPassword.SetError(txtUserPassword, "Panjang password user diharapkan lebih dari 8");
                isValid = false;
            }
            else
            {
                epUserPassword.SetError(txtUserPassword, string.Empty);
            }

            //roles user
            string role = ((KeyValuePair<string, string>)cmbRoles.SelectedItem).Key;
            if(role.Equals("none"))
            {
                epDefaultRole.SetError(cmbRoles, "Default role dari user mohon untuk dipilih");
                isValid = false;
            }
            else
            {
                epDefaultRole.SetError(cmbRoles, string.Empty);
            }

           
            //cek email
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                epEmail.SetError(txtEmail, "Email user jangan kosong silahkan isi");
                isValid = false;
            }
            else if (!HelperValidation.CheckEmailAddressValid(txtEmail.Text) )
            {
                epEmail.SetError(txtEmail, "Format Email user salah");
                isValid = false;
            }
            else if (DB.checkRecordIsExist($"SELECT COUNT(id) FROM users WHERE email='{userEmail}'"))
            {
                epEmail.SetError(txtEmail, $"Email ({userEmail}) telah tersedia. Silahkan ganti dengan yang lain");
                isValid = false;
            }
            else
            {
                epEmail.SetError(txtEmail, string.Empty);
            }

            return isValid;
        }
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                this.setDaftarRoles();

                this.PopulateData();
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
            DB.Connect();
            try
            {
                bool isValid = this.ValidasiFrmUser("insert", DB);

                if(isValid)
                {
                    string userName = this.txtUserName.Text;
                    string userPassword = this.txtUserPassword.Text;

                    string role = ((KeyValuePair<string, string>)cmbRoles.SelectedItem).Key;
                    
                    string email = this.txtEmail.Text;
                    string nomorHP = this.txtNomorHP.Text.Replace("-", string.Empty);
                    string namaLengkap = this.txtNamaLengkap.Text;
                    char JK = 'L';
                    if (rdPerempuan.Checked)
                    {
                        JK = 'P';
                    }

                    string tempatLahir = this.txtTempatLahir.Text;
                    string tanggaLahir = this.dtTanggalLahir.Value.ToString("yyyy-MM-dd");

                    string sql = $"INSERT INTO users (username, password, default_role, email, nomor_hp, nama_lengkap, jk, tempat_lahir, tanggal_lahir, created_at, updated_at) VALUES ('{userName}','{userPassword}','{role}','{email}','{nomorHP}','{namaLengkap}','{JK}','{tempatLahir}','{tanggaLahir}', GETDATE(), GETDATE())";

                    DB.InsertRecord(sql);

                    MessageBox.Show($"Data user ({userName}) berhasil ditambah", "TAMBAH USER", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.PopulateData();
                }
                else
                {
                    throw new Exception("Data user kurang lengkap atau terdapat kesalahan, silahkan dicek kembali.");
                }
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
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.Connect();
            try
            {
                if (this.rowIndex > -1)
                {
                    string ID = this.dgUsers.Rows[this.rowIndex].Cells[0].Value.ToString();
                    string userName = this.dgUsers.Rows[this.rowIndex].Cells[1].Value.ToString();
                    DialogResult dr = MessageBox.Show($"Apakah Anda ingin menghapus Data User ({userName}) ?", "HAPUS USER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dr == DialogResult.Yes)
                    {

                        string sql = $"DELETE FROM users WHERE ID='{ID}'";

                        DB.DeleteRecord(sql);

                        this.PopulateData();

                        MessageBox.Show($"Data user {userName} berhasil Dihapus", "HAPUS USER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            epUserName.SetError(txtUserName, null);
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            epUserPassword.SetError(txtUserPassword, null);
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            epDefaultRole.SetError(cmbRoles, null);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            epEmail.SetError(txtEmail, null);
        }


        private void dgUsers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.rowIndex = e.RowIndex;
                if (this.rowIndex > -1)
                {
                    this.dgUsers.Rows[this.rowIndex].Selected = true;
                    this.cmsDgUsers.Show(this.dgUsers, e.Location);
                    this.cmsDgUsers.Show(Cursor.Position);
                }
            }

        }

        
    }
}
