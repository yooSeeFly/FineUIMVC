﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FineUIMvc.PumpMVC.FaMenService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FaMenService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetCommand", ReplyAction="http://tempuri.org/IService1/SetCommandResponse")]
        bool SetCommand(string name, string text, string id, string type, string dtu, string FSchemeID, string FPLCAddress, string FRate, string slaveId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetCommand", ReplyAction="http://tempuri.org/IService1/SetCommandResponse")]
        System.Threading.Tasks.Task<bool> SetCommandAsync(string name, string text, string id, string type, string dtu, string FSchemeID, string FPLCAddress, string FRate, string slaveId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : FineUIMvc.PumpMVC.FaMenService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<FineUIMvc.PumpMVC.FaMenService.IService1>, FineUIMvc.PumpMVC.FaMenService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SetCommand(string name, string text, string id, string type, string dtu, string FSchemeID, string FPLCAddress, string FRate, string slaveId) {
            return base.Channel.SetCommand(name, text, id, type, dtu, FSchemeID, FPLCAddress, FRate, slaveId);
        }
        
        public System.Threading.Tasks.Task<bool> SetCommandAsync(string name, string text, string id, string type, string dtu, string FSchemeID, string FPLCAddress, string FRate, string slaveId) {
            return base.Channel.SetCommandAsync(name, text, id, type, dtu, FSchemeID, FPLCAddress, FRate, slaveId);
        }
    }
}
