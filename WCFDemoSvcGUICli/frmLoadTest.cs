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
using System.Threading;

namespace WCFDemoSvcGUICli
{

    
    public partial class frmLoadTest : Form
    {
        public static ManualResetEvent m_Stop;
        public static bool m_ReuseProxy;
        public static Thread[] m_clientThreads;
        public static string m_SelectedClient;
        public static string m_SelectedEP;
        public static object m_LockOutput = new object();
        public List<EndPoint> m_ClientEndPoints = null;
        public static int m_Duration=0;
        public static RichTextBox m_rb;
        public static void WriteOutput(string strMessage)
        {
            lock(m_LockOutput)
            {
                //frmLoadTest.rbOutput.AppendText(strMessage + "\n\r");
                //rboutput.AppendText(strMessage + "\n\r");
                m_rb.AppendText(strMessage + "\n\r");
            }
        }
        public frmLoadTest()
        {
            rbOutput = new RichTextBox();
            InitializeComponent();
            m_Stop = new ManualResetEvent(false);
            m_ReuseProxy = false;
            m_rb = this.rbOutput;
            PrepareControls();
        }

        public void PrepareControls()
        {
            foreach (string str in GetClientNamesFromConfigFile())
                cBoxClientList.Items.Add(str);

            cBoxClientList.SelectedIndex = 0;
            m_cbReuseProxy.Checked = false;
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

                    
                    m_ClientEndPoints.Add(new EndPoint( cepe.Name, sa[0]));                                        
                    ClientNames.Add(name);
                }
            }

            return ClientNames;
        }

        public static string GetThreadID()
        {
            return System.Threading.Thread.CurrentThread.ManagedThreadId.ToString();
        }
        public static void CallHostTime()
        {
            // DemoServiceClient.DemoServiceClient demo = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

            DemoServiceClient.DemoServiceClient dsc=null;
            DemoServiceSesAClient.DemoSvcSesAClient dssc=null;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac=null;
            string strMessage = "";

            switch ( m_SelectedClient )
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);
                    // tbHostTime.Text = UPDATE THE RICHTEXTBOX
                    //dsc.GetHostTime().ToLongTimeString();

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dsc == null)
                            dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

                        try
                        {
                            strMessage = dsc.GetHostTime().ToLongTimeString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dsc.Close();
                                dsc = null;
                            }
                        }

                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage );
                    }
                                        
                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssc == null)
                            dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssc.GetHostTime().ToLongTimeString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssc.Close();
                                dssc = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssnac == null)
                            dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssnac.GetHostTime().ToLongTimeString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssnac.Close();
                                dssnac = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }


            if (dsc != null)
                dsc.Close();

            if (dssc != null)
                dssc.Close();

            if (dssnac != null)
                dssnac.Close();
            
        }


        public static void CallPing()
        {
            // DemoServiceClient.DemoServiceClient demo = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

            DemoServiceClient.DemoServiceClient dsc = null;
            DemoServiceSesAClient.DemoSvcSesAClient dssc = null;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac = null;
            string strMessage ="";

            switch (m_SelectedClient)
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);
                    // tbHostTime.Text = UPDATE THE RICHTEXTBOX
                    //dsc.GetHostTime().ToLongTimeString();

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dsc == null)
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
                            if (!m_ReuseProxy)
                            {
                                dsc.Close();
                                dsc = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssc == null)
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
                            if (!m_ReuseProxy)
                            {
                                dssc.Close();
                                dssc = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssnac == null)
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
                            if (!m_ReuseProxy)
                            {
                                dssnac.Close();
                                dssnac = null;
                            }
                        }

                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }


            if (dsc != null)
                dsc.Close();

            if (dssc != null)
                dssc.Close();

            if (dssnac != null)
                dssnac.Close();

        }

        public static void CallDelay()
        {
            // DemoServiceClient.DemoServiceClient demo = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

            DemoServiceClient.DemoServiceClient dsc = null;
            DemoServiceSesAClient.DemoSvcSesAClient dssc = null;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac = null;
            System.DateTime start, stop;
            string strMessage = "";
                     

            switch (m_SelectedClient)
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);
                    
                    while (!m_Stop.WaitOne(100))
                    {
                        if (dsc == null)
                            dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

                        try
                        {
                            start = DateTime.Now;
                            dsc.Delay(m_Duration);
                            stop = DateTime.Now;
                            strMessage = start.ToLongTimeString() + " - " + stop.ToLongTimeString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dsc.Close();
                                dsc = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssc == null)
                            dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                        try
                        {
                            start = DateTime.Now;
                            dssc.Delay(m_Duration);
                            stop = DateTime.Now;
                            strMessage = start.ToLongTimeString() + " - " + stop.ToLongTimeString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssc.Close();
                                dssc = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssnac == null)
                            dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                        try
                        {
                            start = DateTime.Now;
                            dssnac.Delay(m_Duration);
                            stop = DateTime.Now;
                            strMessage = start.ToLongTimeString() + " - " + stop.ToLongTimeString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssnac.Close();
                                dssnac = null;
                            }
                        }

                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }


            if (dsc != null)
                dsc.Close();

            if (dssc != null)
                dssc.Close();

            if (dssnac != null)
                dssnac.Close();

        }


        public static void CallHostName()
        {
            // DemoServiceClient.DemoServiceClient demo = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

            DemoServiceClient.DemoServiceClient dsc = null;
            DemoServiceSesAClient.DemoSvcSesAClient dssc = null;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac = null;
            string strMessage = " ";

            switch (m_SelectedClient)
            {
                case "DemoServiceClient":
                    dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);
                    // tbHostTime.Text = UPDATE THE RICHTEXTBOX
                    //dsc.GetHostTime().ToLongTimeString();

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dsc == null)
                            dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

                        try
                        {
                            strMessage = dsc.GetHostName();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dsc.Close();
                                dsc = null;
                            }
                        }

                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssc == null)
                            dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssc.GetHostName();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssc.Close();
                                dssc = null;
                            }
                        }

                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssnac == null)
                            dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssnac.GetHostName();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssnac.Close();
                                dssnac = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }


            if (dsc != null)
                dsc.Close();

            if (dssc != null)
                dssc.Close();

            if (dssnac != null)
                dssnac.Close();

        }

        public static void CallIncrement()
        {
            // DemoServiceClient.DemoServiceClient demo = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

            DemoServiceClient.DemoServiceClient dsc = null;
            DemoServiceSesAClient.DemoSvcSesAClient dssc = null;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac = null;
            string strMessage = "";

            switch (m_SelectedClient)
            {
                case "DemoServiceClient":
                    //dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);
                    //// tbHostTime.Text = UPDATE THE RICHTEXTBOX
                    ////dsc.GetHostTime().ToLongTimeString();

                    //while (!m_Stop.WaitOne(100))
                    //{
                    //    if (dsc == null)
                    //        dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

                    //    try
                    //    {
                    //        // dsc
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        MessageBox.Show(ex.Message);
                    //    }
                    //    finally
                    //    {
                    //        if (!m_ReuseProxy)
                    //        {
                    //            dsc.Close();
                    //            dsc = null;
                    //        }
                    //    }
                    //}

                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssc == null)
                            dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssc.IncrementCounter(1).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssc.Close();
                                dssc = null;
                            }
                        }

                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssnac == null)
                            dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssnac.IncrementCounter(1).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssnac.Close();
                                dssnac = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }


            if (dsc != null)
                dsc.Close();

            if (dssc != null)
                dssc.Close();

            if (dssnac != null)
                dssnac.Close();

        }


        public static void CallDecrement()
        {
            // DemoServiceClient.DemoServiceClient demo = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

            DemoServiceClient.DemoServiceClient dsc = null;
            DemoServiceSesAClient.DemoSvcSesAClient dssc = null;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac = null;
            string strMessage = "";

            switch (m_SelectedClient)
            {
                case "DemoServiceClient":
                    //dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);
                    //// tbHostTime.Text = UPDATE THE RICHTEXTBOX
                    ////dsc.GetHostTime().ToLongTimeString();

                    //while (!m_Stop.WaitOne(100))
                    //{
                    //    if (dsc == null)
                    //        dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

                    //    try
                    //    {
                    //        // dsc
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        MessageBox.Show(ex.Message);
                    //    }
                    //    finally
                    //    {
                    //        if (!m_ReuseProxy)
                    //        {
                    //            dsc.Close();
                    //            dsc = null;
                    //        }
                    //    }
                    //}

                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssc == null)
                            dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssc.DecrementCounter(1).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssc.Close();
                                dssc = null;
                            }
                        }

                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssnac == null)
                            dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssnac.DecrementCounter(1).ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssnac.Close();
                                dssnac = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }


            if (dsc != null)
                dsc.Close();

            if (dssc != null)
                dssc.Close();

            if (dssnac != null)
                dssnac.Close();

        }


        public static void CallCounter()
        {
            // DemoServiceClient.DemoServiceClient demo = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

            DemoServiceClient.DemoServiceClient dsc = null;
            DemoServiceSesAClient.DemoSvcSesAClient dssc = null;
            DemoServiceSesNAClient.DemoSvcSesNAClient dssnac = null;
            string strMessage = "";

            switch (m_SelectedClient)
            {
                case "DemoServiceClient":
                    //dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);
                    //// tbHostTime.Text = UPDATE THE RICHTEXTBOX
                    ////dsc.GetHostTime().ToLongTimeString();

                    //while (!m_Stop.WaitOne(100))
                    //{
                    //    if (dsc == null)
                    //        dsc = new DemoServiceClient.DemoServiceClient(m_SelectedEP);

                    //    try
                    //    {
                    //        // dsc
                    //    }
                    //    catch (Exception ex)
                    //    {
                    //        MessageBox.Show(ex.Message);
                    //    }
                    //    finally
                    //    {
                    //        if (!m_ReuseProxy)
                    //        {
                    //            dsc.Close();
                    //            dsc = null;
                    //        }
                    //    }
                    //}

                    break;

                case "DemoServiceSesAClient":
                    dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssc == null)
                            dssc = new DemoServiceSesAClient.DemoSvcSesAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssc.GetCounter().ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssc.Close();
                                dssc = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }

                    break;

                case "DemoServiceSesNAClient":
                    dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                    while (!m_Stop.WaitOne(100))
                    {
                        if (dssnac == null)
                            dssnac = new DemoServiceSesNAClient.DemoSvcSesNAClient(m_SelectedEP);

                        try
                        {
                            strMessage = dssnac.GetCounter().ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (!m_ReuseProxy)
                            {
                                dssnac.Close();
                                dssnac = null;
                            }
                        }
                        strMessage = GetThreadID() + " " + strMessage;
                        WriteOutput(strMessage);
                    }
                    break;

                default:
                    MessageBox.Show("No Client!");
                    break;
            }


            if (dsc != null)
                dsc.Close();

            if (dssc != null)
                dssc.Close();

            if (dssnac != null)
                dssnac.Close();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {            
            int iPing, iGetHostName, iGetHostTime, iIncrement, iDecrement, iCounter, iDelay, iTotalThreads;

            string str = cBoxClientList.SelectedItem.ToString();
            
            string[] sa = str.Split('(');
            m_SelectedClient = sa[0];
            m_SelectedEP = m_ClientEndPoints[cBoxClientList.SelectedIndex].m_EPName;
            


            if (m_cbReuseProxy.Checked)
                m_ReuseProxy = true;
            else
                m_ReuseProxy = false;

            m_Stop.Reset();

            if (!string.IsNullOrEmpty(tbDuration.Text))
                Int32.TryParse(tbDuration.Text, out m_Duration);
            else
                m_Duration = 0;


            if (!string.IsNullOrEmpty(tbPingThreads.Text))
                Int32.TryParse(tbPingThreads.Text, out iPing);
            else
                iPing = 0;

            if (!string.IsNullOrEmpty(tbHostNameThreads.Text))
                Int32.TryParse(tbHostNameThreads.Text, out iGetHostName);
            else
                iGetHostName = 0;

            if (!string.IsNullOrEmpty(tbHostTimeThreads.Text))
                Int32.TryParse(tbHostTimeThreads.Text, out iGetHostTime);
            else
                iGetHostTime = 0;

            if (!string.IsNullOrEmpty(tbIncrementThreads.Text))
                Int32.TryParse(tbIncrementThreads.Text, out iIncrement);
            else
                iIncrement = 0;

            if (!string.IsNullOrEmpty(tbDecrementThreads.Text))
                Int32.TryParse(tbDecrementThreads.Text, out iDecrement);
            else
                iDecrement = 0;

            if (!string.IsNullOrEmpty(tbCounterThreads.Text))
                Int32.TryParse(tbCounterThreads.Text, out iCounter);
            else
                iCounter = 0;

            if (!string.IsNullOrEmpty(tbDelayThreads.Text))
                Int32.TryParse(tbDelayThreads.Text, out iDelay);
            else
                iDelay = 0;

            iTotalThreads = iPing + iGetHostName + iGetHostTime + iIncrement + iDecrement + iCounter + iDelay;

            m_clientThreads = new Thread[iTotalThreads];

            for (int i = 0; i != iPing; i++)
            {
                m_clientThreads[i] = new Thread(new ThreadStart(CallPing));
                m_clientThreads[i].Start();
            }

            for (int i = iPing ; i != iPing + iGetHostName; i++)
            {
                m_clientThreads[i] = new Thread(new ThreadStart(CallHostName));
                m_clientThreads[i].Start();
            }

            for (int i = iPing + iGetHostName; i != iPing + iGetHostName + iGetHostTime; i++)
            {
                m_clientThreads[i] = new Thread(new ThreadStart(CallHostTime));
                m_clientThreads[i].Start();
            }

            for (int i = iPing + iGetHostName + iGetHostTime; i != iPing + iGetHostName + iGetHostTime + iIncrement; i++)
            {
                m_clientThreads[i] = new Thread(new ThreadStart(CallIncrement));
                m_clientThreads[i].Start();
            }

            for (int i = iPing + iGetHostName + iGetHostTime + iIncrement; i != iPing + iGetHostName + iGetHostTime + iIncrement + iDecrement; i++)
            {
                m_clientThreads[i] = new Thread(new ThreadStart(CallDecrement));
                m_clientThreads[i].Start();
            }

            for (int i = iPing + iGetHostName + iGetHostTime + iIncrement + iDecrement; i != iPing + iGetHostName + iGetHostTime + iIncrement + iDecrement + iCounter; i++)
            {
                m_clientThreads[i] = new Thread(new ThreadStart(CallCounter));
                m_clientThreads[i].Start();
            }

            for (int i = iPing + iGetHostName + iGetHostTime + iIncrement + iDecrement + iCounter; i != iPing + iGetHostName + iGetHostTime + iIncrement + iDecrement + iCounter + iDelay; i++)
            {
                m_clientThreads[i] = new Thread(new ThreadStart(CallDelay));
                m_clientThreads[i].Start();
            }

            //MessageBox.Show(iTotalThreads.ToString());

            Application.UseWaitCursor = true;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_Stop.Set();
            
            Application.UseWaitCursor = false;
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            rbOutput.Clear();
        }
    }



    public class EndPoint
    {
        public string m_EPName;
        public string m_ClientName;

        public EndPoint()
        {
            m_EPName = "";
            m_ClientName = "";
        }

        public EndPoint(string epName, string clientName)
        {
            m_EPName = epName;
            m_ClientName = clientName;
        }
    }

}
