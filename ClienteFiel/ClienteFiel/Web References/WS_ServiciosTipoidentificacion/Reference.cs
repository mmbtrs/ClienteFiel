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

namespace ClienteFiel.WS_ServiciosTipoidentificacion {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosTipoidentificacionSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Response))]
    public partial class ServiciosTipoidentificacion : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private Autenticacion autenticacionValueField;
        
        private System.Threading.SendOrPostCallback crearTipoidentificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarTipoidentificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroTipoidentificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarTipoidentificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPaginacionTipoidentificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarTipoidentificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarPaginacionTipoidentificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback contarBusquedaTipoidentificacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarTipoidentificacionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosTipoidentificacion() {
            this.Url = global::ClienteFiel.Properties.Settings.Default.ClienteFiel_WS_ServiciosTipoidentificacion_ServiciosTipoidentificacion;
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
        public event crearTipoidentificacionCompletedEventHandler crearTipoidentificacionCompleted;
        
        /// <remarks/>
        public event editarTipoidentificacionCompletedEventHandler editarTipoidentificacionCompleted;
        
        /// <remarks/>
        public event buscarPrimeroTipoidentificacionCompletedEventHandler buscarPrimeroTipoidentificacionCompleted;
        
        /// <remarks/>
        public event buscarTipoidentificacionCompletedEventHandler buscarTipoidentificacionCompleted;
        
        /// <remarks/>
        public event buscarPaginacionTipoidentificacionCompletedEventHandler buscarPaginacionTipoidentificacionCompleted;
        
        /// <remarks/>
        public event listarTipoidentificacionCompletedEventHandler listarTipoidentificacionCompleted;
        
        /// <remarks/>
        public event listarPaginacionTipoidentificacionCompletedEventHandler listarPaginacionTipoidentificacionCompleted;
        
        /// <remarks/>
        public event contarBusquedaTipoidentificacionCompletedEventHandler contarBusquedaTipoidentificacionCompleted;
        
        /// <remarks/>
        public event eliminarTipoidentificacionCompletedEventHandler eliminarTipoidentificacionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoidentificacionResponse crearTipoidentificacion(Tipoidentificacion obj) {
            object[] results = this.Invoke("crearTipoidentificacion", new object[] {
                        obj});
            return ((TipoidentificacionResponse)(results[0]));
        }
        
        /// <remarks/>
        public void crearTipoidentificacionAsync(Tipoidentificacion obj) {
            this.crearTipoidentificacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearTipoidentificacionAsync(Tipoidentificacion obj, object userState) {
            if ((this.crearTipoidentificacionOperationCompleted == null)) {
                this.crearTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("crearTipoidentificacion", new object[] {
                        obj}, this.crearTipoidentificacionOperationCompleted, userState);
        }
        
        private void OncrearTipoidentificacionOperationCompleted(object arg) {
            if ((this.crearTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearTipoidentificacionCompleted(this, new crearTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoidentificacionResponse editarTipoidentificacion(Tipoidentificacion obj) {
            object[] results = this.Invoke("editarTipoidentificacion", new object[] {
                        obj});
            return ((TipoidentificacionResponse)(results[0]));
        }
        
        /// <remarks/>
        public void editarTipoidentificacionAsync(Tipoidentificacion obj) {
            this.editarTipoidentificacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarTipoidentificacionAsync(Tipoidentificacion obj, object userState) {
            if ((this.editarTipoidentificacionOperationCompleted == null)) {
                this.editarTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("editarTipoidentificacion", new object[] {
                        obj}, this.editarTipoidentificacionOperationCompleted, userState);
        }
        
        private void OneditarTipoidentificacionOperationCompleted(object arg) {
            if ((this.editarTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarTipoidentificacionCompleted(this, new editarTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoidentificacion buscarPrimeroTipoidentificacion(Tipoidentificacion obj) {
            object[] results = this.Invoke("buscarPrimeroTipoidentificacion", new object[] {
                        obj});
            return ((Tipoidentificacion)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroTipoidentificacionAsync(Tipoidentificacion obj) {
            this.buscarPrimeroTipoidentificacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroTipoidentificacionAsync(Tipoidentificacion obj, object userState) {
            if ((this.buscarPrimeroTipoidentificacionOperationCompleted == null)) {
                this.buscarPrimeroTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroTipoidentificacion", new object[] {
                        obj}, this.buscarPrimeroTipoidentificacionOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroTipoidentificacionOperationCompleted(object arg) {
            if ((this.buscarPrimeroTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroTipoidentificacionCompleted(this, new buscarPrimeroTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoidentificacion[] buscarTipoidentificacion(Tipoidentificacion obj) {
            object[] results = this.Invoke("buscarTipoidentificacion", new object[] {
                        obj});
            return ((Tipoidentificacion[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarTipoidentificacionAsync(Tipoidentificacion obj) {
            this.buscarTipoidentificacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarTipoidentificacionAsync(Tipoidentificacion obj, object userState) {
            if ((this.buscarTipoidentificacionOperationCompleted == null)) {
                this.buscarTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("buscarTipoidentificacion", new object[] {
                        obj}, this.buscarTipoidentificacionOperationCompleted, userState);
        }
        
        private void OnbuscarTipoidentificacionOperationCompleted(object arg) {
            if ((this.buscarTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarTipoidentificacionCompleted(this, new buscarTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPaginacionTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoidentificacion[] buscarPaginacionTipoidentificacion(Tipoidentificacion obj, int pag, int numReg) {
            object[] results = this.Invoke("buscarPaginacionTipoidentificacion", new object[] {
                        obj,
                        pag,
                        numReg});
            return ((Tipoidentificacion[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarPaginacionTipoidentificacionAsync(Tipoidentificacion obj, int pag, int numReg) {
            this.buscarPaginacionTipoidentificacionAsync(obj, pag, numReg, null);
        }
        
        /// <remarks/>
        public void buscarPaginacionTipoidentificacionAsync(Tipoidentificacion obj, int pag, int numReg, object userState) {
            if ((this.buscarPaginacionTipoidentificacionOperationCompleted == null)) {
                this.buscarPaginacionTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPaginacionTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("buscarPaginacionTipoidentificacion", new object[] {
                        obj,
                        pag,
                        numReg}, this.buscarPaginacionTipoidentificacionOperationCompleted, userState);
        }
        
        private void OnbuscarPaginacionTipoidentificacionOperationCompleted(object arg) {
            if ((this.buscarPaginacionTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPaginacionTipoidentificacionCompleted(this, new buscarPaginacionTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoidentificacion[] listarTipoidentificacion() {
            object[] results = this.Invoke("listarTipoidentificacion", new object[0]);
            return ((Tipoidentificacion[])(results[0]));
        }
        
        /// <remarks/>
        public void listarTipoidentificacionAsync() {
            this.listarTipoidentificacionAsync(null);
        }
        
        /// <remarks/>
        public void listarTipoidentificacionAsync(object userState) {
            if ((this.listarTipoidentificacionOperationCompleted == null)) {
                this.listarTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("listarTipoidentificacion", new object[0], this.listarTipoidentificacionOperationCompleted, userState);
        }
        
        private void OnlistarTipoidentificacionOperationCompleted(object arg) {
            if ((this.listarTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarTipoidentificacionCompleted(this, new listarTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarPaginacionTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoidentificacion[] listarPaginacionTipoidentificacion(int pag, int numReg) {
            object[] results = this.Invoke("listarPaginacionTipoidentificacion", new object[] {
                        pag,
                        numReg});
            return ((Tipoidentificacion[])(results[0]));
        }
        
        /// <remarks/>
        public void listarPaginacionTipoidentificacionAsync(int pag, int numReg) {
            this.listarPaginacionTipoidentificacionAsync(pag, numReg, null);
        }
        
        /// <remarks/>
        public void listarPaginacionTipoidentificacionAsync(int pag, int numReg, object userState) {
            if ((this.listarPaginacionTipoidentificacionOperationCompleted == null)) {
                this.listarPaginacionTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarPaginacionTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("listarPaginacionTipoidentificacion", new object[] {
                        pag,
                        numReg}, this.listarPaginacionTipoidentificacionOperationCompleted, userState);
        }
        
        private void OnlistarPaginacionTipoidentificacionOperationCompleted(object arg) {
            if ((this.listarPaginacionTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarPaginacionTipoidentificacionCompleted(this, new listarPaginacionTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contarBusquedaTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int contarBusquedaTipoidentificacion(Tipoidentificacion obj) {
            object[] results = this.Invoke("contarBusquedaTipoidentificacion", new object[] {
                        obj});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void contarBusquedaTipoidentificacionAsync(Tipoidentificacion obj) {
            this.contarBusquedaTipoidentificacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void contarBusquedaTipoidentificacionAsync(Tipoidentificacion obj, object userState) {
            if ((this.contarBusquedaTipoidentificacionOperationCompleted == null)) {
                this.contarBusquedaTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontarBusquedaTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("contarBusquedaTipoidentificacion", new object[] {
                        obj}, this.contarBusquedaTipoidentificacionOperationCompleted, userState);
        }
        
        private void OncontarBusquedaTipoidentificacionOperationCompleted(object arg) {
            if ((this.contarBusquedaTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contarBusquedaTipoidentificacionCompleted(this, new contarBusquedaTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarTipoidentificacion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoidentificacionResponse eliminarTipoidentificacion(Tipoidentificacion obj) {
            object[] results = this.Invoke("eliminarTipoidentificacion", new object[] {
                        obj});
            return ((TipoidentificacionResponse)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarTipoidentificacionAsync(Tipoidentificacion obj) {
            this.eliminarTipoidentificacionAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarTipoidentificacionAsync(Tipoidentificacion obj, object userState) {
            if ((this.eliminarTipoidentificacionOperationCompleted == null)) {
                this.eliminarTipoidentificacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarTipoidentificacionOperationCompleted);
            }
            this.InvokeAsync("eliminarTipoidentificacion", new object[] {
                        obj}, this.eliminarTipoidentificacionOperationCompleted, userState);
        }
        
        private void OneliminarTipoidentificacionOperationCompleted(object arg) {
            if ((this.eliminarTipoidentificacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarTipoidentificacionCompleted(this, new eliminarTipoidentificacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TipoidentificacionResponse))]
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
    public partial class TipoidentificacionResponse : Response {
        
        private Tipoidentificacion objetoField;
        
        /// <comentarios/>
        public Tipoidentificacion objeto {
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
    public partial class Tipoidentificacion {
        
        private long iD_TIPO_IDENTIFICACIONField;
        
        private string nOM_TIPO_IDENTIFICACIONField;
        
        /// <comentarios/>
        public long ID_TIPO_IDENTIFICACION {
            get {
                return this.iD_TIPO_IDENTIFICACIONField;
            }
            set {
                this.iD_TIPO_IDENTIFICACIONField = value;
            }
        }
        
        /// <comentarios/>
        public string NOM_TIPO_IDENTIFICACION {
            get {
                return this.nOM_TIPO_IDENTIFICACIONField;
            }
            set {
                this.nOM_TIPO_IDENTIFICACIONField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void crearTipoidentificacionCompletedEventHandler(object sender, crearTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoidentificacionResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoidentificacionResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void editarTipoidentificacionCompletedEventHandler(object sender, editarTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoidentificacionResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoidentificacionResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarPrimeroTipoidentificacionCompletedEventHandler(object sender, buscarPrimeroTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoidentificacion Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoidentificacion)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarTipoidentificacionCompletedEventHandler(object sender, buscarTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoidentificacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoidentificacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarPaginacionTipoidentificacionCompletedEventHandler(object sender, buscarPaginacionTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPaginacionTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPaginacionTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoidentificacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoidentificacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void listarTipoidentificacionCompletedEventHandler(object sender, listarTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoidentificacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoidentificacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void listarPaginacionTipoidentificacionCompletedEventHandler(object sender, listarPaginacionTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarPaginacionTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarPaginacionTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoidentificacion[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoidentificacion[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void contarBusquedaTipoidentificacionCompletedEventHandler(object sender, contarBusquedaTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contarBusquedaTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contarBusquedaTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void eliminarTipoidentificacionCompletedEventHandler(object sender, eliminarTipoidentificacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarTipoidentificacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarTipoidentificacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoidentificacionResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoidentificacionResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591