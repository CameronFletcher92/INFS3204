﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prac5Client.Prac5ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Prac5ServiceReference.IPrac5Service")]
    public interface IPrac5Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrac5Service/GetStringBack", ReplyAction="http://tempuri.org/IPrac5Service/GetStringBackResponse")]
        string GetStringBack();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrac5Service/AnagramsFinder", ReplyAction="http://tempuri.org/IPrac5Service/AnagramsFinderResponse")]
        string[][] AnagramsFinder(string[] words);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrac5Service/ASCIIFilter", ReplyAction="http://tempuri.org/IPrac5Service/ASCIIFilterResponse")]
        System.Collections.Generic.KeyValuePair<string, int>[][] ASCIIFilter(string wordsString, int filter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrac5ServiceChannel : Prac5Client.Prac5ServiceReference.IPrac5Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Prac5ServiceClient : System.ServiceModel.ClientBase<Prac5Client.Prac5ServiceReference.IPrac5Service>, Prac5Client.Prac5ServiceReference.IPrac5Service {
        
        public Prac5ServiceClient() {
        }
        
        public Prac5ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Prac5ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Prac5ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Prac5ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetStringBack() {
            return base.Channel.GetStringBack();
        }
        
        public string[][] AnagramsFinder(string[] words) {
            return base.Channel.AnagramsFinder(words);
        }
        
        public System.Collections.Generic.KeyValuePair<string, int>[][] ASCIIFilter(string wordsString, int filter) {
            return base.Channel.ASCIIFilter(wordsString, filter);
        }
    }
}
