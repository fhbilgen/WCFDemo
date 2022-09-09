using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDemoAzure
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DemoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DemoService.svc or DemoService.svc.cs at the Solution Explorer and start debugging.
    #region DemoService
    public class DemoService : IDemoService
    {
        public string GetHostName()
        {
            return System.Environment.MachineName.ToString();
        }

        public string Echo(string strInput)
        {
            return strInput + " " + strInput;
        }

        public string Ping()
        {
            return "Ping method returns from " + System.Environment.MachineName.ToString() + " at " + DateTime.Now.ToShortTimeString();
        }

        public DateTime GetHostTime()
        {
            System.Threading.Thread.Sleep(5000);
            return DateTime.Now;
        }

        public void CauseException()
        {
            throw new System.Exception("CausesException threw this exception");
        }

        public Sex GuessGender(PersonInfo pi)
        {
            if (pi.Name[0] == 'A')
                return Sex.Female;
            else
                return Sex.Male;
        }

        public PersonInfo GetPerson()
        {
            PersonInfo pi = new PersonInfo();
            pi.Name = "ABC";
            pi.Surname = "XYZ";
            pi.Age = 50;

            return pi;
        }

        public void Delay(int Duration)
        {
            System.Threading.Thread.Sleep(Duration);
        }
    }
    #endregion DemoService


    #region DemoServiceSecure
    public class DemoServiceSecure : IDemoServiceSecure
    {
        public string GetHostName()
        {
            return System.Environment.MachineName.ToString();
        }

        public string Echo(string strInput)
        {
            return strInput + " " + strInput;
        }

        public string Ping()
        {
            return "Ping method returns from " + System.Environment.MachineName.ToString() + " at " + DateTime.Now.ToShortTimeString();
        }

        public DateTime GetHostTime()
        {
            System.Threading.Thread.Sleep(5000);
            return DateTime.Now;
        }

        public void CauseException()
        {
            throw new System.Exception("CausesException threw this exception");
        }

        public void Delay(int Duration)
        {
            System.Threading.Thread.Sleep(Duration);
        }
    }
    #endregion DemoService

    #region DemoServiceSesReq
    public class DemoServiceSesReq : IDemoSvcSesReq
    {
        int m_Counter;

        public DemoServiceSesReq()
        {
            m_Counter = 0;
        }
        public string GetHostName()
        {
            return System.Environment.MachineName.ToString();
        }

        public string Echo(string strInput)
        {
            return strInput + " " + strInput;
        }

        public string Ping()
        {
            return "Ping method returns from " + System.Environment.MachineName.ToString() + " at " + DateTime.Now.ToShortTimeString();
        }

        public DateTime GetHostTime()
        {
            System.Threading.Thread.Sleep(5000);
            return DateTime.Now;
        }

        public void CauseException()
        {
            throw new System.Exception("CausesException threw this exception");
        }

        public int IncrementCounter(int IncrementAmount)
        {
            m_Counter += IncrementAmount;

            return m_Counter;
        }

        public int GetCounter()
        {
            return m_Counter;
        }

        public int DecrementCounter(int DecrementAmount)
        {
            m_Counter -= DecrementAmount;
            return m_Counter;
        }

        public void Delay(int Duration)
        {
            System.Threading.Thread.Sleep(Duration);
        }
    }
    #endregion DemoServiceSesReq

    #region DemoServiceSesNA
    public class DemoServiceSesNA : IDemoSvcSesNA
    {
        int m_Counter;

        public DemoServiceSesNA()
        {
            m_Counter = 0;
        }
        public string GetHostName()
        {
            return System.Environment.MachineName.ToString();
        }

        public string Echo(string strInput)
        {
            return strInput + " " + strInput;
        }

        public string Ping()
        {
            return "Ping method returns from " + System.Environment.MachineName.ToString() + " at " + DateTime.Now.ToShortTimeString();
        }

        public DateTime GetHostTime()
        {
            System.Threading.Thread.Sleep(5000);
            return DateTime.Now;
        }

        public void CauseException()
        {
            throw new System.Exception("CausesException threw this exception");
        }

        public int IncrementCounter(int IncrementAmount)
        {
            m_Counter += IncrementAmount;

            return m_Counter;
        }

        public int GetCounter()
        {
            return m_Counter;
        }

        public int DecrementCounter(int DecrementAmount)
        {
            m_Counter -= DecrementAmount;
            return m_Counter;
        }

        public void Delay(int Duration)
        {
            System.Threading.Thread.Sleep(Duration);
        }
    }
    #endregion DemoServiceSesNA 

    #region DemoServiceSesA
    public class DemoServiceSesA : IDemoSvcSesA
    {
        int m_Counter;

        public DemoServiceSesA()
        {
            m_Counter = 0;
        }
        public string GetHostName()
        {
            return System.Environment.MachineName.ToString();
        }

        public string Echo(string strInput)
        {
            return strInput + " " + strInput;
        }

        public string Ping()
        {
            return "Ping method returns from " + System.Environment.MachineName.ToString() + " at " + DateTime.Now.ToShortTimeString();
        }

        public DateTime GetHostTime()
        {
            System.Threading.Thread.Sleep(5000);
            return DateTime.Now;
        }

        public void CauseException()
        {
            throw new System.Exception("CausesException threw this exception");
        }

        public int IncrementCounter(int IncrementAmount)
        {
            m_Counter += IncrementAmount;

            return m_Counter;
        }

        public int GetCounter()
        {
            return m_Counter;
        }

        public int DecrementCounter(int DecrementAmount)
        {
            m_Counter -= DecrementAmount;
            return m_Counter;
        }

        public void Delay(int Duration)
        {
            System.Threading.Thread.Sleep(Duration);
        }
    }

    #endregion DemoServiceSesA
}
