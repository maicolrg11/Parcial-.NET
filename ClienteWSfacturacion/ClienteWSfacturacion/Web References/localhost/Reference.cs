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

namespace ClienteWSfacturacion.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WSfacturacionSoap", Namespace="http://tempuri.org/")]
    public partial class WSfacturacion : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback BuscaridOperationCompleted;
        
        private System.Threading.SendOrPostCallback ListarClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarProductoVentaOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarVentaClienteOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarVentaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WSfacturacion() {
            this.Url = global::ClienteWSfacturacion.Properties.Settings.Default.ClienteWSfacturacion_localhost_WSfacturacion;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
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
        public event BuscaridCompletedEventHandler BuscaridCompleted;
        
        /// <remarks/>
        public event ListarClienteCompletedEventHandler ListarClienteCompleted;
        
        /// <remarks/>
        public event BuscarProductoVentaCompletedEventHandler BuscarProductoVentaCompleted;
        
        /// <remarks/>
        public event BuscarVentaClienteCompletedEventHandler BuscarVentaClienteCompleted;
        
        /// <remarks/>
        public event BuscarVentaCompletedEventHandler BuscarVentaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Buscarid", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Cliente Buscarid(int id) {
            object[] results = this.Invoke("Buscarid", new object[] {
                        id});
            return ((Cliente)(results[0]));
        }
        
        /// <remarks/>
        public void BuscaridAsync(int id) {
            this.BuscaridAsync(id, null);
        }
        
        /// <remarks/>
        public void BuscaridAsync(int id, object userState) {
            if ((this.BuscaridOperationCompleted == null)) {
                this.BuscaridOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscaridOperationCompleted);
            }
            this.InvokeAsync("Buscarid", new object[] {
                        id}, this.BuscaridOperationCompleted, userState);
        }
        
        private void OnBuscaridOperationCompleted(object arg) {
            if ((this.BuscaridCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscaridCompleted(this, new BuscaridCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ListarCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Cliente[] ListarCliente() {
            object[] results = this.Invoke("ListarCliente", new object[0]);
            return ((Cliente[])(results[0]));
        }
        
        /// <remarks/>
        public void ListarClienteAsync() {
            this.ListarClienteAsync(null);
        }
        
        /// <remarks/>
        public void ListarClienteAsync(object userState) {
            if ((this.ListarClienteOperationCompleted == null)) {
                this.ListarClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnListarClienteOperationCompleted);
            }
            this.InvokeAsync("ListarCliente", new object[0], this.ListarClienteOperationCompleted, userState);
        }
        
        private void OnListarClienteOperationCompleted(object arg) {
            if ((this.ListarClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ListarClienteCompleted(this, new ListarClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarProductoVenta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Producto[] BuscarProductoVenta(int idventa) {
            object[] results = this.Invoke("BuscarProductoVenta", new object[] {
                        idventa});
            return ((Producto[])(results[0]));
        }
        
        /// <remarks/>
        public void BuscarProductoVentaAsync(int idventa) {
            this.BuscarProductoVentaAsync(idventa, null);
        }
        
        /// <remarks/>
        public void BuscarProductoVentaAsync(int idventa, object userState) {
            if ((this.BuscarProductoVentaOperationCompleted == null)) {
                this.BuscarProductoVentaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarProductoVentaOperationCompleted);
            }
            this.InvokeAsync("BuscarProductoVenta", new object[] {
                        idventa}, this.BuscarProductoVentaOperationCompleted, userState);
        }
        
        private void OnBuscarProductoVentaOperationCompleted(object arg) {
            if ((this.BuscarProductoVentaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarProductoVentaCompleted(this, new BuscarProductoVentaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarVentaCliente", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Venta[] BuscarVentaCliente(int idventacl) {
            object[] results = this.Invoke("BuscarVentaCliente", new object[] {
                        idventacl});
            return ((Venta[])(results[0]));
        }
        
        /// <remarks/>
        public void BuscarVentaClienteAsync(int idventacl) {
            this.BuscarVentaClienteAsync(idventacl, null);
        }
        
        /// <remarks/>
        public void BuscarVentaClienteAsync(int idventacl, object userState) {
            if ((this.BuscarVentaClienteOperationCompleted == null)) {
                this.BuscarVentaClienteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarVentaClienteOperationCompleted);
            }
            this.InvokeAsync("BuscarVentaCliente", new object[] {
                        idventacl}, this.BuscarVentaClienteOperationCompleted, userState);
        }
        
        private void OnBuscarVentaClienteOperationCompleted(object arg) {
            if ((this.BuscarVentaClienteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarVentaClienteCompleted(this, new BuscarVentaClienteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarVenta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Venta BuscarVenta(int idventa) {
            object[] results = this.Invoke("BuscarVenta", new object[] {
                        idventa});
            return ((Venta)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarVentaAsync(int idventa) {
            this.BuscarVentaAsync(idventa, null);
        }
        
        /// <remarks/>
        public void BuscarVentaAsync(int idventa, object userState) {
            if ((this.BuscarVentaOperationCompleted == null)) {
                this.BuscarVentaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarVentaOperationCompleted);
            }
            this.InvokeAsync("BuscarVenta", new object[] {
                        idventa}, this.BuscarVentaOperationCompleted, userState);
        }
        
        private void OnBuscarVentaOperationCompleted(object arg) {
            if ((this.BuscarVentaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarVentaCompleted(this, new BuscarVentaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Cliente {
        
        private int idField;
        
        private string documentoField;
        
        private string nombresField;
        
        private string apellidosField;
        
        private string direccionField;
        
        private string telefonoField;
        
        private string correoField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Documento {
            get {
                return this.documentoField;
            }
            set {
                this.documentoField = value;
            }
        }
        
        /// <remarks/>
        public string Nombres {
            get {
                return this.nombresField;
            }
            set {
                this.nombresField = value;
            }
        }
        
        /// <remarks/>
        public string Apellidos {
            get {
                return this.apellidosField;
            }
            set {
                this.apellidosField = value;
            }
        }
        
        /// <remarks/>
        public string Direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
            }
        }
        
        /// <remarks/>
        public string Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
            }
        }
        
        /// <remarks/>
        public string Correo {
            get {
                return this.correoField;
            }
            set {
                this.correoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Venta {
        
        private int idField;
        
        private string numeroField;
        
        private string fechaField;
        
        private double subtotalField;
        
        private double ivaField;
        
        private double descuentoField;
        
        private double totalField;
        
        private int idclienteField;
        
        private int idvendedorField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
            }
        }
        
        /// <remarks/>
        public string Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }
        
        /// <remarks/>
        public double Subtotal {
            get {
                return this.subtotalField;
            }
            set {
                this.subtotalField = value;
            }
        }
        
        /// <remarks/>
        public double Iva {
            get {
                return this.ivaField;
            }
            set {
                this.ivaField = value;
            }
        }
        
        /// <remarks/>
        public double Descuento {
            get {
                return this.descuentoField;
            }
            set {
                this.descuentoField = value;
            }
        }
        
        /// <remarks/>
        public double Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        public int Idcliente {
            get {
                return this.idclienteField;
            }
            set {
                this.idclienteField = value;
            }
        }
        
        /// <remarks/>
        public int Idvendedor {
            get {
                return this.idvendedorField;
            }
            set {
                this.idvendedorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Producto {
        
        private string idField;
        
        private string descripcionField;
        
        private double precioField;
        
        private int cantidadField;
        
        private float descuentoField;
        
        private float ivaField;
        
        private int categoriaField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }
        
        /// <remarks/>
        public double Precio {
            get {
                return this.precioField;
            }
            set {
                this.precioField = value;
            }
        }
        
        /// <remarks/>
        public int Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }
        
        /// <remarks/>
        public float Descuento {
            get {
                return this.descuentoField;
            }
            set {
                this.descuentoField = value;
            }
        }
        
        /// <remarks/>
        public float Iva {
            get {
                return this.ivaField;
            }
            set {
                this.ivaField = value;
            }
        }
        
        /// <remarks/>
        public int Categoria {
            get {
                return this.categoriaField;
            }
            set {
                this.categoriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void BuscaridCompletedEventHandler(object sender, BuscaridCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscaridCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscaridCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Cliente Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Cliente)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void ListarClienteCompletedEventHandler(object sender, ListarClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ListarClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ListarClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Cliente[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Cliente[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void BuscarProductoVentaCompletedEventHandler(object sender, BuscarProductoVentaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarProductoVentaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarProductoVentaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Producto[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Producto[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void BuscarVentaClienteCompletedEventHandler(object sender, BuscarVentaClienteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarVentaClienteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarVentaClienteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Venta[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Venta[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void BuscarVentaCompletedEventHandler(object sender, BuscarVentaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarVentaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarVentaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Venta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Venta)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591