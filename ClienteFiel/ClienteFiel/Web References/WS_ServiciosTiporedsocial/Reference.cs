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

namespace ClienteFiel.WS_ServiciosTiporedsocial {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosTiporedsocialSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Response))]
    public partial class ServiciosTiporedsocial : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private Autenticacion autenticacionValueField;
        
        private System.Threading.SendOrPostCallback crearTiporedsocialOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarTiporedsocialOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroTiporedsocialOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarTiporedsocialOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPaginacionTiporedsocialOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarTiporedsocialOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarPaginacionTiporedsocialOperationCompleted;
        
        private System.Threading.SendOrPostCallback contarBusquedaTiporedsocialOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarTiporedsocialOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosTiporedsocial() {
            this.Url = global::ClienteFiel.Properties.Settings.Default.ClienteFiel_WS_ServiciosTiporedsocial_ServiciosTiporedsocial;
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
        public event crearTiporedsocialCompletedEventHandler crearTiporedsocialCompleted;
        
        /// <remarks/>
        public event editarTiporedsocialCompletedEventHandler editarTiporedsocialCompleted;
        
        /// <remarks/>
        public event buscarPrimeroTiporedsocialCompletedEventHandler buscarPrimeroTiporedsocialCompleted;
        
        /// <remarks/>
        public event buscarTiporedsocialCompletedEventHandler buscarTiporedsocialCompleted;
        
        /// <remarks/>
        public event buscarPaginacionTiporedsocialCompletedEventHandler buscarPaginacionTiporedsocialCompleted;
        
        /// <remarks/>
        public event listarTiporedsocialCompletedEventHandler listarTiporedsocialCompleted;
        
        /// <remarks/>
        public event listarPaginacionTiporedsocialCompletedEventHandler listarPaginacionTiporedsocialCompleted;
        
        /// <remarks/>
        public event contarBusquedaTiporedsocialCompletedEventHandler contarBusquedaTiporedsocialCompleted;
        
        /// <remarks/>
        public event eliminarTiporedsocialCompletedEventHandler eliminarTiporedsocialCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TiporedsocialResponse crearTiporedsocial(Tiporedsocial obj) {
            object[] results = this.Invoke("crearTiporedsocial", new object[] {
                        obj});
            return ((TiporedsocialResponse)(results[0]));
        }
        
        /// <remarks/>
        public void crearTiporedsocialAsync(Tiporedsocial obj) {
            this.crearTiporedsocialAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearTiporedsocialAsync(Tiporedsocial obj, object userState) {
            if ((this.crearTiporedsocialOperationCompleted == null)) {
                this.crearTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("crearTiporedsocial", new object[] {
                        obj}, this.crearTiporedsocialOperationCompleted, userState);
        }
        
        private void OncrearTiporedsocialOperationCompleted(object arg) {
            if ((this.crearTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearTiporedsocialCompleted(this, new crearTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TiporedsocialResponse editarTiporedsocial(Tiporedsocial obj) {
            object[] results = this.Invoke("editarTiporedsocial", new object[] {
                        obj});
            return ((TiporedsocialResponse)(results[0]));
        }
        
        /// <remarks/>
        public void editarTiporedsocialAsync(Tiporedsocial obj) {
            this.editarTiporedsocialAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarTiporedsocialAsync(Tiporedsocial obj, object userState) {
            if ((this.editarTiporedsocialOperationCompleted == null)) {
                this.editarTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("editarTiporedsocial", new object[] {
                        obj}, this.editarTiporedsocialOperationCompleted, userState);
        }
        
        private void OneditarTiporedsocialOperationCompleted(object arg) {
            if ((this.editarTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarTiporedsocialCompleted(this, new editarTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tiporedsocial buscarPrimeroTiporedsocial(Tiporedsocial obj) {
            object[] results = this.Invoke("buscarPrimeroTiporedsocial", new object[] {
                        obj});
            return ((Tiporedsocial)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroTiporedsocialAsync(Tiporedsocial obj) {
            this.buscarPrimeroTiporedsocialAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroTiporedsocialAsync(Tiporedsocial obj, object userState) {
            if ((this.buscarPrimeroTiporedsocialOperationCompleted == null)) {
                this.buscarPrimeroTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroTiporedsocial", new object[] {
                        obj}, this.buscarPrimeroTiporedsocialOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroTiporedsocialOperationCompleted(object arg) {
            if ((this.buscarPrimeroTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroTiporedsocialCompleted(this, new buscarPrimeroTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tiporedsocial[] buscarTiporedsocial(Tiporedsocial obj) {
            object[] results = this.Invoke("buscarTiporedsocial", new object[] {
                        obj});
            return ((Tiporedsocial[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarTiporedsocialAsync(Tiporedsocial obj) {
            this.buscarTiporedsocialAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarTiporedsocialAsync(Tiporedsocial obj, object userState) {
            if ((this.buscarTiporedsocialOperationCompleted == null)) {
                this.buscarTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("buscarTiporedsocial", new object[] {
                        obj}, this.buscarTiporedsocialOperationCompleted, userState);
        }
        
        private void OnbuscarTiporedsocialOperationCompleted(object arg) {
            if ((this.buscarTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarTiporedsocialCompleted(this, new buscarTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPaginacionTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tiporedsocial[] buscarPaginacionTiporedsocial(Tiporedsocial obj, int pag, int numReg) {
            object[] results = this.Invoke("buscarPaginacionTiporedsocial", new object[] {
                        obj,
                        pag,
                        numReg});
            return ((Tiporedsocial[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarPaginacionTiporedsocialAsync(Tiporedsocial obj, int pag, int numReg) {
            this.buscarPaginacionTiporedsocialAsync(obj, pag, numReg, null);
        }
        
        /// <remarks/>
        public void buscarPaginacionTiporedsocialAsync(Tiporedsocial obj, int pag, int numReg, object userState) {
            if ((this.buscarPaginacionTiporedsocialOperationCompleted == null)) {
                this.buscarPaginacionTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPaginacionTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("buscarPaginacionTiporedsocial", new object[] {
                        obj,
                        pag,
                        numReg}, this.buscarPaginacionTiporedsocialOperationCompleted, userState);
        }
        
        private void OnbuscarPaginacionTiporedsocialOperationCompleted(object arg) {
            if ((this.buscarPaginacionTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPaginacionTiporedsocialCompleted(this, new buscarPaginacionTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tiporedsocial[] listarTiporedsocial() {
            object[] results = this.Invoke("listarTiporedsocial", new object[0]);
            return ((Tiporedsocial[])(results[0]));
        }
        
        /// <remarks/>
        public void listarTiporedsocialAsync() {
            this.listarTiporedsocialAsync(null);
        }
        
        /// <remarks/>
        public void listarTiporedsocialAsync(object userState) {
            if ((this.listarTiporedsocialOperationCompleted == null)) {
                this.listarTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("listarTiporedsocial", new object[0], this.listarTiporedsocialOperationCompleted, userState);
        }
        
        private void OnlistarTiporedsocialOperationCompleted(object arg) {
            if ((this.listarTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarTiporedsocialCompleted(this, new listarTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarPaginacionTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tiporedsocial[] listarPaginacionTiporedsocial(int pag, int numReg) {
            object[] results = this.Invoke("listarPaginacionTiporedsocial", new object[] {
                        pag,
                        numReg});
            return ((Tiporedsocial[])(results[0]));
        }
        
        /// <remarks/>
        public void listarPaginacionTiporedsocialAsync(int pag, int numReg) {
            this.listarPaginacionTiporedsocialAsync(pag, numReg, null);
        }
        
        /// <remarks/>
        public void listarPaginacionTiporedsocialAsync(int pag, int numReg, object userState) {
            if ((this.listarPaginacionTiporedsocialOperationCompleted == null)) {
                this.listarPaginacionTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarPaginacionTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("listarPaginacionTiporedsocial", new object[] {
                        pag,
                        numReg}, this.listarPaginacionTiporedsocialOperationCompleted, userState);
        }
        
        private void OnlistarPaginacionTiporedsocialOperationCompleted(object arg) {
            if ((this.listarPaginacionTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarPaginacionTiporedsocialCompleted(this, new listarPaginacionTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contarBusquedaTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int contarBusquedaTiporedsocial(Tiporedsocial obj) {
            object[] results = this.Invoke("contarBusquedaTiporedsocial", new object[] {
                        obj});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void contarBusquedaTiporedsocialAsync(Tiporedsocial obj) {
            this.contarBusquedaTiporedsocialAsync(obj, null);
        }
        
        /// <remarks/>
        public void contarBusquedaTiporedsocialAsync(Tiporedsocial obj, object userState) {
            if ((this.contarBusquedaTiporedsocialOperationCompleted == null)) {
                this.contarBusquedaTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontarBusquedaTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("contarBusquedaTiporedsocial", new object[] {
                        obj}, this.contarBusquedaTiporedsocialOperationCompleted, userState);
        }
        
        private void OncontarBusquedaTiporedsocialOperationCompleted(object arg) {
            if ((this.contarBusquedaTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contarBusquedaTiporedsocialCompleted(this, new contarBusquedaTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarTiporedsocial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TiporedsocialResponse eliminarTiporedsocial(Tiporedsocial obj) {
            object[] results = this.Invoke("eliminarTiporedsocial", new object[] {
                        obj});
            return ((TiporedsocialResponse)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarTiporedsocialAsync(Tiporedsocial obj) {
            this.eliminarTiporedsocialAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarTiporedsocialAsync(Tiporedsocial obj, object userState) {
            if ((this.eliminarTiporedsocialOperationCompleted == null)) {
                this.eliminarTiporedsocialOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarTiporedsocialOperationCompleted);
            }
            this.InvokeAsync("eliminarTiporedsocial", new object[] {
                        obj}, this.eliminarTiporedsocialOperationCompleted, userState);
        }
        
        private void OneliminarTiporedsocialOperationCompleted(object arg) {
            if ((this.eliminarTiporedsocialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarTiporedsocialCompleted(this, new eliminarTiporedsocialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TiporedsocialResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class Response {
        
        private bool correctoField;
        
        private string errorField;
        
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
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TiporedsocialResponse : Response {
        
        private Tiporedsocial objetoField;
        
        /// <comentarios/>
        public Tiporedsocial objeto {
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
    public partial class Tiporedsocial {
        
        private long iD_TIPO_RED_SOCIALField;
        
        private long iD_IMAGENField;
        
        private string nOM_TIPO_RED_SOCIALField;
        
        /// <comentarios/>
        public long ID_TIPO_RED_SOCIAL {
            get {
                return this.iD_TIPO_RED_SOCIALField;
            }
            set {
                this.iD_TIPO_RED_SOCIALField = value;
            }
        }
        
        /// <comentarios/>
        public long ID_IMAGEN {
            get {
                return this.iD_IMAGENField;
            }
            set {
                this.iD_IMAGENField = value;
            }
        }
        
        /// <comentarios/>
        public string NOM_TIPO_RED_SOCIAL {
            get {
                return this.nOM_TIPO_RED_SOCIALField;
            }
            set {
                this.nOM_TIPO_RED_SOCIALField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void crearTiporedsocialCompletedEventHandler(object sender, crearTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TiporedsocialResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TiporedsocialResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void editarTiporedsocialCompletedEventHandler(object sender, editarTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TiporedsocialResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TiporedsocialResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarPrimeroTiporedsocialCompletedEventHandler(object sender, buscarPrimeroTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tiporedsocial Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tiporedsocial)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarTiporedsocialCompletedEventHandler(object sender, buscarTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tiporedsocial[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tiporedsocial[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarPaginacionTiporedsocialCompletedEventHandler(object sender, buscarPaginacionTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPaginacionTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPaginacionTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tiporedsocial[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tiporedsocial[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void listarTiporedsocialCompletedEventHandler(object sender, listarTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tiporedsocial[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tiporedsocial[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void listarPaginacionTiporedsocialCompletedEventHandler(object sender, listarPaginacionTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarPaginacionTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarPaginacionTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tiporedsocial[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tiporedsocial[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void contarBusquedaTiporedsocialCompletedEventHandler(object sender, contarBusquedaTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contarBusquedaTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contarBusquedaTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void eliminarTiporedsocialCompletedEventHandler(object sender, eliminarTiporedsocialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarTiporedsocialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarTiporedsocialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TiporedsocialResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TiporedsocialResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591