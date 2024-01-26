using simrs.Pasien;
using simrs.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simrs
{
    public partial class FrmUtama : Form
    {
        internal static Dictionary<string, object> DataUser;

        public FrmUtama(Dictionary<string, object> dataUser)
        {
            DataUser = dataUser;
            InitializeComponent();
        }

        private void FrmUtama_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void menuSettingUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers();
            frmUsers.MdiParent = this;
            frmUsers.Show();
            /*frmUsers.WindowState = FormWindowState.Maximized;*/
        }

        private void pROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfile frmProfile = new FrmProfile(DataUser);
            frmProfile.MdiParent = this;
            frmProfile.Show();
        }

		private void rEGISTRASIAWALToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmBiodataPasien frmBiodata= new FrmBiodataPasien();
			frmBiodata.MdiParent = this;
			frmBiodata.Show();
		}
	}
}
