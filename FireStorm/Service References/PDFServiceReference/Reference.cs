﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 5.0.61118.0
// 
namespace FireStorm.PDFServiceReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/PDFService")]
    public partial class CompositeType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool BoolValueField;
        
        private string StringValueField;
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PDFServiceReference.IPDFServiceWriter")]
    public interface IPDFServiceWriter {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPDFServiceWriter/GetData", ReplyAction="http://tempuri.org/IPDFServiceWriter/GetDataResponse")]
        System.IAsyncResult BeginGetData(int value, System.AsyncCallback callback, object asyncState);
        
        string EndGetData(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPDFServiceWriter/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IPDFServiceWriter/GetDataUsingDataContractResponse")]
        System.IAsyncResult BeginGetDataUsingDataContract(FireStorm.PDFServiceReference.CompositeType composite, System.AsyncCallback callback, object asyncState);
        
        FireStorm.PDFServiceReference.CompositeType EndGetDataUsingDataContract(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPDFServiceWriterChannel : FireStorm.PDFServiceReference.IPDFServiceWriter, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public FireStorm.PDFServiceReference.CompositeType Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((FireStorm.PDFServiceReference.CompositeType)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PDFServiceWriterClient : System.ServiceModel.ClientBase<FireStorm.PDFServiceReference.IPDFServiceWriter>, FireStorm.PDFServiceReference.IPDFServiceWriter {
        
        private BeginOperationDelegate onBeginGetDataDelegate;
        
        private EndOperationDelegate onEndGetDataDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetDataUsingDataContractDelegate;
        
        private EndOperationDelegate onEndGetDataUsingDataContractDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataUsingDataContractCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public PDFServiceWriterClient() {
        }
        
        public PDFServiceWriterClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PDFServiceWriterClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PDFServiceWriterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PDFServiceWriterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetDataCompletedEventArgs> GetDataCompleted;
        
        public event System.EventHandler<GetDataUsingDataContractCompletedEventArgs> GetDataUsingDataContractCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult FireStorm.PDFServiceReference.IPDFServiceWriter.BeginGetData(int value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetData(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string FireStorm.PDFServiceReference.IPDFServiceWriter.EndGetData(System.IAsyncResult result) {
            return base.Channel.EndGetData(result);
        }
        
        private System.IAsyncResult OnBeginGetData(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int value = ((int)(inValues[0]));
            return ((FireStorm.PDFServiceReference.IPDFServiceWriter)(this)).BeginGetData(value, callback, asyncState);
        }
        
        private object[] OnEndGetData(System.IAsyncResult result) {
            string retVal = ((FireStorm.PDFServiceReference.IPDFServiceWriter)(this)).EndGetData(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataCompleted(object state) {
            if ((this.GetDataCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataAsync(int value) {
            this.GetDataAsync(value, null);
        }
        
        public void GetDataAsync(int value, object userState) {
            if ((this.onBeginGetDataDelegate == null)) {
                this.onBeginGetDataDelegate = new BeginOperationDelegate(this.OnBeginGetData);
            }
            if ((this.onEndGetDataDelegate == null)) {
                this.onEndGetDataDelegate = new EndOperationDelegate(this.OnEndGetData);
            }
            if ((this.onGetDataCompletedDelegate == null)) {
                this.onGetDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataDelegate, new object[] {
                        value}, this.onEndGetDataDelegate, this.onGetDataCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult FireStorm.PDFServiceReference.IPDFServiceWriter.BeginGetDataUsingDataContract(FireStorm.PDFServiceReference.CompositeType composite, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetDataUsingDataContract(composite, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FireStorm.PDFServiceReference.CompositeType FireStorm.PDFServiceReference.IPDFServiceWriter.EndGetDataUsingDataContract(System.IAsyncResult result) {
            return base.Channel.EndGetDataUsingDataContract(result);
        }
        
        private System.IAsyncResult OnBeginGetDataUsingDataContract(object[] inValues, System.AsyncCallback callback, object asyncState) {
            FireStorm.PDFServiceReference.CompositeType composite = ((FireStorm.PDFServiceReference.CompositeType)(inValues[0]));
            return ((FireStorm.PDFServiceReference.IPDFServiceWriter)(this)).BeginGetDataUsingDataContract(composite, callback, asyncState);
        }
        
        private object[] OnEndGetDataUsingDataContract(System.IAsyncResult result) {
            FireStorm.PDFServiceReference.CompositeType retVal = ((FireStorm.PDFServiceReference.IPDFServiceWriter)(this)).EndGetDataUsingDataContract(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataUsingDataContractCompleted(object state) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataUsingDataContractAsync(FireStorm.PDFServiceReference.CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        public void GetDataUsingDataContractAsync(FireStorm.PDFServiceReference.CompositeType composite, object userState) {
            if ((this.onBeginGetDataUsingDataContractDelegate == null)) {
                this.onBeginGetDataUsingDataContractDelegate = new BeginOperationDelegate(this.OnBeginGetDataUsingDataContract);
            }
            if ((this.onEndGetDataUsingDataContractDelegate == null)) {
                this.onEndGetDataUsingDataContractDelegate = new EndOperationDelegate(this.OnEndGetDataUsingDataContract);
            }
            if ((this.onGetDataUsingDataContractCompletedDelegate == null)) {
                this.onGetDataUsingDataContractCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataUsingDataContractDelegate, new object[] {
                        composite}, this.onEndGetDataUsingDataContractDelegate, this.onGetDataUsingDataContractCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override FireStorm.PDFServiceReference.IPDFServiceWriter CreateChannel() {
            return new PDFServiceWriterClientChannel(this);
        }
        
        private class PDFServiceWriterClientChannel : ChannelBase<FireStorm.PDFServiceReference.IPDFServiceWriter>, FireStorm.PDFServiceReference.IPDFServiceWriter {
            
            public PDFServiceWriterClientChannel(System.ServiceModel.ClientBase<FireStorm.PDFServiceReference.IPDFServiceWriter> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetData(int value, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = value;
                System.IAsyncResult _result = base.BeginInvoke("GetData", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetData(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetData", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetDataUsingDataContract(FireStorm.PDFServiceReference.CompositeType composite, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = composite;
                System.IAsyncResult _result = base.BeginInvoke("GetDataUsingDataContract", _args, callback, asyncState);
                return _result;
            }
            
            public FireStorm.PDFServiceReference.CompositeType EndGetDataUsingDataContract(System.IAsyncResult result) {
                object[] _args = new object[0];
                FireStorm.PDFServiceReference.CompositeType _result = ((FireStorm.PDFServiceReference.CompositeType)(base.EndInvoke("GetDataUsingDataContract", _args, result)));
                return _result;
            }
        }
    }
}
