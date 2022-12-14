//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFAppLogging.CIAService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="StringCollection", Namespace="http://nlog-project.org/ws/", ItemName="l")]
    [System.SerializableAttribute()]
    public class StringCollection : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/CIAService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CIAService.ICiaService")]
    public interface ICiaService {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://nlog-project.org/ws/) of message ProcessLogMessagesRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://nlog-project.org/ws/ILogReceiverServer/ProcessLogMessages", ReplyAction="http://nlog-project.org/ws/ILogReceiverServer/ProcessLogMessagesResponse")]
        WPFAppLogging.CIAService.ProcessLogMessagesResponse ProcessLogMessages(WPFAppLogging.CIAService.ProcessLogMessagesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://nlog-project.org/ws/ILogReceiverServer/ProcessLogMessages", ReplyAction="http://nlog-project.org/ws/ILogReceiverServer/ProcessLogMessagesResponse")]
        System.Threading.Tasks.Task<WPFAppLogging.CIAService.ProcessLogMessagesResponse> ProcessLogMessagesAsync(WPFAppLogging.CIAService.ProcessLogMessagesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICiaService/GetData", ReplyAction="http://tempuri.org/ICiaService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICiaService/GetData", ReplyAction="http://tempuri.org/ICiaService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICiaService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICiaService/GetDataUsingDataContractResponse")]
        WPFAppLogging.CIAService.CompositeType GetDataUsingDataContract(WPFAppLogging.CIAService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICiaService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICiaService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WPFAppLogging.CIAService.CompositeType> GetDataUsingDataContractAsync(WPFAppLogging.CIAService.CompositeType composite);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessLogMessages", WrapperNamespace="http://nlog-project.org/ws/", IsWrapped=true)]
    public partial class ProcessLogMessagesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://nlog-project.org/ws/", Order=0)]
        public NLog.LogReceiverService.NLogEvents events;
        
        public ProcessLogMessagesRequest() {
        }
        
        public ProcessLogMessagesRequest(NLog.LogReceiverService.NLogEvents events) {
            this.events = events;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ProcessLogMessagesResponse", WrapperNamespace="http://nlog-project.org/ws/", IsWrapped=true)]
    public partial class ProcessLogMessagesResponse {
        
        public ProcessLogMessagesResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICiaServiceChannel : WPFAppLogging.CIAService.ICiaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CiaServiceClient : System.ServiceModel.ClientBase<WPFAppLogging.CIAService.ICiaService>, WPFAppLogging.CIAService.ICiaService {
        
        public CiaServiceClient() {
        }
        
        public CiaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CiaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CiaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CiaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WPFAppLogging.CIAService.ProcessLogMessagesResponse WPFAppLogging.CIAService.ICiaService.ProcessLogMessages(WPFAppLogging.CIAService.ProcessLogMessagesRequest request) {
            return base.Channel.ProcessLogMessages(request);
        }
        
        public void ProcessLogMessages(NLog.LogReceiverService.NLogEvents events) {
            WPFAppLogging.CIAService.ProcessLogMessagesRequest inValue = new WPFAppLogging.CIAService.ProcessLogMessagesRequest();
            inValue.events = events;
            WPFAppLogging.CIAService.ProcessLogMessagesResponse retVal = ((WPFAppLogging.CIAService.ICiaService)(this)).ProcessLogMessages(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WPFAppLogging.CIAService.ProcessLogMessagesResponse> WPFAppLogging.CIAService.ICiaService.ProcessLogMessagesAsync(WPFAppLogging.CIAService.ProcessLogMessagesRequest request) {
            return base.Channel.ProcessLogMessagesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WPFAppLogging.CIAService.ProcessLogMessagesResponse> ProcessLogMessagesAsync(NLog.LogReceiverService.NLogEvents events) {
            WPFAppLogging.CIAService.ProcessLogMessagesRequest inValue = new WPFAppLogging.CIAService.ProcessLogMessagesRequest();
            inValue.events = events;
            return ((WPFAppLogging.CIAService.ICiaService)(this)).ProcessLogMessagesAsync(inValue);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WPFAppLogging.CIAService.CompositeType GetDataUsingDataContract(WPFAppLogging.CIAService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WPFAppLogging.CIAService.CompositeType> GetDataUsingDataContractAsync(WPFAppLogging.CIAService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
