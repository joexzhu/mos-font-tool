﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MosFontTool.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Lucida Sans, 9pt, style=Bold")]
        public global::System.Drawing.Font RowIndexFont {
            get {
                return ((global::System.Drawing.Font)(this["RowIndexFont"]));
            }
            set {
                this["RowIndexFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0, 0, 192")]
        public global::System.Drawing.Color RowIndexColor {
            get {
                return ((global::System.Drawing.Color)(this["RowIndexColor"]));
            }
            set {
                this["RowIndexColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 255, 192")]
        public global::System.Drawing.Color ContentBackColor {
            get {
                return ((global::System.Drawing.Color)(this["ContentBackColor"]));
            }
            set {
                this["ContentBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16")]
        public int NewLinePositionOfExport {
            get {
                return ((int)(this["NewLinePositionOfExport"]));
            }
            set {
                this["NewLinePositionOfExport"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16")]
        public int DefaultBlockWidth {
            get {
                return ((int)(this["DefaultBlockWidth"]));
            }
            set {
                this["DefaultBlockWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16")]
        public int DefaultBlockHeight {
            get {
                return ((int)(this["DefaultBlockHeight"]));
            }
            set {
                this["DefaultBlockHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DefaultOffsetX {
            get {
                return ((int)(this["DefaultOffsetX"]));
            }
            set {
                this["DefaultOffsetX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DefaultOffsetY {
            get {
                return ((int)(this["DefaultOffsetY"]));
            }
            set {
                this["DefaultOffsetY"] = value;
            }
        }
    }
}
