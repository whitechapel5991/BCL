﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BCL.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BCL.Resources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Exit....
        /// </summary>
        internal static string Exit {
            get {
                return ResourceManager.GetString("Exit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit &apos;Ctrl+C&apos;.
        /// </summary>
        internal static string ExitWithKeys {
            get {
                return ResourceManager.GetString("ExitWithKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File appear: {0}, creational date: {1}.
        /// </summary>
        internal static string FileAppered {
            get {
                return ResourceManager.GetString("FileAppered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File move to folder {0}.
        /// </summary>
        internal static string FileMoved {
            get {
                return ResourceManager.GetString("FileMoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File move to default folder {0}.
        /// </summary>
        internal static string FileMovedDefaultFolder {
            get {
                return ResourceManager.GetString("FileMovedDefaultFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder {0} is listening.
        /// </summary>
        internal static string FolderListening {
            get {
                return ResourceManager.GetString("FolderListening", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rule Exist for file {0}.
        /// </summary>
        internal static string RuleExist {
            get {
                return ResourceManager.GetString("RuleExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rule does not Exist for file {0}.
        /// </summary>
        internal static string RuleNotExist {
            get {
                return ResourceManager.GetString("RuleNotExist", resourceCulture);
            }
        }
    }
}
