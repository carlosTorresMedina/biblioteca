﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace labLaboratorio.ServiceReference {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.ServiceBDSoap")]
    public interface ServiceBDSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EjecutarConsulta", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet EjecutarConsulta(string sql, string nombreTabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EjecutarConsulta", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> EjecutarConsultaAsync(string sql, string nombreTabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ejecutarDML", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool ejecutarDML(string DML);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ejecutarDML", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ejecutarDMLAsync(string DML);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceBDSoapChannel : labLaboratorio.ServiceReference.ServiceBDSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBDSoapClient : System.ServiceModel.ClientBase<labLaboratorio.ServiceReference.ServiceBDSoap>, labLaboratorio.ServiceReference.ServiceBDSoap {
        
        public ServiceBDSoapClient() {
        }
        
        public ServiceBDSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBDSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBDSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBDSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet EjecutarConsulta(string sql, string nombreTabla) {
            return base.Channel.EjecutarConsulta(sql, nombreTabla);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> EjecutarConsultaAsync(string sql, string nombreTabla) {
            return base.Channel.EjecutarConsultaAsync(sql, nombreTabla);
        }
        
        public bool ejecutarDML(string DML) {
            return base.Channel.ejecutarDML(DML);
        }
        
        public System.Threading.Tasks.Task<bool> ejecutarDMLAsync(string DML) {
            return base.Channel.ejecutarDMLAsync(DML);
        }
    }
}
