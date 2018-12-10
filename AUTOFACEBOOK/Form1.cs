using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTOFACEBOOK
{
    public partial class frmMAIN : Form
    {
        public frmMAIN()
        {
            InitializeComponent();
        }

        private void btnTOKEN_Click(object sender, EventArgs e)
        {
            btnACOM.Enabled = true;
            btnDCOM.Enabled = true;
            btnAPOST.Enabled = true;
            btnDPOST.Enabled = true;

            btnRUN.Enabled = true;
            btnTOKEN.Enabled = false;
            txtUSERNAME.Enabled = false;
            txtPASSWORD.Enabled = false;


        }
    }
}
