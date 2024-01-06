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
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void FrmUtama_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }
    }
}
