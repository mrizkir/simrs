using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        private void FrmUsers_Load(object sender, EventArgs e)
        {
            this.setDaftarRoles();
        }
    }
}
