﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PageUp.CodeChallenge.Model {
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
    public class ModelResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ModelResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PageUp.CodeChallenge.Model.ModelResource", typeof(ModelResource).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Heavy Parcel.
        /// </summary>
        public static string HeavyParcel {
            get {
                return ResourceManager.GetString("HeavyParcel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Large Parcel.
        /// </summary>
        public static string LargeParcel {
            get {
                return ResourceManager.GetString("LargeParcel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Medium Parcel.
        /// </summary>
        public static string MediumParcel {
            get {
                return ResourceManager.GetString("MediumParcel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Weight = {0}, Volume = {1}.
        /// </summary>
        public static string ParcelDescriptionFormat {
            get {
                return ResourceManager.GetString("ParcelDescriptionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Category: {0} Cost: {1:C}.
        /// </summary>
        public static string ParcelTagDescriptionFormat {
            get {
                return ResourceManager.GetString("ParcelTagDescriptionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rejected.
        /// </summary>
        public static string RejectedParcel {
            get {
                return ResourceManager.GetString("RejectedParcel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Small Parcel.
        /// </summary>
        public static string SmallParcel {
            get {
                return ResourceManager.GetString("SmallParcel", resourceCulture);
            }
        }
    }
}