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

namespace WebServiceDatos.Web.NuevoRadicadoWs {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Ventanilla_Unica_WsSoap", Namespace="http://tempuri.org/")]
    public partial class Ventanilla_Unica_Ws : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback wsNuevoRadicadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Ventanilla_Unica_Ws() {
            this.Url = global::WebServiceDatos.Web.Properties.Settings.Default.WebServiceDatos_Web_NuevoRadicadoWs_Ventanilla_Unica_Ws;
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
        public event wsNuevoRadicadoCompletedEventHandler wsNuevoRadicadoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/wsNuevoRadicado", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string wsNuevoRadicado(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado) {
            object[] results = this.Invoke("wsNuevoRadicado", new object[] {
                        CodigoRadicado,
                        CodigoTercero,
                        CodigoFuncionario,
                        CodigoUsuario,
                        FechaRadicado,
                        DescripcionRadicado});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void wsNuevoRadicadoAsync(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado) {
            this.wsNuevoRadicadoAsync(CodigoRadicado, CodigoTercero, CodigoFuncionario, CodigoUsuario, FechaRadicado, DescripcionRadicado, null);
        }
        
        /// <remarks/>
        public void wsNuevoRadicadoAsync(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado, object userState) {
            if ((this.wsNuevoRadicadoOperationCompleted == null)) {
                this.wsNuevoRadicadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnwsNuevoRadicadoOperationCompleted);
            }
            this.InvokeAsync("wsNuevoRadicado", new object[] {
                        CodigoRadicado,
                        CodigoTercero,
                        CodigoFuncionario,
                        CodigoUsuario,
                        FechaRadicado,
                        DescripcionRadicado}, this.wsNuevoRadicadoOperationCompleted, userState);
        }
        
        private void OnwsNuevoRadicadoOperationCompleted(object arg) {
            if ((this.wsNuevoRadicadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.wsNuevoRadicadoCompleted(this, new wsNuevoRadicadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void wsNuevoRadicadoCompletedEventHandler(object sender, wsNuevoRadicadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class wsNuevoRadicadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal wsNuevoRadicadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591