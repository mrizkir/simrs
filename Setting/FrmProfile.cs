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
    public partial class FrmProfile : Form
    {
        internal static Dictionary<string, object> DataUser;

        public FrmProfile(Dictionary<string, object> dataUser)
        {
            InitializeComponent();
            DataUser = dataUser;
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            
        }
    }
}
