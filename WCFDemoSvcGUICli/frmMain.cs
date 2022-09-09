using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace WCFDemoSvcGUICli
{
    public partial class frmMain : Form
    {
      
        public frmMain()
        {
            InitializeComponent();
            
        }
        
        private void btnOpenLoadTest_Click(object sender, EventArgs e)
        {
            frmLoadTest f = new frmLoadTest();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnOpenSingleForm_Click(object sender, EventArgs e)
        {
            frmSingleTest f = new frmSingleTest();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnOpenSecureClientForm_Click(object sender, EventArgs e)
        {
            frmSecureClient f = new frmSecureClient();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnWCFCliFrm_Click(object sender, EventArgs e)
        {
            frmWCFPrxProblem frmWCFPrxProblem = new frmWCFPrxProblem();
            frmWCFPrxProblem.ShowDialog();
        }
    }
}
