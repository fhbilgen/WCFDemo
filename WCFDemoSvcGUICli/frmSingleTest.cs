using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.ServiceModel.Configuration;
using System.ServiceModel;

namespace WCFDemoSvcGUICli
{
    public partial class frmSingleTest : Form
    {   
        public frmSingleTest()
        {
            InitializeComponent();
            PrepareControls();
        }

        public void PrepareControls()
        {
            foreach (string str in GetClientNamesFromConfigFile())
                cBoxClientList.Items.Add(str);

            cBoxClientList.SelectedIndex = 0;
        }

        public List<string> GetClientNamesFromConfigFile()
        {
            List<string> ClientNames = null;
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ServiceModelSectionGroup serviceModel = ServiceModelSectionGroup.GetSectionGroup(appConfig);
            ClientSection clients = serviceModel.Client;

            ChannelEndpointElementCollection cepec = clients.Endpoints;
            
            if (cepec.Count > 0)
            {
                
                ClientNames = new List<string>();
                
                foreach( ChannelEndpointElement cepe in cepec )
                { 
                    string[] sa = cepe.Contract.ToString().Split('.');
                    ClientNames.Add(sa[0]);                    
                }
            }
                        
            return ClientNames;
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            DemoServiceClient.DemoServiceClient dsc;
            DemoServiceSesAClient.DemoSvcSesAClient dssc;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac;

            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient();

                    //WCFDemoSvcGUICli.SimpleBehaviorExtensionElement
                    /*Message Inspector vs*/
                    tbPing.Text = dsc.Ping();
                    dsc.Close();
                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient();
                    tbPing.Text = dssc.Ping();
                    dssc.Close();
                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient();
                    tbPing.Text = dssnac.Ping();
                    dssnac.Close();
                    break;

                default :
                    MessageBox.Show("No Client!");
                    break;
            }
         }

        private void btnEcho_Click(object sender, EventArgs e)
        {
            DemoServiceClient.DemoServiceClient dsc;
            DemoServiceSesAClient.DemoSvcSesAClient dssc;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac;

            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient();
                    tbEcho.Text += dsc.Echo(tbEcho.Text);
                    dsc.Close();
                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient();
                    tbEcho.Text += dssc.Echo(tbEcho.Text);
                    dssc.Close();
                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient();
                    tbEcho.Text += dssnac.Echo(tbEcho.Text);
                    dssnac.Close();
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }

        private void btnGetHostName_Click(object sender, EventArgs e)
        {
            DemoServiceClient.DemoServiceClient dsc;
            DemoServiceSesAClient.DemoSvcSesAClient dssc;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac;

            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient();
                    tbHostName.Text = dsc.GetHostName();                    
                    dsc.Close();
                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient();
                    tbHostName.Text = dssc.GetHostName();
                    dssc.Close();
                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient();
                    tbHostName.Text = dssnac.GetHostName();
                    dssnac.Close();
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }

        private void btnGetHostTime_Click(object sender, EventArgs e)
        {
            DemoServiceClient.DemoServiceClient dsc;
            DemoServiceSesAClient.DemoSvcSesAClient dssc;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac;

            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient();
                    tbHostTime.Text = dsc.GetHostTime().ToLongTimeString();                    
                    dsc.Close();
                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient();
                    tbHostTime.Text = dssc.GetHostTime().ToLongTimeString();                    
                    dssc.Close();
                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient();
                    tbHostTime.Text = dssnac.GetHostTime().ToLongTimeString();                                        
                    dssnac.Close();
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }

        private void btnCauseException_Click(object sender, EventArgs e)
        {
            DemoServiceClient.DemoServiceClient dsc;            
            
            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient();
                    dsc.CauseException();                    
                    dsc.Close();
                    break;

                case "DemoServiceSesAClient":
                    MessageBox.Show("Not implemented in DemoServiceSesAClient!");
                    break;

                case "DemoServiceSesNAClient":
                    MessageBox.Show("Not implemented in DemoServiceSesNAClient!");
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }

        private void btnIncrementCounter_Click(object sender, EventArgs e)
        {
            DemoServiceSesAClient.DemoSvcSesAClient dssc;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac;

            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    MessageBox.Show("Not implemented in DemoServiceClient!");
                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient();
                    tbIncrementCounter.Text = dssc.IncrementCounter(1).ToString();
                    dssc.Close();
                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient();
                    tbIncrementCounter.Text = dssnac.IncrementCounter(1).ToString();
                    dssnac.Close();
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }

        private void btnDecrementCounter_Click(object sender, EventArgs e)
        {
            DemoServiceSesAClient.DemoSvcSesAClient dssc;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac;

            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    MessageBox.Show("Not implemented in DemoServiceClient!");
                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient();
                    tbDecrementCounter.Text = dssc.DecrementCounter(1).ToString();                    
                    dssc.Close();
                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient();
                    tbDecrementCounter.Text = dssnac.DecrementCounter(1).ToString();
                    dssnac.Close();
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }

        private void btnGetCounter_Click(object sender, EventArgs e)
        {
            DemoServiceSesAClient.DemoSvcSesAClient dssc;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac;

            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    MessageBox.Show("Not implemented in DemoServiceClient!");
                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient();
                    tbGetCounter.Text = dssc.GetCounter().ToString();                    
                    dssc.Close();
                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient();
                    tbGetCounter.Text = dssnac.GetCounter().ToString();                    
                    dssnac.Close();
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }

        private void btnGuessGender_Click(object sender, EventArgs e)
        {
            DemoServiceClient.DemoServiceClient dsc;
            DemoServiceClient.PersonInfo pi = new DemoServiceClient.PersonInfo();
            DemoServiceClient.Sex gndr;

            pi.Age = 40;
            pi.Name = "ABC";        //  Should return Female
            pi.Surname = "XYZ";

            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient();
                    //tbHostTime.Text = dsc.GetHostTime().ToLongTimeString();
                    gndr = dsc.GuessGender(pi);
                    if (gndr == DemoServiceClient.Sex.Female)
                        tbGuessGender.Text = "Female";
                    else
                        tbGuessGender.Text = "Male";

                    dsc.Close();
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }

        private void btnGetPerson_Click(object sender, EventArgs e)
        {
            DemoServiceClient.DemoServiceClient dsc;
            DemoServiceClient.PersonInfo pi;


            switch (cBoxClientList.SelectedItem.ToString())
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient();
                    //tbHostTime.Text = dsc.GetHostTime().ToLongTimeString();
                    pi = dsc.GetPerson();
                    dsc.Close();

                    tbGetPerson.Text = string.Format("{0} {1} {2} years old", pi.Name, pi.Surname, pi.Age);
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }
        }
    }
}
