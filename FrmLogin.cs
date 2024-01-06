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
                DataBase db = new DataBase();
                db.Connect();


                FrmUtama frmUtama = new FrmUtama();
                frmUtama.Show();
                this.Hide();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR DATABASE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
