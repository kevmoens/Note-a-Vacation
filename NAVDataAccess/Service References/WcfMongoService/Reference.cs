﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAVDataAccess.WcfMongoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfMongoService.IRequest")]
    public interface IRequest {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRequest/Query", ReplyAction="http://tempuri.org/IRequest/QueryResponse")]
        System.IAsyncResult BeginQuery(string Table, string value, System.AsyncCallback callback, object asyncState);
        
        string EndQuery(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRequest/QueryXML", ReplyAction="http://tempuri.org/IRequest/QueryXMLResponse")]
        System.IAsyncResult BeginQueryXML(string Table, string value, System.AsyncCallback callback, object asyncState);
        
        string EndQueryXML(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRequest/InsertOne", ReplyAction="http://tempuri.org/IRequest/InsertOneResponse")]
        System.IAsyncResult BeginInsertOne(string Table, string value, System.AsyncCallback callback, object asyncState);
        
        string EndInsertOne(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IRequest/Update", ReplyAction="http://tempuri.org/IRequest/UpdateResponse")]
        System.IAsyncResult BeginUpdate(string Table, string Command, string query, string value, System.AsyncCallback callback, object asyncState);
        
        string EndUpdate(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRequestChannel : NAVDataAccess.WcfMongoService.IRequest, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public QueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class QueryXMLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public QueryXMLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class InsertOneCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public InsertOneCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class UpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class RequestClient : System.ServiceModel.ClientBase<NAVDataAccess.WcfMongoService.IRequest>, NAVDataAccess.WcfMongoService.IRequest {
        
        private BeginOperationDelegate onBeginQueryDelegate;
        
        private EndOperationDelegate onEndQueryDelegate;
        
        private System.Threading.SendOrPostCallback onQueryCompletedDelegate;
        
        private BeginOperationDelegate onBeginQueryXMLDelegate;
        
        private EndOperationDelegate onEndQueryXMLDelegate;
        
        private System.Threading.SendOrPostCallback onQueryXMLCompletedDelegate;
        
        private BeginOperationDelegate onBeginInsertOneDelegate;
        
        private EndOperationDelegate onEndInsertOneDelegate;
        
        private System.Threading.SendOrPostCallback onInsertOneCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateDelegate;
        
        private EndOperationDelegate onEndUpdateDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public RequestClient() : 
                base(RequestClient.GetDefaultBinding(), RequestClient.GetDefaultEndpointAddress()) {
        }
        
        public RequestClient(EndpointConfiguration endpointConfiguration) : 
                base(RequestClient.GetBindingForEndpoint(endpointConfiguration), RequestClient.GetEndpointAddress(endpointConfiguration)) {
        }
        
        public RequestClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(RequestClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
        }
        
        public RequestClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(RequestClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
        }
        
        public RequestClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<QueryCompletedEventArgs> QueryCompleted;
        
        public event System.EventHandler<QueryXMLCompletedEventArgs> QueryXMLCompleted;
        
        public event System.EventHandler<InsertOneCompletedEventArgs> InsertOneCompleted;
        
        public event System.EventHandler<UpdateCompletedEventArgs> UpdateCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult NAVDataAccess.WcfMongoService.IRequest.BeginQuery(string Table, string value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginQuery(Table, value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string NAVDataAccess.WcfMongoService.IRequest.EndQuery(System.IAsyncResult result) {
            return base.Channel.EndQuery(result);
        }
        
        private System.IAsyncResult OnBeginQuery(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string Table = ((string)(inValues[0]));
            string value = ((string)(inValues[1]));
            return ((NAVDataAccess.WcfMongoService.IRequest)(this)).BeginQuery(Table, value, callback, asyncState);
        }
        
        private object[] OnEndQuery(System.IAsyncResult result) {
            string retVal = ((NAVDataAccess.WcfMongoService.IRequest)(this)).EndQuery(result);
            return new object[] {
                    retVal};
        }
        
        private void OnQueryCompleted(object state) {
            if ((this.QueryCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.QueryCompleted(this, new QueryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void QueryAsync(string Table, string value) {
            this.QueryAsync(Table, value, null);
        }
        
        public void QueryAsync(string Table, string value, object userState) {
            if ((this.onBeginQueryDelegate == null)) {
                this.onBeginQueryDelegate = new BeginOperationDelegate(this.OnBeginQuery);
            }
            if ((this.onEndQueryDelegate == null)) {
                this.onEndQueryDelegate = new EndOperationDelegate(this.OnEndQuery);
            }
            if ((this.onQueryCompletedDelegate == null)) {
                this.onQueryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnQueryCompleted);
            }
            base.InvokeAsync(this.onBeginQueryDelegate, new object[] {
                        Table,
                        value}, this.onEndQueryDelegate, this.onQueryCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult NAVDataAccess.WcfMongoService.IRequest.BeginQueryXML(string Table, string value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginQueryXML(Table, value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string NAVDataAccess.WcfMongoService.IRequest.EndQueryXML(System.IAsyncResult result) {
            return base.Channel.EndQueryXML(result);
        }
        
        private System.IAsyncResult OnBeginQueryXML(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string Table = ((string)(inValues[0]));
            string value = ((string)(inValues[1]));
            return ((NAVDataAccess.WcfMongoService.IRequest)(this)).BeginQueryXML(Table, value, callback, asyncState);
        }
        
        private object[] OnEndQueryXML(System.IAsyncResult result) {
            string retVal = ((NAVDataAccess.WcfMongoService.IRequest)(this)).EndQueryXML(result);
            return new object[] {
                    retVal};
        }
        
        private void OnQueryXMLCompleted(object state) {
            if ((this.QueryXMLCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.QueryXMLCompleted(this, new QueryXMLCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void QueryXMLAsync(string Table, string value) {
            this.QueryXMLAsync(Table, value, null);
        }
        
        public void QueryXMLAsync(string Table, string value, object userState) {
            if ((this.onBeginQueryXMLDelegate == null)) {
                this.onBeginQueryXMLDelegate = new BeginOperationDelegate(this.OnBeginQueryXML);
            }
            if ((this.onEndQueryXMLDelegate == null)) {
                this.onEndQueryXMLDelegate = new EndOperationDelegate(this.OnEndQueryXML);
            }
            if ((this.onQueryXMLCompletedDelegate == null)) {
                this.onQueryXMLCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnQueryXMLCompleted);
            }
            base.InvokeAsync(this.onBeginQueryXMLDelegate, new object[] {
                        Table,
                        value}, this.onEndQueryXMLDelegate, this.onQueryXMLCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult NAVDataAccess.WcfMongoService.IRequest.BeginInsertOne(string Table, string value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginInsertOne(Table, value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string NAVDataAccess.WcfMongoService.IRequest.EndInsertOne(System.IAsyncResult result) {
            return base.Channel.EndInsertOne(result);
        }
        
        private System.IAsyncResult OnBeginInsertOne(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string Table = ((string)(inValues[0]));
            string value = ((string)(inValues[1]));
            return ((NAVDataAccess.WcfMongoService.IRequest)(this)).BeginInsertOne(Table, value, callback, asyncState);
        }
        
        private object[] OnEndInsertOne(System.IAsyncResult result) {
            string retVal = ((NAVDataAccess.WcfMongoService.IRequest)(this)).EndInsertOne(result);
            return new object[] {
                    retVal};
        }
        
        private void OnInsertOneCompleted(object state) {
            if ((this.InsertOneCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.InsertOneCompleted(this, new InsertOneCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void InsertOneAsync(string Table, string value) {
            this.InsertOneAsync(Table, value, null);
        }
        
        public void InsertOneAsync(string Table, string value, object userState) {
            if ((this.onBeginInsertOneDelegate == null)) {
                this.onBeginInsertOneDelegate = new BeginOperationDelegate(this.OnBeginInsertOne);
            }
            if ((this.onEndInsertOneDelegate == null)) {
                this.onEndInsertOneDelegate = new EndOperationDelegate(this.OnEndInsertOne);
            }
            if ((this.onInsertOneCompletedDelegate == null)) {
                this.onInsertOneCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnInsertOneCompleted);
            }
            base.InvokeAsync(this.onBeginInsertOneDelegate, new object[] {
                        Table,
                        value}, this.onEndInsertOneDelegate, this.onInsertOneCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult NAVDataAccess.WcfMongoService.IRequest.BeginUpdate(string Table, string Command, string query, string value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdate(Table, Command, query, value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string NAVDataAccess.WcfMongoService.IRequest.EndUpdate(System.IAsyncResult result) {
            return base.Channel.EndUpdate(result);
        }
        
        private System.IAsyncResult OnBeginUpdate(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string Table = ((string)(inValues[0]));
            string Command = ((string)(inValues[1]));
            string query = ((string)(inValues[2]));
            string value = ((string)(inValues[3]));
            return ((NAVDataAccess.WcfMongoService.IRequest)(this)).BeginUpdate(Table, Command, query, value, callback, asyncState);
        }
        
        private object[] OnEndUpdate(System.IAsyncResult result) {
            string retVal = ((NAVDataAccess.WcfMongoService.IRequest)(this)).EndUpdate(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUpdateCompleted(object state) {
            if ((this.UpdateCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateCompleted(this, new UpdateCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateAsync(string Table, string Command, string query, string value) {
            this.UpdateAsync(Table, Command, query, value, null);
        }
        
        public void UpdateAsync(string Table, string Command, string query, string value, object userState) {
            if ((this.onBeginUpdateDelegate == null)) {
                this.onBeginUpdateDelegate = new BeginOperationDelegate(this.OnBeginUpdate);
            }
            if ((this.onEndUpdateDelegate == null)) {
                this.onEndUpdateDelegate = new EndOperationDelegate(this.OnEndUpdate);
            }
            if ((this.onUpdateCompletedDelegate == null)) {
                this.onUpdateCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateDelegate, new object[] {
                        Table,
                        Command,
                        query,
                        value}, this.onEndUpdateDelegate, this.onUpdateCompletedDelegate, userState);
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
        
        protected override NAVDataAccess.WcfMongoService.IRequest CreateChannel() {
            return new RequestClientChannel(this);
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IRequest)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IRequest)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:52801/MongoRequest.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return RequestClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IRequest);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return RequestClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IRequest);
        }
        
        private class RequestClientChannel : ChannelBase<NAVDataAccess.WcfMongoService.IRequest>, NAVDataAccess.WcfMongoService.IRequest {
            
            public RequestClientChannel(System.ServiceModel.ClientBase<NAVDataAccess.WcfMongoService.IRequest> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginQuery(string Table, string value, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = Table;
                _args[1] = value;
                System.IAsyncResult _result = base.BeginInvoke("Query", _args, callback, asyncState);
                return _result;
            }
            
            public string EndQuery(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Query", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginQueryXML(string Table, string value, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = Table;
                _args[1] = value;
                System.IAsyncResult _result = base.BeginInvoke("QueryXML", _args, callback, asyncState);
                return _result;
            }
            
            public string EndQueryXML(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("QueryXML", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginInsertOne(string Table, string value, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = Table;
                _args[1] = value;
                System.IAsyncResult _result = base.BeginInvoke("InsertOne", _args, callback, asyncState);
                return _result;
            }
            
            public string EndInsertOne(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("InsertOne", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginUpdate(string Table, string Command, string query, string value, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[4];
                _args[0] = Table;
                _args[1] = Command;
                _args[2] = query;
                _args[3] = value;
                System.IAsyncResult _result = base.BeginInvoke("Update", _args, callback, asyncState);
                return _result;
            }
            
            public string EndUpdate(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Update", _args, result)));
                return _result;
            }
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IRequest,
        }
    }
}
