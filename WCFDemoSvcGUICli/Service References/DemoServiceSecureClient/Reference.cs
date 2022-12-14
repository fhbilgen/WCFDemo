//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFDemoSvcGUICli.DemoServiceSecureClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DemoServiceSecureClient.IDemoServiceSecure")]
    public interface IDemoServiceSecure {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoServiceSecure/GetHostName", ReplyAction="http://tempuri.org/IDemoServiceSecure/GetHostNameResponse")]
        string GetHostName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoServiceSecure/GetHostName", ReplyAction="http://tempuri.org/IDemoServiceSecure/GetHostNameResponse")]
        System.Threading.Tasks.Task<string> GetHostNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoServiceSecure/Echo", ReplyAction="http://tempuri.org/IDemoServiceSecure/EchoResponse")]
        string Echo(string strInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoServiceSecure/Echo", ReplyAction="http://tempuri.org/IDemoServiceSecure/EchoResponse")]
        System.Threading.Tasks.Task<string> EchoAsync(string strInput);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoServiceSecure/Ping", ReplyAction="http://tempuri.org/IDemoServiceSecure/PingResponse")]
        string Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoServiceSecure/Ping", ReplyAction="http://tempuri.org/IDemoServiceSecure/PingResponse")]
        System.Threading.Tasks.Task<string> PingAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoServiceSecure/GetHostTime", ReplyAction="http://tempuri.org/IDemoServiceSecure/GetHostTimeResponse")]
        System.DateTime GetHostTime();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoServiceSecure/GetHostTime", ReplyAction="http://tempuri.org/IDemoServiceSecure/GetHostTimeResponse")]
        System.Threading.Tasks.Task<System.DateTime> GetHostTimeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceSecureChannel : WCFDemoSvcGUICli.DemoServiceSecureClient.IDemoServiceSecure, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoServiceSecureClient : System.ServiceModel.ClientBase<WCFDemoSvcGUICli.DemoServiceSecureClient.IDemoServiceSecure>, WCFDemoSvcGUICli.DemoServiceSecureClient.IDemoServiceSecure {
        
        public DemoServiceSecureClient() {
        }
        
        public DemoServiceSecureClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoServiceSecureClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceSecureClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceSecureClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetHostName() {
            return base.Channel.GetHostName();
        }
        
        public System.Threading.Tasks.Task<string> GetHostNameAsync() {
            return base.Channel.GetHostNameAsync();
        }
        
        public string Echo(string strInput) {
            return base.Channel.Echo(strInput);
        }
        
        public System.Threading.Tasks.Task<string> EchoAsync(string strInput) {
            return base.Channel.EchoAsync(strInput);
        }
        
        public string Ping() {
            return base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task<string> PingAsync() {
            return base.Channel.PingAsync();
        }
        
        public System.DateTime GetHostTime() {
            return base.Channel.GetHostTime();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> GetHostTimeAsync() {
            return base.Channel.GetHostTimeAsync();
        }
    }
}
