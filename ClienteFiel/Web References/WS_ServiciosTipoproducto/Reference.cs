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

namespace ClienteFiel.WS_ServiciosTipoproducto {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosTipoproductoSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Response))]
    public partial class ServiciosTipoproducto : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private Autenticacion autenticacionValueField;
        
        private System.Threading.SendOrPostCallback crearTipoproductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarTipoproductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroTipoproductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarTipoproductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPaginacionTipoproductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarTipoproductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarPaginacionTipoproductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback contarBusquedaTipoproductoOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarTipoproductoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosTipoproducto() {
            this.Url = global::ClienteFiel.Properties.Settings.Default.ClienteFiel_WS_ServiciosTipoproducto_ServiciosTipoproducto;
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
        public event crearTipoproductoCompletedEventHandler crearTipoproductoCompleted;
        
        /// <remarks/>
        public event editarTipoproductoCompletedEventHandler editarTipoproductoCompleted;
        
        /// <remarks/>
        public event buscarPrimeroTipoproductoCompletedEventHandler buscarPrimeroTipoproductoCompleted;
        
        /// <remarks/>
        public event buscarTipoproductoCompletedEventHandler buscarTipoproductoCompleted;
        
        /// <remarks/>
        public event buscarPaginacionTipoproductoCompletedEventHandler buscarPaginacionTipoproductoCompleted;
        
        /// <remarks/>
        public event listarTipoproductoCompletedEventHandler listarTipoproductoCompleted;
        
        /// <remarks/>
        public event listarPaginacionTipoproductoCompletedEventHandler listarPaginacionTipoproductoCompleted;
        
        /// <remarks/>
        public event contarBusquedaTipoproductoCompletedEventHandler contarBusquedaTipoproductoCompleted;
        
        /// <remarks/>
        public event eliminarTipoproductoCompletedEventHandler eliminarTipoproductoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoProductoResponse crearTipoproducto(Tipoproducto obj) {
            object[] results = this.Invoke("crearTipoproducto", new object[] {
                        obj});
            return ((TipoProductoResponse)(results[0]));
        }
        
        /// <remarks/>
        public void crearTipoproductoAsync(Tipoproducto obj) {
            this.crearTipoproductoAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearTipoproductoAsync(Tipoproducto obj, object userState) {
            if ((this.crearTipoproductoOperationCompleted == null)) {
                this.crearTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearTipoproductoOperationCompleted);
            }
            this.InvokeAsync("crearTipoproducto", new object[] {
                        obj}, this.crearTipoproductoOperationCompleted, userState);
        }
        
        private void OncrearTipoproductoOperationCompleted(object arg) {
            if ((this.crearTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearTipoproductoCompleted(this, new crearTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoProductoResponse editarTipoproducto(Tipoproducto obj) {
            object[] results = this.Invoke("editarTipoproducto", new object[] {
                        obj});
            return ((TipoProductoResponse)(results[0]));
        }
        
        /// <remarks/>
        public void editarTipoproductoAsync(Tipoproducto obj) {
            this.editarTipoproductoAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarTipoproductoAsync(Tipoproducto obj, object userState) {
            if ((this.editarTipoproductoOperationCompleted == null)) {
                this.editarTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarTipoproductoOperationCompleted);
            }
            this.InvokeAsync("editarTipoproducto", new object[] {
                        obj}, this.editarTipoproductoOperationCompleted, userState);
        }
        
        private void OneditarTipoproductoOperationCompleted(object arg) {
            if ((this.editarTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarTipoproductoCompleted(this, new editarTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoproducto buscarPrimeroTipoproducto(Tipoproducto obj) {
            object[] results = this.Invoke("buscarPrimeroTipoproducto", new object[] {
                        obj});
            return ((Tipoproducto)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroTipoproductoAsync(Tipoproducto obj) {
            this.buscarPrimeroTipoproductoAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroTipoproductoAsync(Tipoproducto obj, object userState) {
            if ((this.buscarPrimeroTipoproductoOperationCompleted == null)) {
                this.buscarPrimeroTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroTipoproductoOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroTipoproducto", new object[] {
                        obj}, this.buscarPrimeroTipoproductoOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroTipoproductoOperationCompleted(object arg) {
            if ((this.buscarPrimeroTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroTipoproductoCompleted(this, new buscarPrimeroTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoproducto[] buscarTipoproducto(Tipoproducto obj) {
            object[] results = this.Invoke("buscarTipoproducto", new object[] {
                        obj});
            return ((Tipoproducto[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarTipoproductoAsync(Tipoproducto obj) {
            this.buscarTipoproductoAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarTipoproductoAsync(Tipoproducto obj, object userState) {
            if ((this.buscarTipoproductoOperationCompleted == null)) {
                this.buscarTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarTipoproductoOperationCompleted);
            }
            this.InvokeAsync("buscarTipoproducto", new object[] {
                        obj}, this.buscarTipoproductoOperationCompleted, userState);
        }
        
        private void OnbuscarTipoproductoOperationCompleted(object arg) {
            if ((this.buscarTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarTipoproductoCompleted(this, new buscarTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPaginacionTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoproducto[] buscarPaginacionTipoproducto(Tipoproducto obj, int pag, int numReg) {
            object[] results = this.Invoke("buscarPaginacionTipoproducto", new object[] {
                        obj,
                        pag,
                        numReg});
            return ((Tipoproducto[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarPaginacionTipoproductoAsync(Tipoproducto obj, int pag, int numReg) {
            this.buscarPaginacionTipoproductoAsync(obj, pag, numReg, null);
        }
        
        /// <remarks/>
        public void buscarPaginacionTipoproductoAsync(Tipoproducto obj, int pag, int numReg, object userState) {
            if ((this.buscarPaginacionTipoproductoOperationCompleted == null)) {
                this.buscarPaginacionTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPaginacionTipoproductoOperationCompleted);
            }
            this.InvokeAsync("buscarPaginacionTipoproducto", new object[] {
                        obj,
                        pag,
                        numReg}, this.buscarPaginacionTipoproductoOperationCompleted, userState);
        }
        
        private void OnbuscarPaginacionTipoproductoOperationCompleted(object arg) {
            if ((this.buscarPaginacionTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPaginacionTipoproductoCompleted(this, new buscarPaginacionTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoproducto[] listarTipoproducto() {
            object[] results = this.Invoke("listarTipoproducto", new object[0]);
            return ((Tipoproducto[])(results[0]));
        }
        
        /// <remarks/>
        public void listarTipoproductoAsync() {
            this.listarTipoproductoAsync(null);
        }
        
        /// <remarks/>
        public void listarTipoproductoAsync(object userState) {
            if ((this.listarTipoproductoOperationCompleted == null)) {
                this.listarTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarTipoproductoOperationCompleted);
            }
            this.InvokeAsync("listarTipoproducto", new object[0], this.listarTipoproductoOperationCompleted, userState);
        }
        
        private void OnlistarTipoproductoOperationCompleted(object arg) {
            if ((this.listarTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarTipoproductoCompleted(this, new listarTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarPaginacionTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoproducto[] listarPaginacionTipoproducto(int pag, int numReg) {
            object[] results = this.Invoke("listarPaginacionTipoproducto", new object[] {
                        pag,
                        numReg});
            return ((Tipoproducto[])(results[0]));
        }
        
        /// <remarks/>
        public void listarPaginacionTipoproductoAsync(int pag, int numReg) {
            this.listarPaginacionTipoproductoAsync(pag, numReg, null);
        }
        
        /// <remarks/>
        public void listarPaginacionTipoproductoAsync(int pag, int numReg, object userState) {
            if ((this.listarPaginacionTipoproductoOperationCompleted == null)) {
                this.listarPaginacionTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarPaginacionTipoproductoOperationCompleted);
            }
            this.InvokeAsync("listarPaginacionTipoproducto", new object[] {
                        pag,
                        numReg}, this.listarPaginacionTipoproductoOperationCompleted, userState);
        }
        
        private void OnlistarPaginacionTipoproductoOperationCompleted(object arg) {
            if ((this.listarPaginacionTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarPaginacionTipoproductoCompleted(this, new listarPaginacionTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contarBusquedaTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int contarBusquedaTipoproducto(Tipoproducto obj) {
            object[] results = this.Invoke("contarBusquedaTipoproducto", new object[] {
                        obj});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void contarBusquedaTipoproductoAsync(Tipoproducto obj) {
            this.contarBusquedaTipoproductoAsync(obj, null);
        }
        
        /// <remarks/>
        public void contarBusquedaTipoproductoAsync(Tipoproducto obj, object userState) {
            if ((this.contarBusquedaTipoproductoOperationCompleted == null)) {
                this.contarBusquedaTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontarBusquedaTipoproductoOperationCompleted);
            }
            this.InvokeAsync("contarBusquedaTipoproducto", new object[] {
                        obj}, this.contarBusquedaTipoproductoOperationCompleted, userState);
        }
        
        private void OncontarBusquedaTipoproductoOperationCompleted(object arg) {
            if ((this.contarBusquedaTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contarBusquedaTipoproductoCompleted(this, new contarBusquedaTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarTipoproducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoProductoResponse eliminarTipoproducto(Tipoproducto obj) {
            object[] results = this.Invoke("eliminarTipoproducto", new object[] {
                        obj});
            return ((TipoProductoResponse)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarTipoproductoAsync(Tipoproducto obj) {
            this.eliminarTipoproductoAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarTipoproductoAsync(Tipoproducto obj, object userState) {
            if ((this.eliminarTipoproductoOperationCompleted == null)) {
                this.eliminarTipoproductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarTipoproductoOperationCompleted);
            }
            this.InvokeAsync("eliminarTipoproducto", new object[] {
                        obj}, this.eliminarTipoproductoOperationCompleted, userState);
        }
        
        private void OneliminarTipoproductoOperationCompleted(object arg) {
            if ((this.eliminarTipoproductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarTipoproductoCompleted(this, new eliminarTipoproductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TipoProductoResponse))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TipoProductoResponse : Response {
        
        private Tipoproducto objetoField;
        
        /// <comentarios/>
        public Tipoproducto objeto {
            get {
                return this.objetoField;
            }
            set {
                this.objetoField = value;
            }
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Tipoproducto {
        
        private long iD_TIPO_PRODUCTOField;
        
        private string nOM_TIPO_PRODUCTOField;
        
        /// <comentarios/>
        public long ID_TIPO_PRODUCTO {
            get {
                return this.iD_TIPO_PRODUCTOField;
            }
            set {
                this.iD_TIPO_PRODUCTOField = value;
            }
        }
        
        /// <comentarios/>
        public string NOM_TIPO_PRODUCTO {
            get {
                return this.nOM_TIPO_PRODUCTOField;
            }
            set {
                this.nOM_TIPO_PRODUCTOField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void crearTipoproductoCompletedEventHandler(object sender, crearTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoProductoResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoProductoResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void editarTipoproductoCompletedEventHandler(object sender, editarTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoProductoResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoProductoResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void buscarPrimeroTipoproductoCompletedEventHandler(object sender, buscarPrimeroTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoproducto Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoproducto)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void buscarTipoproductoCompletedEventHandler(object sender, buscarTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoproducto[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoproducto[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void buscarPaginacionTipoproductoCompletedEventHandler(object sender, buscarPaginacionTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPaginacionTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPaginacionTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoproducto[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoproducto[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void listarTipoproductoCompletedEventHandler(object sender, listarTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoproducto[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoproducto[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void listarPaginacionTipoproductoCompletedEventHandler(object sender, listarPaginacionTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarPaginacionTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarPaginacionTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoproducto[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoproducto[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void contarBusquedaTipoproductoCompletedEventHandler(object sender, contarBusquedaTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contarBusquedaTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contarBusquedaTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void eliminarTipoproductoCompletedEventHandler(object sender, eliminarTipoproductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarTipoproductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarTipoproductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoProductoResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoProductoResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591