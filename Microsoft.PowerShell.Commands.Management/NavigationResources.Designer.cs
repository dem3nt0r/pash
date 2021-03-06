﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerShell.Commands.Management {
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
    public class NavigationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NavigationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerShell.Commands.Management.NavigationResources", typeof(NavigationResources).Assembly);
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
        ///   Looks up a localized string similar to Add Content.
        /// </summary>
        public static string AddContentAction {
            get {
                return ResourceManager.GetString("AddContentAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path: {0}.
        /// </summary>
        public static string AddContentTarget {
            get {
                return ResourceManager.GetString("AddContentTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commit.
        /// </summary>
        public static string CommitAction {
            get {
                return ResourceManager.GetString("CommitAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot copy because the specified destination already exists. Do you want to overwrite the existing content?.
        /// </summary>
        public static string CopyToExistingPrompt {
            get {
                return ResourceManager.GetString("CopyToExistingPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Begin.
        /// </summary>
        public static string CreateAction {
            get {
                return ResourceManager.GetString("CreateAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified path is a container that has child items. Do you want to delete this container and its child items?.
        /// </summary>
        public static string DeleteHasChildrenPrompt {
            get {
                return ResourceManager.GetString("DeleteHasChildrenPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to delete the specified item?.
        /// </summary>
        public static string DeletePrompt {
            get {
                return ResourceManager.GetString("DeletePrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An object at the specified path {0} does not exist, or has been filtered by the -Include or -Exclude parameter..
        /// </summary>
        public static string ItemNotFound {
            get {
                return ResourceManager.GetString("ItemNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot move item because the item at &apos;{0}&apos; does not exist..
        /// </summary>
        public static string MoveItemDoesntExist {
            get {
                return ResourceManager.GetString("MoveItemDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot move item because the item at &apos;{0}&apos; is in use..
        /// </summary>
        public static string MoveItemInUse {
            get {
                return ResourceManager.GetString("MoveItemInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New drive.
        /// </summary>
        public static string NewDriveConfirmAction {
            get {
                return ResourceManager.GetString("NewDriveConfirmAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name: {0} Provider: {1} Root: {2}.
        /// </summary>
        public static string NewDriveConfirmResourceTemplate {
            get {
                return ResourceManager.GetString("NewDriveConfirmResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse path because path &apos;{0}&apos; does not have a qualifier specified..
        /// </summary>
        public static string ParsePathFormatError {
            get {
                return ResourceManager.GetString("ParsePathFormatError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Drive.
        /// </summary>
        public static string RemoveDriveConfirmAction {
            get {
                return ResourceManager.GetString("RemoveDriveConfirmAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name: {0} Provider: {1} Root: {2}.
        /// </summary>
        public static string RemoveDriveConfirmResourceTemplate {
            get {
                return ResourceManager.GetString("RemoveDriveConfirmResourceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot remove drive &apos;{0}&apos; because it is in use..
        /// </summary>
        public static string RemoveDriveInUse {
            get {
                return ResourceManager.GetString("RemoveDriveInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot remove the item at &apos;{0}&apos; because it is in use..
        /// </summary>
        public static string RemoveItemInUse {
            get {
                return ResourceManager.GetString("RemoveItemInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The item at {0} has children and the Recurse parameter was not specified. If you continue, all children will be removed with the item. Are you sure you want to continue?.
        /// </summary>
        public static string RemoveItemWithChildren {
            get {
                return ResourceManager.GetString("RemoveItemWithChildren", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot rename the item at &apos;{0}&apos; because it is in use..
        /// </summary>
        public static string RenamedItemInUse {
            get {
                return ResourceManager.GetString("RenamedItemInUse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot rename because item at &apos;{0}&apos; does not exist..
        /// </summary>
        public static string RenameItemDoesntExist {
            get {
                return ResourceManager.GetString("RenameItemDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rollback.
        /// </summary>
        public static string RollbackAction {
            get {
                return ResourceManager.GetString("RollbackAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set Content.
        /// </summary>
        public static string SetContentAction {
            get {
                return ResourceManager.GetString("SetContentAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path: {0}.
        /// </summary>
        public static string SetContentTarget {
            get {
                return ResourceManager.GetString("SetContentTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current transaction.
        /// </summary>
        public static string TransactionResource {
            get {
                return ResourceManager.GetString("TransactionResource", resourceCulture);
            }
        }
    }
}
