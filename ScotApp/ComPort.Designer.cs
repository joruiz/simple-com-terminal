﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34209
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScotApp {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class ComPort : global::System.Configuration.ApplicationSettingsBase {
        
        private static ComPort defaultInstance = ((ComPort)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ComPort())));
        
        public static ComPort Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM1")]
        public string PORT_NAME {
            get {
                return ((string)(this["PORT_NAME"]));
            }
            set {
                this["PORT_NAME"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9600")]
        public int BAUD_RATE {
            get {
                return ((int)(this["BAUD_RATE"]));
            }
            set {
                this["BAUD_RATE"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public global::System.IO.Ports.Parity PARITY {
            get {
                return ((global::System.IO.Ports.Parity)(this["PARITY"]));
            }
            set {
                this["PARITY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public int DATA_BITS {
            get {
                return ((int)(this["DATA_BITS"]));
            }
            set {
                this["DATA_BITS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("One")]
        public global::System.IO.Ports.StopBits STOP_BITS {
            get {
                return ((global::System.IO.Ports.StopBits)(this["STOP_BITS"]));
            }
            set {
                this["STOP_BITS"] = value;
            }
        }
    }
}
