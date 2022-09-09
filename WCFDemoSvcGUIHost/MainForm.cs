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
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Threading;


namespace WCFDemoSvcGUIHost
{

    public class HostingInfo
    {
        public ManualResetEvent    m_waitEvent;
        public ServiceHost m_svcHost;
        public string m_svcName;

        public HostingInfo()
        {

        }

        public HostingInfo(ManualResetEvent mre, ServiceHost sh, string svcNm)
        {
            m_waitEvent = mre;
            m_svcHost = sh;
            m_svcName = svcNm;
        }
    }


    public partial class MainForm : Form
    {
        Dictionary<string, ServiceHost> m_serviceHosts = null;
        Dictionary<string, ManualResetEvent> m_serviceEvents = null;
        Dictionary<string, Type> m_serviceTypes = null;
        public MainForm()
        {
            InitializeComponent();
            PrepareControls();
        }

        public void PrepareControls()
        {
            List<string> sn = GetServiceNamesFromConfigFile();

            if (sn != null)
            {
                foreach (string s in sn)
                    cBoxServiceList.Items.Add(s);
            }

            sn.Clear();
            cBoxServiceList.SelectedIndex = 0;

            rbCMIPerCall.Checked = true;
            rbCMMultiple.Checked = true;

            int iMaxConcurrentSessions, iMaxConcurrentCalls, iMaxConcurrentInstances, iNumOfProc;

            iNumOfProc = System.Environment.ProcessorCount;
            iMaxConcurrentSessions = iNumOfProc * 100;
            iMaxConcurrentCalls = iNumOfProc * 16;
            iMaxConcurrentInstances = iMaxConcurrentCalls + iMaxConcurrentSessions;

            tbMaxConcurrentSessions.Text = iMaxConcurrentSessions.ToString();
            tbMaxConcurrentCalls.Text = iMaxConcurrentCalls.ToString();
            tbMaxConcurrentInstances.Text = iMaxConcurrentInstances.ToString();

            lvRunningServices.Columns.Add("Service Name");
            lvRunningServices.Columns.Add("Address");
            lvRunningServices.View = View.Details;            
        }

        public List<string> GetServiceNamesFromConfigFile()
        {
            List<string> ServiceNames = null;
            Configuration appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ServiceModelSectionGroup serviceModel = ServiceModelSectionGroup.GetSectionGroup(appConfig);
            ServicesSection services = serviceModel.Services;
            ServiceElementCollection sec = services.Services;

            if ( sec.Count > 0 )
            {
                ServiceNames = new List<string>();
                m_serviceTypes = new Dictionary<string, Type>();
                foreach (ServiceElement se in sec)
                {
                    ServiceNames.Add(se.Name);

                    Type t = Type.GetType(se.Name);
                    if (t == null)
                    {
                        string[] sa = se.Name.Split('.');
                        System.Reflection.Assembly a = System.Reflection.Assembly.LoadFrom(sa[0]+".dll");
                        t = a.GetType(se.Name);
                    }

                    m_serviceTypes.Add(se.Name, t);
                }
            }
            return ServiceNames;
        }

        private InstanceContextMode GetInstanceContextMode()
        {
            if (rbCMIPerCall.Checked)
                return InstanceContextMode.PerCall;

            if (rbCMIPerSession.Checked)
                return InstanceContextMode.PerSession;

            if (rbCMISingle.Checked)
                return InstanceContextMode.Single;

            return InstanceContextMode.Single;
        }

        private ConcurrencyMode GetConcurrencyMode()
        {
            if (rbCMMultiple.Checked)
                return ConcurrencyMode.Multiple;

            if (rbCMReentrant.Checked)
                return ConcurrencyMode.Reentrant;

            if (rbCMSingle.Checked)
                return ConcurrencyMode.Single;

            return ConcurrencyMode.Single;
        }

        public static void CreateNewHostingThread(object data)
        {
            HostingInfo hi = (HostingInfo)data;

            hi.m_svcHost.Open();
            hi.m_waitEvent.WaitOne();
            hi.m_svcHost.Close();
            hi.m_waitEvent.Close();
            hi.m_waitEvent.Dispose();
            
        }

        public HostingInfo PrepareHostingInfoAndFireSvcHstThread()
        {
            HostingInfo newHi = new HostingInfo();
            int iMaxConcurrentSessions, iMaxConcurrentCalls, iMaxConcurrentInstances;
            string svcName = cBoxServiceList.Items[cBoxServiceList.SelectedIndex].ToString();

            
            if (string.IsNullOrEmpty(svcName))
            {
                var strMessage = string.Format("Service name cannot be empty");
                MessageBox.Show(strMessage, "WCF GUI Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // First check whether any servicehosts are instantiated or not
            if (m_serviceHosts != null)
            {
                // If there are some service hosts running then check ours whether it is running or not
                if (m_serviceHosts.ContainsKey(svcName))
                {
                    var strMessage = string.Format("Service {0} is already running", svcName);
                    MessageBox.Show(strMessage, "WCF GUI Host", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }

            Application.UseWaitCursor = true;
            ServiceHost host = new ServiceHost(m_serviceTypes[svcName]);

            // Set InstanceContextMode & ConcurrencyMode
            var behavior = host.Description.Behaviors.Find<ServiceBehaviorAttribute>();
            behavior.InstanceContextMode = GetInstanceContextMode();
            behavior.ConcurrencyMode = GetConcurrencyMode();

            // Service Throttling Behaviors

            int.TryParse(tbMaxConcurrentCalls.Text, out iMaxConcurrentCalls);
            int.TryParse(tbMaxConcurrentInstances.Text, out iMaxConcurrentInstances);
            int.TryParse(tbMaxConcurrentSessions.Text, out iMaxConcurrentSessions);

            ServiceThrottlingBehavior throttleBehavior = new ServiceThrottlingBehavior
            {
                MaxConcurrentCalls = iMaxConcurrentCalls,
                MaxConcurrentInstances = iMaxConcurrentInstances,
                MaxConcurrentSessions = iMaxConcurrentSessions,
            };
            host.Description.Behaviors.Add(throttleBehavior);

            newHi.m_svcName = svcName;
            newHi.m_svcHost = host;

            newHi.m_waitEvent = new ManualResetEvent(false);
            
            Thread th = new Thread(CreateNewHostingThread);
            th.Start(newHi);

            return newHi;
        }
        
        private void btnStartService_Click(object sender, EventArgs e)
        {

            HostingInfo hi = null;

            hi = PrepareHostingInfoAndFireSvcHstThread();
            
            // Add the new host to the host dictionary
            if (m_serviceHosts == null)
                m_serviceHosts = new Dictionary<string, ServiceHost>();

            m_serviceHosts.Add(hi.m_svcName, hi.m_svcHost);

            // Add the wait event of the new hosting thread to the wait event dictionary
            if (m_serviceEvents == null)
                m_serviceEvents = new Dictionary<string, ManualResetEvent>();

            m_serviceEvents.Add(hi.m_svcName, hi.m_waitEvent);

            // C# MultiColumn Listbox
            // http://stackoverflow.com/questions/8477212/c-sharp-multicolumn-listbox

            ListViewItem lvi = new ListViewItem(hi.m_svcName);
            lvi.SubItems.Add( hi.m_svcHost.Description.Endpoints[0].Address.ToString());
            lvRunningServices.Items.Add(lvi);
            lvRunningServices.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            Application.UseWaitCursor = false;
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            if (lvRunningServices.SelectedItems.Count > 0)
            {
                Application.UseWaitCursor = true;
                
                foreach(ListViewItem lvi in lvRunningServices.SelectedItems)
                {
                    string svcName = lvi.SubItems[0].Text;
                    // m_serviceHosts[svcName].Close();
                    m_serviceEvents[svcName].Set();
                    
                    m_serviceEvents[svcName].Close();
                    // Remove the stopped service from ListView and ServiceHost Dictionary
                    lvi.Remove();
                    m_serviceHosts.Remove(svcName);
                    m_serviceEvents.Remove(svcName);

                    // Remove the ManualResetEvent for this servicehost thread
                    //m_serviceEvents[svcName]
                    // m_serviceEvents.remove
                }

                Application.UseWaitCursor = false;
            }
        }
    }
}
