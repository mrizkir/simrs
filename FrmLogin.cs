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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            DataBase DB = new DataBase();
           
            try
            {
                DB.Connect();

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

                var paramList = new List<SqlParameter>();
                paramList.Add(new SqlParameter("@pUsername", txtUserName.Text.Trim()));
                paramList.Add(new SqlParameter("@pPassword", txtUserPassword.Text.Trim()));
                SqlParameter output = new SqlParameter("@responseMessage", txtUserPassword.Text.Trim());
                output.Direction = ParameterDirection.Output;
                paramList.Add(output);

                DB.ExecuteStoredProcedure("uspLogin", paramList);
                
                if(output.Value.ToString() == "0")
                {
                    throw new Exception("Username atau Password SALAH silahkan isi dengan yang benar !!!");
                }

                int userid = Convert.ToInt32(output.Value);
                
                Dictionary<string, object> dataUser = new Dictionary<string, object>(); ;
                dataUser.Add("data_user", userid);

                //tampilkan form utama
                FrmUtama frmUtama = new FrmUtama(dataUser);
                
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
            finally
            {
                DB.Close();
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

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            epUserName.SetError(txtUserName, null);
        }

        private void txtUserPassword_TextChanged(object sender, EventArgs e)
        {
            epUserPassword.SetError(txtUserPassword, null);
        }
    }
}
