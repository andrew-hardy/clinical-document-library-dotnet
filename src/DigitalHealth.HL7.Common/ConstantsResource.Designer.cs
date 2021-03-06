﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalHealth.Hl7.Common {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ConstantsResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConstantsResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DigitalHealth.Hl7.Common.ConstantsResource", typeof(ConstantsResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HL7 message has no MSH segment.
        /// </summary>
        internal static string HL7NoMshSegment {
            get {
                return ResourceManager.GetString("HL7NoMshSegment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HL7 message does not start with MSH.
        /// </summary>
        internal static string HL7NotStartMsh {
            get {
                return ResourceManager.GetString("HL7NotStartMsh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HL7 message too short to contain a valid MSH segment.
        /// </summary>
        internal static string HL7TooShort {
            get {
                return ResourceManager.GetString("HL7TooShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid segment name: {0}.
        /// </summary>
        internal static string InvalidSegmentName {
            get {
                return ResourceManager.GetString("InvalidSegmentName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HL7 message has no message type.
        /// </summary>
        internal static string NoMessageType {
            get {
                return ResourceManager.GetString("NoMessageType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subcomponent type is not a string: {0}.
        /// </summary>
        internal static string SubcomponentNotString {
            get {
                return ResourceManager.GetString("SubcomponentNotString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled HL7 message type: {0}.
        /// </summary>
        internal static string Unhandled_HL7_Message_Type {
            get {
                return ResourceManager.GetString("Unhandled_HL7_Message_Type", resourceCulture);
            }
        }
    }
}
