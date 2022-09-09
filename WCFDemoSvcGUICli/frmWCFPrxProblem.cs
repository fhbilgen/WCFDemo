using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.ServiceModel.Configuration;
using System.ServiceModel;

namespace WCFDemoSvcGUICli
{
    public partial class frmWCFPrxProblem : Form
    {

        public static Thread[] m_clientThreads;
        public static string m_SelectedClient;
        public static string m_SelectedEP;
        public static object m_LockOutput = new object();
        public List<EndPoint> m_ClientEndPoints = null;

        public frmWCFPrxProblem()
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
            string name;
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ServiceModelSectionGroup serviceModel = ServiceModelSectionGroup.GetSectionGroup(appConfig);
            ClientSection clients = serviceModel.Client;

            ChannelEndpointElementCollection cepec = clients.Endpoints;

            if (cepec.Count > 0)
            {

                ClientNames = new List<string>();
                m_ClientEndPoints = new List<EndPoint>();

                foreach (ChannelEndpointElement cepe in cepec)
                {
                    string[] sa = cepe.Contract.ToString().Split('.');
                    name = sa[0] + "(" + cepe.Binding + ")";


                    m_ClientEndPoints.Add(new EndPoint(cepe.Name, sa[0]));
                    ClientNames.Add(name);
                }
            }

            return ClientNames;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int iPing, iTotalThreads;

            string str = cBoxClientList.SelectedItem.ToString();

            string[] sa = str.Split('(');
            m_SelectedClient = sa[0];
            m_SelectedEP = m_ClientEndPoints[cBoxClientList.SelectedIndex].m_EPName;


            //m_Stop.Reset();

            
            if (!string.IsNullOrEmpty(tbPingThreads.Text))
                Int32.TryParse(tbPingThreads.Text, out iPing);
            else
                iPing = 0;

            iTotalThreads = iPing;

            m_clientThreads = new Thread[iTotalThreads];

            for (int i = 0; i != iPing; i++)
            {
                m_clientThreads[i] = new Thread(new ThreadStart(CallPing));
                m_clientThreads[i].Start();
            }
            
            //MessageBox.Show(iTotalThreads.ToString());

            //Application.UseWaitCursor = true;
        }



        public static void CallPing()
        {
            // DemoServiceClient.DemoServiceClient demo = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

            DemoServiceClient.DemoServiceClient dsc = null;
            DemoServiceSesAClient.DemoSvcSesAClient dssc = null;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac = null;
            string strMessage = "";


            if (m_SelectedClient.Equals("DemoServiceClient"))
            {
                while (true)
                {
                    dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

                    try
                    {
                        strMessage = dsc.Ping();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                    }                    
                }
            }

            if (m_SelectedClient.Equals("DemoServiceSesAClient"))
            {
                while (true)
                {
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                    try
                    {
                        strMessage = dssc.Ping();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                    }                   
                }
            }

            if (m_SelectedClient.Equals("DemoServiceSesNAClient"))
            {
                while (true)
                {
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                    try
                    {
                        strMessage = dssnac.Ping();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                    }                    
                }
            }            

            //if (dsc != null)
            //    dsc.Close();

            //if (dssc != null)
            //    dssc.Close();

            //if (dssnac != null)
            //    dssnac.Close();

        }


    }
}
