﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PageUp.CodeChallenge.Application {
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
    internal class ApplicationResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ApplicationResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PageUp.CodeChallenge.Application.ApplicationResource", typeof(ApplicationResource).Assembly);
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
        ///   Looks up a localized string similar to Category : {0}.
        /// </summary>
        internal static string CategoryFormat {
            get {
                return ResourceManager.GetString("CategoryFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cost: {0:C}.
        /// </summary>
        internal static string CostFormat {
            get {
                return ResourceManager.GetString("CostFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter Depth in cm:.
        /// </summary>
        internal static string DepthInput {
            get {
                return ResourceManager.GetString("DepthInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Press enter to end the program.
        /// </summary>
        internal static string EndProgramText {
            get {
                return ResourceManager.GetString("EndProgramText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter Height in cm:.
        /// </summary>
        internal static string HeightInput {
            get {
                return ResourceManager.GetString("HeightInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter Weight in kg:.
        /// </summary>
        internal static string WeightInput {
            get {
                return ResourceManager.GetString("WeightInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter Width in cm:.
        /// </summary>
        internal static string WidthInput {
            get {
                return ResourceManager.GetString("WidthInput", resourceCulture);
            }
        }
    }
}