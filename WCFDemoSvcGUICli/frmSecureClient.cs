using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFDemoSvcGUICli
{
    public partial class frmSecureClient : Form
    {
        public frmSecureClient()
        {
            InitializeComponent();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {            
            DemoServiceSecureClient.DemoServiceSecureClient client;

            client = new DemoServiceSecureClient.DemoServiceSecureClient();
            tbPing.Text = client.Ping();
            client.Close();
                        
        }

        private void btnEcho_Click(object sender, EventArgs e)
        {
            DemoServiceSecureClient.DemoServiceSecureClient client;

            client = new DemoServiceSecureClient.DemoServiceSecureClient();            
            tbEcho.Text += client.Echo(tbEcho.Text);
            client.Close();
            
        }

        private void btnGetHostName_Click(object sender, EventArgs e)
        {
            DemoServiceSecureClient.DemoServiceSecureClient client;

            client = new DemoServiceSecureClient.DemoServiceSecureClient();
            tbHostName.Text = client.GetHostName();            
            client.Close();
        }

        private void btnGetHostTime_Click(object sender, EventArgs e)
        {
            DemoServiceSecureClient.DemoServiceSecureClient client;

            client = new DemoServiceSecureClient.DemoServiceSecureClient();            
            tbHostTime.Text = client.GetHostTime().ToLongTimeString();
            client.Close();
        }


    }
}
