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

namespace ClienteFiel.WS_ServiciosTipoactividad {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosTipoactividadSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Response))]
    public partial class ServiciosTipoactividad : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private Autenticacion autenticacionValueField;
        
        private System.Threading.SendOrPostCallback crearTipoactividadOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarTipoactividadOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroTipoactividadOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarTipoactividadOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPaginacionTipoactividadOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarTipoactividadOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarPaginacionTipoactividadOperationCompleted;
        
        private System.Threading.SendOrPostCallback contarBusquedaTipoactividadOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarTipoactividadOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosTipoactividad() {
            this.Url = global::ClienteFiel.Properties.Settings.Default.ClienteFiel_WS_ServiciosTipoactividad_ServiciosTipoactividad;
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
        public event crearTipoactividadCompletedEventHandler crearTipoactividadCompleted;
        
        /// <remarks/>
        public event editarTipoactividadCompletedEventHandler editarTipoactividadCompleted;
        
        /// <remarks/>
        public event buscarPrimeroTipoactividadCompletedEventHandler buscarPrimeroTipoactividadCompleted;
        
        /// <remarks/>
        public event buscarTipoactividadCompletedEventHandler buscarTipoactividadCompleted;
        
        /// <remarks/>
        public event buscarPaginacionTipoactividadCompletedEventHandler buscarPaginacionTipoactividadCompleted;
        
        /// <remarks/>
        public event listarTipoactividadCompletedEventHandler listarTipoactividadCompleted;
        
        /// <remarks/>
        public event listarPaginacionTipoactividadCompletedEventHandler listarPaginacionTipoactividadCompleted;
        
        /// <remarks/>
        public event contarBusquedaTipoactividadCompletedEventHandler contarBusquedaTipoactividadCompleted;
        
        /// <remarks/>
        public event eliminarTipoactividadCompletedEventHandler eliminarTipoactividadCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoactividadResponse crearTipoactividad(Tipoactividad obj) {
            object[] results = this.Invoke("crearTipoactividad", new object[] {
                        obj});
            return ((TipoactividadResponse)(results[0]));
        }
        
        /// <remarks/>
        public void crearTipoactividadAsync(Tipoactividad obj) {
            this.crearTipoactividadAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearTipoactividadAsync(Tipoactividad obj, object userState) {
            if ((this.crearTipoactividadOperationCompleted == null)) {
                this.crearTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearTipoactividadOperationCompleted);
            }
            this.InvokeAsync("crearTipoactividad", new object[] {
                        obj}, this.crearTipoactividadOperationCompleted, userState);
        }
        
        private void OncrearTipoactividadOperationCompleted(object arg) {
            if ((this.crearTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearTipoactividadCompleted(this, new crearTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoactividadResponse editarTipoactividad(Tipoactividad obj) {
            object[] results = this.Invoke("editarTipoactividad", new object[] {
                        obj});
            return ((TipoactividadResponse)(results[0]));
        }
        
        /// <remarks/>
        public void editarTipoactividadAsync(Tipoactividad obj) {
            this.editarTipoactividadAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarTipoactividadAsync(Tipoactividad obj, object userState) {
            if ((this.editarTipoactividadOperationCompleted == null)) {
                this.editarTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarTipoactividadOperationCompleted);
            }
            this.InvokeAsync("editarTipoactividad", new object[] {
                        obj}, this.editarTipoactividadOperationCompleted, userState);
        }
        
        private void OneditarTipoactividadOperationCompleted(object arg) {
            if ((this.editarTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarTipoactividadCompleted(this, new editarTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoactividad buscarPrimeroTipoactividad(Tipoactividad obj) {
            object[] results = this.Invoke("buscarPrimeroTipoactividad", new object[] {
                        obj});
            return ((Tipoactividad)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroTipoactividadAsync(Tipoactividad obj) {
            this.buscarPrimeroTipoactividadAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroTipoactividadAsync(Tipoactividad obj, object userState) {
            if ((this.buscarPrimeroTipoactividadOperationCompleted == null)) {
                this.buscarPrimeroTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroTipoactividadOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroTipoactividad", new object[] {
                        obj}, this.buscarPrimeroTipoactividadOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroTipoactividadOperationCompleted(object arg) {
            if ((this.buscarPrimeroTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroTipoactividadCompleted(this, new buscarPrimeroTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoactividad[] buscarTipoactividad(Tipoactividad obj) {
            object[] results = this.Invoke("buscarTipoactividad", new object[] {
                        obj});
            return ((Tipoactividad[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarTipoactividadAsync(Tipoactividad obj) {
            this.buscarTipoactividadAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarTipoactividadAsync(Tipoactividad obj, object userState) {
            if ((this.buscarTipoactividadOperationCompleted == null)) {
                this.buscarTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarTipoactividadOperationCompleted);
            }
            this.InvokeAsync("buscarTipoactividad", new object[] {
                        obj}, this.buscarTipoactividadOperationCompleted, userState);
        }
        
        private void OnbuscarTipoactividadOperationCompleted(object arg) {
            if ((this.buscarTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarTipoactividadCompleted(this, new buscarTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPaginacionTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoactividad[] buscarPaginacionTipoactividad(Tipoactividad obj, int pag, int numReg) {
            object[] results = this.Invoke("buscarPaginacionTipoactividad", new object[] {
                        obj,
                        pag,
                        numReg});
            return ((Tipoactividad[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarPaginacionTipoactividadAsync(Tipoactividad obj, int pag, int numReg) {
            this.buscarPaginacionTipoactividadAsync(obj, pag, numReg, null);
        }
        
        /// <remarks/>
        public void buscarPaginacionTipoactividadAsync(Tipoactividad obj, int pag, int numReg, object userState) {
            if ((this.buscarPaginacionTipoactividadOperationCompleted == null)) {
                this.buscarPaginacionTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPaginacionTipoactividadOperationCompleted);
            }
            this.InvokeAsync("buscarPaginacionTipoactividad", new object[] {
                        obj,
                        pag,
                        numReg}, this.buscarPaginacionTipoactividadOperationCompleted, userState);
        }
        
        private void OnbuscarPaginacionTipoactividadOperationCompleted(object arg) {
            if ((this.buscarPaginacionTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPaginacionTipoactividadCompleted(this, new buscarPaginacionTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoactividad[] listarTipoactividad() {
            object[] results = this.Invoke("listarTipoactividad", new object[0]);
            return ((Tipoactividad[])(results[0]));
        }
        
        /// <remarks/>
        public void listarTipoactividadAsync() {
            this.listarTipoactividadAsync(null);
        }
        
        /// <remarks/>
        public void listarTipoactividadAsync(object userState) {
            if ((this.listarTipoactividadOperationCompleted == null)) {
                this.listarTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarTipoactividadOperationCompleted);
            }
            this.InvokeAsync("listarTipoactividad", new object[0], this.listarTipoactividadOperationCompleted, userState);
        }
        
        private void OnlistarTipoactividadOperationCompleted(object arg) {
            if ((this.listarTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarTipoactividadCompleted(this, new listarTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarPaginacionTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Tipoactividad[] listarPaginacionTipoactividad(int pag, int numReg) {
            object[] results = this.Invoke("listarPaginacionTipoactividad", new object[] {
                        pag,
                        numReg});
            return ((Tipoactividad[])(results[0]));
        }
        
        /// <remarks/>
        public void listarPaginacionTipoactividadAsync(int pag, int numReg) {
            this.listarPaginacionTipoactividadAsync(pag, numReg, null);
        }
        
        /// <remarks/>
        public void listarPaginacionTipoactividadAsync(int pag, int numReg, object userState) {
            if ((this.listarPaginacionTipoactividadOperationCompleted == null)) {
                this.listarPaginacionTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarPaginacionTipoactividadOperationCompleted);
            }
            this.InvokeAsync("listarPaginacionTipoactividad", new object[] {
                        pag,
                        numReg}, this.listarPaginacionTipoactividadOperationCompleted, userState);
        }
        
        private void OnlistarPaginacionTipoactividadOperationCompleted(object arg) {
            if ((this.listarPaginacionTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarPaginacionTipoactividadCompleted(this, new listarPaginacionTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contarBusquedaTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int contarBusquedaTipoactividad(Tipoactividad obj) {
            object[] results = this.Invoke("contarBusquedaTipoactividad", new object[] {
                        obj});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void contarBusquedaTipoactividadAsync(Tipoactividad obj) {
            this.contarBusquedaTipoactividadAsync(obj, null);
        }
        
        /// <remarks/>
        public void contarBusquedaTipoactividadAsync(Tipoactividad obj, object userState) {
            if ((this.contarBusquedaTipoactividadOperationCompleted == null)) {
                this.contarBusquedaTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontarBusquedaTipoactividadOperationCompleted);
            }
            this.InvokeAsync("contarBusquedaTipoactividad", new object[] {
                        obj}, this.contarBusquedaTipoactividadOperationCompleted, userState);
        }
        
        private void OncontarBusquedaTipoactividadOperationCompleted(object arg) {
            if ((this.contarBusquedaTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contarBusquedaTipoactividadCompleted(this, new contarBusquedaTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarTipoactividad", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public TipoactividadResponse eliminarTipoactividad(Tipoactividad obj) {
            object[] results = this.Invoke("eliminarTipoactividad", new object[] {
                        obj});
            return ((TipoactividadResponse)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarTipoactividadAsync(Tipoactividad obj) {
            this.eliminarTipoactividadAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarTipoactividadAsync(Tipoactividad obj, object userState) {
            if ((this.eliminarTipoactividadOperationCompleted == null)) {
                this.eliminarTipoactividadOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarTipoactividadOperationCompleted);
            }
            this.InvokeAsync("eliminarTipoactividad", new object[] {
                        obj}, this.eliminarTipoactividadOperationCompleted, userState);
        }
        
        private void OneliminarTipoactividadOperationCompleted(object arg) {
            if ((this.eliminarTipoactividadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarTipoactividadCompleted(this, new eliminarTipoactividadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TipoactividadResponse))]
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
    public partial class TipoactividadResponse : Response {
        
        private Tipoactividad objetoField;
        
        /// <comentarios/>
        public Tipoactividad objeto {
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
    public partial class Tipoactividad {
        
        private long iD_TIPO_ACTIVIDADField;
        
        private string nOM_TIPO_ACTIVIDADField;
        
        /// <comentarios/>
        public long ID_TIPO_ACTIVIDAD {
            get {
                return this.iD_TIPO_ACTIVIDADField;
            }
            set {
                this.iD_TIPO_ACTIVIDADField = value;
            }
        }
        
        /// <comentarios/>
        public string NOM_TIPO_ACTIVIDAD {
            get {
                return this.nOM_TIPO_ACTIVIDADField;
            }
            set {
                this.nOM_TIPO_ACTIVIDADField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void crearTipoactividadCompletedEventHandler(object sender, crearTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoactividadResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoactividadResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void editarTipoactividadCompletedEventHandler(object sender, editarTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoactividadResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoactividadResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void buscarPrimeroTipoactividadCompletedEventHandler(object sender, buscarPrimeroTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoactividad Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoactividad)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void buscarTipoactividadCompletedEventHandler(object sender, buscarTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoactividad[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoactividad[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void buscarPaginacionTipoactividadCompletedEventHandler(object sender, buscarPaginacionTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPaginacionTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPaginacionTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoactividad[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoactividad[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void listarTipoactividadCompletedEventHandler(object sender, listarTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoactividad[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoactividad[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void listarPaginacionTipoactividadCompletedEventHandler(object sender, listarPaginacionTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarPaginacionTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarPaginacionTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Tipoactividad[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Tipoactividad[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    public delegate void contarBusquedaTipoactividadCompletedEventHandler(object sender, contarBusquedaTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contarBusquedaTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contarBusquedaTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void eliminarTipoactividadCompletedEventHandler(object sender, eliminarTipoactividadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2053.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarTipoactividadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarTipoactividadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TipoactividadResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TipoactividadResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591