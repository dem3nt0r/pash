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
    public class ServiceResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ServiceResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerShell.Commands.Management.ServiceResources", typeof(ServiceResources).Assembly);
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
        ///   Looks up a localized string similar to The command cannot be used to configure the service &apos;{0}&apos; because access to computer &apos;{1}&apos; is denied. Run Windows PowerShell as admin and run your command again..
        /// </summary>
        public static string ComputerAccessDenied {
            get {
                return ResourceManager.GetString("ComputerAccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;Cannot access dependent services of &apos;{1} ({0})&apos;.
        /// </summary>
        public static string CouldNotAccessDependentServices {
            get {
                return ResourceManager.GetString("CouldNotAccessDependentServices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be created due to the following error: {2}.
        /// </summary>
        public static string CouldNotNewService {
            get {
                return ResourceManager.GetString("CouldNotNewService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; was created, but its description cannot be configured due to the following error: {2}.
        /// </summary>
        public static string CouldNotNewServiceDescription {
            get {
                return ResourceManager.GetString("CouldNotNewServiceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be resumed due to the following error: {2}.
        /// </summary>
        public static string CouldNotResumeService {
            get {
                return ResourceManager.GetString("CouldNotResumeService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be resumed because it is not currently running..
        /// </summary>
        public static string CouldNotResumeServiceNotRunning {
            get {
                return ResourceManager.GetString("CouldNotResumeServiceNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be resumed because the service does not support being suspended or resumed..
        /// </summary>
        public static string CouldNotResumeServiceNotSupported {
            get {
                return ResourceManager.GetString("CouldNotResumeServiceNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be configured due to the following error: {2}.
        /// </summary>
        public static string CouldNotSetService {
            get {
                return ResourceManager.GetString("CouldNotSetService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; description cannot be configured due to the following error: {2}.
        /// </summary>
        public static string CouldNotSetServiceDescription {
            get {
                return ResourceManager.GetString("CouldNotSetServiceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be started due to the following error: {2}.
        /// </summary>
        public static string CouldNotStartService {
            get {
                return ResourceManager.GetString("CouldNotStartService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be stopped due to the following error: {2}.
        /// </summary>
        public static string CouldNotStopService {
            get {
                return ResourceManager.GetString("CouldNotStopService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be suspended due to the following error: {2}.
        /// </summary>
        public static string CouldNotSuspendService {
            get {
                return ResourceManager.GetString("CouldNotSuspendService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be suspended because it is not currently running..
        /// </summary>
        public static string CouldNotSuspendServiceNotRunning {
            get {
                return ResourceManager.GetString("CouldNotSuspendServiceNotRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; cannot be suspended because the service does not support being suspended or resumed..
        /// </summary>
        public static string CouldNotSuspendServiceNotSupported {
            get {
                return ResourceManager.GetString("CouldNotSuspendServiceNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any service with display name &apos;{1}&apos;..
        /// </summary>
        public static string NoServiceFoundForGivenDisplayName {
            get {
                return ResourceManager.GetString("NoServiceFoundForGivenDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any service with service name &apos;{0}&apos;..
        /// </summary>
        public static string NoServiceFoundForGivenName {
            get {
                return ResourceManager.GetString("NoServiceFoundForGivenName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; resume failed..
        /// </summary>
        public static string ResumeServiceFailed {
            get {
                return ResourceManager.GetString("ResumeServiceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for service &apos;{1} ({0})&apos; to resume....
        /// </summary>
        public static string ResumingService {
            get {
                return ResourceManager.GetString("ResumingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot stop service &apos;{1} ({0})&apos; because it has dependent services. It can only be stopped if the Force flag is set..
        /// </summary>
        public static string ServiceHasDependentServices {
            get {
                return ResourceManager.GetString("ServiceHasDependentServices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot stop service &apos;{1} ({0})&apos; because it has dependent services..
        /// </summary>
        public static string ServiceHasDependentServicesNoForce {
            get {
                return ResourceManager.GetString("ServiceHasDependentServicesNoForce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot stop service &apos;{1} ({0})&apos; because it is dependent on other services..
        /// </summary>
        public static string ServiceIsDependentOnNoForce {
            get {
                return ResourceManager.GetString("ServiceIsDependentOnNoForce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} ({1}).
        /// </summary>
        public static string ServiceNameForConfirmation {
            get {
                return ResourceManager.GetString("ServiceNameForConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for service &apos;{1} ({0})&apos; to start....
        /// </summary>
        public static string StartingService {
            get {
                return ResourceManager.GetString("StartingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to start service &apos;{1} ({0})&apos;..
        /// </summary>
        public static string StartServiceFailed {
            get {
                return ResourceManager.GetString("StartServiceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for service &apos;{1} ({0})&apos; to stop....
        /// </summary>
        public static string StoppingService {
            get {
                return ResourceManager.GetString("StoppingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; stop failed..
        /// </summary>
        public static string StopServiceFailed {
            get {
                return ResourceManager.GetString("StopServiceFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for service &apos;{1} ({0})&apos; to suspend....
        /// </summary>
        public static string SuspendingService {
            get {
                return ResourceManager.GetString("SuspendingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service &apos;{1} ({0})&apos; suspend failed..
        /// </summary>
        public static string SuspendServiceFailed {
            get {
                return ResourceManager.GetString("SuspendServiceFailed", resourceCulture);
            }
        }
    }
}