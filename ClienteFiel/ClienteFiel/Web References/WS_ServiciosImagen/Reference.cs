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

namespace ClienteFiel.WS_ServiciosImagen {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiciosImagenSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Response))]
    public partial class ServiciosImagen : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private Autenticacion autenticacionValueField;
        
        private System.Threading.SendOrPostCallback crearImagenOperationCompleted;
        
        private System.Threading.SendOrPostCallback editarImagenOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPrimeroImagenOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarImagenOperationCompleted;
        
        private System.Threading.SendOrPostCallback buscarPaginacionImagenOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarImagenOperationCompleted;
        
        private System.Threading.SendOrPostCallback listarPaginacionImagenOperationCompleted;
        
        private System.Threading.SendOrPostCallback contarBusquedaImagenOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarImagenOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ServiciosImagen() {
            this.Url = global::ClienteFiel.Properties.Settings.Default.ClienteFiel_WS_ServiciosImagen_ServiciosImagen;
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
        public event crearImagenCompletedEventHandler crearImagenCompleted;
        
        /// <remarks/>
        public event editarImagenCompletedEventHandler editarImagenCompleted;
        
        /// <remarks/>
        public event buscarPrimeroImagenCompletedEventHandler buscarPrimeroImagenCompleted;
        
        /// <remarks/>
        public event buscarImagenCompletedEventHandler buscarImagenCompleted;
        
        /// <remarks/>
        public event buscarPaginacionImagenCompletedEventHandler buscarPaginacionImagenCompleted;
        
        /// <remarks/>
        public event listarImagenCompletedEventHandler listarImagenCompleted;
        
        /// <remarks/>
        public event listarPaginacionImagenCompletedEventHandler listarPaginacionImagenCompleted;
        
        /// <remarks/>
        public event contarBusquedaImagenCompletedEventHandler contarBusquedaImagenCompleted;
        
        /// <remarks/>
        public event eliminarImagenCompletedEventHandler eliminarImagenCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/crearImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ImagenResponse crearImagen(Imagen obj) {
            object[] results = this.Invoke("crearImagen", new object[] {
                        obj});
            return ((ImagenResponse)(results[0]));
        }
        
        /// <remarks/>
        public void crearImagenAsync(Imagen obj) {
            this.crearImagenAsync(obj, null);
        }
        
        /// <remarks/>
        public void crearImagenAsync(Imagen obj, object userState) {
            if ((this.crearImagenOperationCompleted == null)) {
                this.crearImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OncrearImagenOperationCompleted);
            }
            this.InvokeAsync("crearImagen", new object[] {
                        obj}, this.crearImagenOperationCompleted, userState);
        }
        
        private void OncrearImagenOperationCompleted(object arg) {
            if ((this.crearImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.crearImagenCompleted(this, new crearImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/editarImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ImagenResponse editarImagen(Imagen obj) {
            object[] results = this.Invoke("editarImagen", new object[] {
                        obj});
            return ((ImagenResponse)(results[0]));
        }
        
        /// <remarks/>
        public void editarImagenAsync(Imagen obj) {
            this.editarImagenAsync(obj, null);
        }
        
        /// <remarks/>
        public void editarImagenAsync(Imagen obj, object userState) {
            if ((this.editarImagenOperationCompleted == null)) {
                this.editarImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditarImagenOperationCompleted);
            }
            this.InvokeAsync("editarImagen", new object[] {
                        obj}, this.editarImagenOperationCompleted, userState);
        }
        
        private void OneditarImagenOperationCompleted(object arg) {
            if ((this.editarImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editarImagenCompleted(this, new editarImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPrimeroImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Imagen buscarPrimeroImagen(Imagen obj) {
            object[] results = this.Invoke("buscarPrimeroImagen", new object[] {
                        obj});
            return ((Imagen)(results[0]));
        }
        
        /// <remarks/>
        public void buscarPrimeroImagenAsync(Imagen obj) {
            this.buscarPrimeroImagenAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarPrimeroImagenAsync(Imagen obj, object userState) {
            if ((this.buscarPrimeroImagenOperationCompleted == null)) {
                this.buscarPrimeroImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPrimeroImagenOperationCompleted);
            }
            this.InvokeAsync("buscarPrimeroImagen", new object[] {
                        obj}, this.buscarPrimeroImagenOperationCompleted, userState);
        }
        
        private void OnbuscarPrimeroImagenOperationCompleted(object arg) {
            if ((this.buscarPrimeroImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPrimeroImagenCompleted(this, new buscarPrimeroImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Imagen[] buscarImagen(Imagen obj) {
            object[] results = this.Invoke("buscarImagen", new object[] {
                        obj});
            return ((Imagen[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarImagenAsync(Imagen obj) {
            this.buscarImagenAsync(obj, null);
        }
        
        /// <remarks/>
        public void buscarImagenAsync(Imagen obj, object userState) {
            if ((this.buscarImagenOperationCompleted == null)) {
                this.buscarImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarImagenOperationCompleted);
            }
            this.InvokeAsync("buscarImagen", new object[] {
                        obj}, this.buscarImagenOperationCompleted, userState);
        }
        
        private void OnbuscarImagenOperationCompleted(object arg) {
            if ((this.buscarImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarImagenCompleted(this, new buscarImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/buscarPaginacionImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Imagen[] buscarPaginacionImagen(Imagen obj, int pag, int numReg) {
            object[] results = this.Invoke("buscarPaginacionImagen", new object[] {
                        obj,
                        pag,
                        numReg});
            return ((Imagen[])(results[0]));
        }
        
        /// <remarks/>
        public void buscarPaginacionImagenAsync(Imagen obj, int pag, int numReg) {
            this.buscarPaginacionImagenAsync(obj, pag, numReg, null);
        }
        
        /// <remarks/>
        public void buscarPaginacionImagenAsync(Imagen obj, int pag, int numReg, object userState) {
            if ((this.buscarPaginacionImagenOperationCompleted == null)) {
                this.buscarPaginacionImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnbuscarPaginacionImagenOperationCompleted);
            }
            this.InvokeAsync("buscarPaginacionImagen", new object[] {
                        obj,
                        pag,
                        numReg}, this.buscarPaginacionImagenOperationCompleted, userState);
        }
        
        private void OnbuscarPaginacionImagenOperationCompleted(object arg) {
            if ((this.buscarPaginacionImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.buscarPaginacionImagenCompleted(this, new buscarPaginacionImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Imagen[] listarImagen() {
            object[] results = this.Invoke("listarImagen", new object[0]);
            return ((Imagen[])(results[0]));
        }
        
        /// <remarks/>
        public void listarImagenAsync() {
            this.listarImagenAsync(null);
        }
        
        /// <remarks/>
        public void listarImagenAsync(object userState) {
            if ((this.listarImagenOperationCompleted == null)) {
                this.listarImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarImagenOperationCompleted);
            }
            this.InvokeAsync("listarImagen", new object[0], this.listarImagenOperationCompleted, userState);
        }
        
        private void OnlistarImagenOperationCompleted(object arg) {
            if ((this.listarImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarImagenCompleted(this, new listarImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/listarPaginacionImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Imagen[] listarPaginacionImagen(int pag, int numReg) {
            object[] results = this.Invoke("listarPaginacionImagen", new object[] {
                        pag,
                        numReg});
            return ((Imagen[])(results[0]));
        }
        
        /// <remarks/>
        public void listarPaginacionImagenAsync(int pag, int numReg) {
            this.listarPaginacionImagenAsync(pag, numReg, null);
        }
        
        /// <remarks/>
        public void listarPaginacionImagenAsync(int pag, int numReg, object userState) {
            if ((this.listarPaginacionImagenOperationCompleted == null)) {
                this.listarPaginacionImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlistarPaginacionImagenOperationCompleted);
            }
            this.InvokeAsync("listarPaginacionImagen", new object[] {
                        pag,
                        numReg}, this.listarPaginacionImagenOperationCompleted, userState);
        }
        
        private void OnlistarPaginacionImagenOperationCompleted(object arg) {
            if ((this.listarPaginacionImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.listarPaginacionImagenCompleted(this, new listarPaginacionImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/contarBusquedaImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int contarBusquedaImagen(Imagen obj) {
            object[] results = this.Invoke("contarBusquedaImagen", new object[] {
                        obj});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void contarBusquedaImagenAsync(Imagen obj) {
            this.contarBusquedaImagenAsync(obj, null);
        }
        
        /// <remarks/>
        public void contarBusquedaImagenAsync(Imagen obj, object userState) {
            if ((this.contarBusquedaImagenOperationCompleted == null)) {
                this.contarBusquedaImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OncontarBusquedaImagenOperationCompleted);
            }
            this.InvokeAsync("contarBusquedaImagen", new object[] {
                        obj}, this.contarBusquedaImagenOperationCompleted, userState);
        }
        
        private void OncontarBusquedaImagenOperationCompleted(object arg) {
            if ((this.contarBusquedaImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.contarBusquedaImagenCompleted(this, new contarBusquedaImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacionValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarImagen", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ImagenResponse eliminarImagen(Imagen obj) {
            object[] results = this.Invoke("eliminarImagen", new object[] {
                        obj});
            return ((ImagenResponse)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarImagenAsync(Imagen obj) {
            this.eliminarImagenAsync(obj, null);
        }
        
        /// <remarks/>
        public void eliminarImagenAsync(Imagen obj, object userState) {
            if ((this.eliminarImagenOperationCompleted == null)) {
                this.eliminarImagenOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarImagenOperationCompleted);
            }
            this.InvokeAsync("eliminarImagen", new object[] {
                        obj}, this.eliminarImagenOperationCompleted, userState);
        }
        
        private void OneliminarImagenOperationCompleted(object arg) {
            if ((this.eliminarImagenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarImagenCompleted(this, new eliminarImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImagenResponse))]
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
    public partial class ImagenResponse : Response {
        
        private Imagen objetoField;
        
        /// <comentarios/>
        public Imagen objeto {
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
    public partial class Imagen {
        
        private long iD_IMAGENField;
        
        private string rUTAField;
        
        private byte[] iMAGENField;
        
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
        public string RUTA {
            get {
                return this.rUTAField;
            }
            set {
                this.rUTAField = value;
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] IMAGEN {
            get {
                return this.iMAGENField;
            }
            set {
                this.iMAGENField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void crearImagenCompletedEventHandler(object sender, crearImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class crearImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal crearImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ImagenResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ImagenResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void editarImagenCompletedEventHandler(object sender, editarImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class editarImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal editarImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ImagenResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ImagenResponse)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarPrimeroImagenCompletedEventHandler(object sender, buscarPrimeroImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPrimeroImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPrimeroImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Imagen Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Imagen)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarImagenCompletedEventHandler(object sender, buscarImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Imagen[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Imagen[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void buscarPaginacionImagenCompletedEventHandler(object sender, buscarPaginacionImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class buscarPaginacionImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal buscarPaginacionImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Imagen[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Imagen[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void listarImagenCompletedEventHandler(object sender, listarImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Imagen[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Imagen[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void listarPaginacionImagenCompletedEventHandler(object sender, listarPaginacionImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class listarPaginacionImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal listarPaginacionImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Imagen[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Imagen[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void contarBusquedaImagenCompletedEventHandler(object sender, contarBusquedaImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class contarBusquedaImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal contarBusquedaImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void eliminarImagenCompletedEventHandler(object sender, eliminarImagenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarImagenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarImagenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ImagenResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ImagenResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591