using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDemoAzure
{
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        string GetHostName();

        [OperationContract]
        string Echo(string strInput);

        [OperationContract]
        string Ping();

        [OperationContract]
        DateTime GetHostTime();

        [OperationContract]
        void CauseException();

        [OperationContract]
        Sex GuessGender(PersonInfo pi);

        [OperationContract]
        //[System.ServiceModel.XmlSerializerFormat]
        PersonInfo GetPerson();

        [OperationContract]
        void Delay(int Duration);
    }

    [ServiceContract]
    public interface IDemoServiceSecure
    {
        [OperationContract]
        string GetHostName();

        [OperationContract]
        string Echo(string strInput);

        [OperationContract]
        string Ping();

        [OperationContract]
        DateTime GetHostTime();

        [OperationContract]
        void Delay(int Duration);

    }

    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IDemoSvcSesA
    {
        [OperationContract]
        string GetHostName();

        [OperationContract]
        string Echo(string strInput);

        [OperationContract]
        string Ping();

        [OperationContract]
        DateTime GetHostTime();

        [OperationContract]
        int IncrementCounter(int IncrementAmount);

        [OperationContract]
        int GetCounter();

        [OperationContract]
        int DecrementCounter(int DecrementAmount);

        [OperationContract]
        void Delay(int Duration);
    }

    [ServiceContract(SessionMode = SessionMode.NotAllowed)]
    public interface IDemoSvcSesNA
    {
        [OperationContract]
        string GetHostName();

        [OperationContract]
        string Echo(string strInput);

        [OperationContract]
        string Ping();

        [OperationContract]
        DateTime GetHostTime();

        [OperationContract]
        int IncrementCounter(int IncrementAmount);

        [OperationContract]
        int GetCounter();

        [OperationContract]
        int DecrementCounter(int DecrementAmount);

        [OperationContract]
        void Delay(int Duration);
    }

    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IDemoSvcSesReq
    {
        [OperationContract]
        string GetHostName();

        [OperationContract]
        string Echo(string strInput);

        [OperationContract]
        string Ping();

        [OperationContract]
        DateTime GetHostTime();

        [OperationContract]
        int IncrementCounter(int IncrementAmount);

        [OperationContract]
        int GetCounter();

        [OperationContract]
        int DecrementCounter(int DecrementAmount);

        [OperationContract]
        void Delay(int Duration);
    }
}
