using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.AxHost;

using simrs.Data;
using System.Data.SqlClient;

namespace simrs
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //validasi
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    epUserName.SetError(txtUserName, "Username is required");
                    return;
                }
                else
                {
                    epUserName.SetError(txtUserName, string.Empty);
                }

                if (string.IsNullOrEmpty(txtUserPassword.Text.Trim()))
                {
                    epUserPassword.SetError(txtUserPassword, "User password is required");
                    return;
                }
                else
                {
                    epUserPassword.SetError(txtUserPassword, string.Empty);
                }

                //koneksi ke sql server
                DataBase db = new DataBase();
                db.Connect();

                //tampilkan form utama
                FrmUtama frmUtama = new FrmUtama();
                frmUtama.Show();
                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUserPassword.Focus();
                e.Handled = true;
            }

        }

    }
}
