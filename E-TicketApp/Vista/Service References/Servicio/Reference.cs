﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vista.Servicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servicio.IControladorServicio")]
    public interface IControladorServicio {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControladorServicio/ValidarUsuario", ReplyAction="http://tempuri.org/IControladorServicio/ValidarUsuarioResponse")]
        string ValidarUsuario(string usuario, string contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IControladorServicio/RecuperarUsuario", ReplyAction="http://tempuri.org/IControladorServicio/RecuperarUsuarioResponse")]
        string RecuperarUsuario(string run);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IControladorServicioChannel : Vista.Servicio.IControladorServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ControladorServicioClient : System.ServiceModel.ClientBase<Vista.Servicio.IControladorServicio>, Vista.Servicio.IControladorServicio {
        
        public ControladorServicioClient() {
        }
        
        public ControladorServicioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ControladorServicioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControladorServicioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControladorServicioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ValidarUsuario(string usuario, string contrasena) {
            return base.Channel.ValidarUsuario(usuario, contrasena);
        }
        
        public string RecuperarUsuario(string run) {
            return base.Channel.RecuperarUsuario(run);
        }
    }
}
