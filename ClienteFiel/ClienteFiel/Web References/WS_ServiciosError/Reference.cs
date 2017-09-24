﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ClienteFiel.WS_ServiciosError {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosErrorSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Response))]
    public partial class ServiciosError : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private Autenticacion autenticacionValueField;
        
        private System.Threading.SendOrPostCallback crearErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPaginacionErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarPaginacionErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback contarBusquedaErrorOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarErrorOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosError() {
            this.Url = global::ClienteFiel.Properties.Settings.Default.ClienteFiel_WS_ServiciosError_ServiciosError;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public Autenticacion AutenticacionValue {
            get {
                return this.autenticacionValueField;
            }
            set {
                this.autenticacionValueField = value;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event crearErrorCompletedEventHandler crearErrorCompleted;
        
        /// <remarks/>
        public event editarErrorCompletedEventHandler editarErrorCompleted;
        
        /// <remarks/>
        public event buscarPrimeroErrorCompletedEventHandler buscarPrimeroErrorCompleted;
        
        /// <remarks/>
        public event buscarErrorCompletedEventHandler buscarErrorCompleted;
        
        /// <remarks/>
        public event buscarPaginacionErrorCompletedEventHandler buscarPaginacionErrorCompleted;
        
        /// <remarks/>
        public event listarErrorCompletedEventHandler listarErrorCompleted;
        
        /// <remarks/>
        public event listarPaginacionErrorCompletedEventHandler listarPaginacionErrorCompleted;
        
        /// <remarks/>
        public event contarBusquedaErrorCompletedEventHandler contarBusquedaErrorCompleted;
        
        /// <remarks/>
        public event eliminarErrorCompletedEventHandler eliminarErrorCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ErrorResponse crearError(Error obj) {
            object[] results = this.Invoke("crearError", new object[] {
                        obj});
            return ((ErrorResponse)(results[0]));
        }
        
        /// <remarks/>
        public void crearErrorAsync(Error obj) {
            this.crearErrorAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearErrorAsync(Error obj, object userState) {
            if ((this.crearErrorOperationCompleted == null)) {
                this.crearErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearErrorOperationCompleted);
            }
            this.InvokeAsync("crearError", new object[] {
                        obj}, this.crearErrorOperationCompleted, userState);
        }
        
        private void OncrearErrorOperationCompleted(object arg) {
            if ((this.crearErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearErrorCompleted(this, new crearErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ErrorResponse editarError(Error obj) {
            object[] results = this.Invoke("editarError", new object[] {
                        obj});
            return ((ErrorResponse)(results[0]));
        }
        
        /// <remarks/>
        public void editarErrorAsync(Error obj) {
            this.editarErrorAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarErrorAsync(Error obj, object userState) {
            if ((this.editarErrorOperationCompleted == null)) {
                this.editarErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarErrorOperationCompleted);
            }
            this.InvokeAsync("editarError", new object[] {
                        obj}, this.editarErrorOperationCompleted, userState);
        }
        
        private void OneditarErrorOperationCompleted(object arg) {
            if ((this.editarErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarErrorCompleted(this, new editarErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Error buscarPrimeroError(Error obj) {
            object[] results = this.Invoke("buscarPrimeroError", new object[] {
                        obj});
            return ((Error)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroErrorAsync(Error obj) {
            this.buscarPrimeroErrorAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroErrorAsync(Error obj, object userState) {
            if ((this.buscarPrimeroErrorOperationCompleted == null)) {
                this.buscarPrimeroErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroErrorOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroError", new object[] {
                        obj}, this.buscarPrimeroErrorOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroErrorOperationCompleted(object arg) {
            if ((this.buscarPrimeroErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroErrorCompleted(this, new buscarPrimeroErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Error[] buscarError(Error obj) {
            object[] results = this.Invoke("buscarError", new object[] {
                        obj});
            return ((Error[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarErrorAsync(Error obj) {
            this.buscarErrorAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarErrorAsync(Error obj, object userState) {
            if ((this.buscarErrorOperationCompleted == null)) {
                this.buscarErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarErrorOperationCompleted);
            }
            this.InvokeAsync("buscarError", new object[] {
                        obj}, this.buscarErrorOperationCompleted, userState);
        }
        
        private void OnbuscarErrorOperationCompleted(object arg) {
            if ((this.buscarErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarErrorCompleted(this, new buscarErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPaginacionError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Error[] buscarPaginacionError(Error obj, int pag, int numReg) {
            object[] results = this.Invoke("buscarPaginacionError", new object[] {
                        obj,
                        pag,
                        numReg});
            return ((Error[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarPaginacionErrorAsync(Error obj, int pag, int numReg) {
            this.buscarPaginacionErrorAsync(obj, pag, numReg, null);
        }
        
        /// <remarks/>
        public void buscarPaginacionErrorAsync(Error obj, int pag, int numReg, object userState) {
            if ((this.buscarPaginacionErrorOperationCompleted == null)) {
                this.buscarPaginacionErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPaginacionErrorOperationCompleted);
            }
            this.InvokeAsync("buscarPaginacionError", new object[] {
                        obj,
                        pag,
                        numReg}, this.buscarPaginacionErrorOperationCompleted, userState);
        }
        
        private void OnbuscarPaginacionErrorOperationCompleted(object arg) {
            if ((this.buscarPaginacionErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPaginacionErrorCompleted(this, new buscarPaginacionErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Error[] listarError() {
            object[] results = this.Invoke("listarError", new object[0]);
            return ((Error[])(results[0]));
        }
        
        /// <remarks/>
        public void listarErrorAsync() {
            this.listarErrorAsync(null);
        }
        
        /// <remarks/>
        public void listarErrorAsync(object userState) {
            if ((this.listarErrorOperationCompleted == null)) {
                this.listarErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarErrorOperationCompleted);
            }
            this.InvokeAsync("listarError", new object[0], this.listarErrorOperationCompleted, userState);
        }
        
        private void OnlistarErrorOperationCompleted(object arg) {
            if ((this.listarErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarErrorCompleted(this, new listarErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarPaginacionError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Error[] listarPaginacionError(int pag, int numReg) {
            object[] results = this.Invoke("listarPaginacionError", new object[] {
                        pag,
                        numReg});
            return ((Error[])(results[0]));
        }
        
        /// <remarks/>
        public void listarPaginacionErrorAsync(int pag, int numReg) {
            this.listarPaginacionErrorAsync(pag, numReg, null);
        }
        
        /// <remarks/>
        public void listarPaginacionErrorAsync(int pag, int numReg, object userState) {
            if ((this.listarPaginacionErrorOperationCompleted == null)) {
                this.listarPaginacionErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarPaginacionErrorOperationCompleted);
            }
            this.InvokeAsync("listarPaginacionError", new object[] {
                        pag,
                        numReg}, this.listarPaginacionErrorOperationCompleted, userState);
        }
        
        private void OnlistarPaginacionErrorOperationCompleted(object arg) {
            if ((this.listarPaginacionErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarPaginacionErrorCompleted(this, new listarPaginacionErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contarBusquedaError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int contarBusquedaError(Error obj) {
            object[] results = this.Invoke("contarBusquedaError", new object[] {
                        obj});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void contarBusquedaErrorAsync(Error obj) {
            this.contarBusquedaErrorAsync(obj, null);
        }
        
        /// <remarks/>
        public void contarBusquedaErrorAsync(Error obj, object userState) {
            if ((this.contarBusquedaErrorOperationCompleted == null)) {
                this.contarBusquedaErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontarBusquedaErrorOperationCompleted);
            }
            this.InvokeAsync("contarBusquedaError", new object[] {
                        obj}, this.contarBusquedaErrorOperationCompleted, userState);
        }
        
        private void OncontarBusquedaErrorOperationCompleted(object arg) {
            if ((this.contarBusquedaErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contarBusquedaErrorCompleted(this, new contarBusquedaErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarError", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ErrorResponse eliminarError(Error obj) {
            object[] results = this.Invoke("eliminarError", new object[] {
                        obj});
            return ((ErrorResponse)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarErrorAsync(Error obj) {
            this.eliminarErrorAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarErrorAsync(Error obj, object userState) {
            if ((this.eliminarErrorOperationCompleted == null)) {
                this.eliminarErrorOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarErrorOperationCompleted);
            }
            this.InvokeAsync("eliminarError", new object[] {
                        obj}, this.eliminarErrorOperationCompleted, userState);
        }
        
        private void OneliminarErrorOperationCompleted(object arg) {
            if ((this.eliminarErrorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarErrorCompleted(this, new eliminarErrorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class Autenticacion : System.Web.Services.Protocols.SoapHeader {
        
        private string usuarioField;
        
        private string contrasenaField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <comentarios/>
        public string usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
            }
        }
        
        /// <comentarios/>
        public string contrasena {
            get {
                return this.contrasenaField;
            }
            set {
                this.contrasenaField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class Response {
        
        private bool correctoField;
        
        private string errorField;
        
        private string numeroField;
        
        /// <comentarios/>
        public bool correcto {
            get {
                return this.correctoField;
            }
            set {
                this.correctoField = value;
            }
        }
        
        /// <comentarios/>
        public string error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <comentarios/>
        public string numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class ErrorResponse : Response {
        
        private Error objetoField;
        
        /// <comentarios/>
        public Error objeto {
            get {
                return this.objetoField;
            }
            set {
                this.objetoField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Error {
        
        private long iD_ERRORField;
        
        private string eRRORField;
        
        private string mENSAJE_PARA_USUARIOField;
        
        private string pOSIBLE_SOLUCIONField;
        
        private string cAMPO_DE_BUSQUEDAField;
        
        /// <comentarios/>
        public long ID_ERROR {
            get {
                return this.iD_ERRORField;
            }
            set {
                this.iD_ERRORField = value;
            }
        }
        
        /// <comentarios/>
        public string ERROR {
            get {
                return this.eRRORField;
            }
            set {
                this.eRRORField = value;
            }
        }
        
        /// <comentarios/>
        public string MENSAJE_PARA_USUARIO {
            get {
                return this.mENSAJE_PARA_USUARIOField;
            }
            set {
                this.mENSAJE_PARA_USUARIOField = value;
            }
        }
        
        /// <comentarios/>
        public string POSIBLE_SOLUCION {
            get {
                return this.pOSIBLE_SOLUCIONField;
            }
            set {
                this.pOSIBLE_SOLUCIONField = value;
            }
        }
        
        /// <comentarios/>
        public string CAMPO_DE_BUSQUEDA {
            get {
                return this.cAMPO_DE_BUSQUEDAField;
            }
            set {
                this.cAMPO_DE_BUSQUEDAField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void crearErrorCompletedEventHandler(object sender, crearErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ErrorResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ErrorResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void editarErrorCompletedEventHandler(object sender, editarErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ErrorResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ErrorResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarPrimeroErrorCompletedEventHandler(object sender, buscarPrimeroErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Error Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Error)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarErrorCompletedEventHandler(object sender, buscarErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Error[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Error[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarPaginacionErrorCompletedEventHandler(object sender, buscarPaginacionErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPaginacionErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPaginacionErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Error[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Error[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void listarErrorCompletedEventHandler(object sender, listarErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Error[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Error[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void listarPaginacionErrorCompletedEventHandler(object sender, listarPaginacionErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarPaginacionErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarPaginacionErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Error[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Error[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void contarBusquedaErrorCompletedEventHandler(object sender, contarBusquedaErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contarBusquedaErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contarBusquedaErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void eliminarErrorCompletedEventHandler(object sender, eliminarErrorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarErrorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarErrorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ErrorResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ErrorResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591