﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeControl.Node.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TradeControl.Node.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Error log write failure. Check file permissions on {0}..
        /// </summary>
        internal static string ErrorLogFailure {
            get {
                return ResourceManager.GetString("ErrorLogFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Timestamp, Message, Source, Target, Inner Message.
        /// </summary>
        internal static string ErrorLogHeader {
            get {
                return ResourceManager.GetString("ErrorLogHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Node Creation Script - SCHEMA + LOGIC + CONTROL DATA
        ///Release: 3.23.1
        ///
        ///Date: 1 August 2019
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///***********************************************************************************/
        ///go
        ///CREATE SCHEMA Activi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_create_node {
            get {
                return ResourceManager.GetString("tc_create_node", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Node Configuration Procedures
        ///Release: 3.23.2
        ///
        ///Date: 1 August 2019
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the upgade into App.tbInstall.
        ///
        ///******** [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_23_2 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_23_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.24.1
        ///
        ///Date: 1 August 2019
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Purpose:
        ///Demonstrates how upgrades are applied.
        ///The script removes all references to Fax Machines from the schema.
        ///
        ///Instructions:
        ///This script s [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_24_1 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_24_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.24.2
        ///
        ///Date: 10 September 2019
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Fix:
        ///- trigger new current balance when OpeningBalance updated 
        ///- include opening balance in the current balance in new accounts
        ///- cast Entry [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_24_2 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_24_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.24.3
        ///
        ///Date: 18 October 2019
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Fix:
        ///- Task.proc_Configure inserting empty contact names into Org.tbContact
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Config [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_24_3 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_24_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.24.4
        ///
        ///Date: 21 October 2019
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Fix:
        ///- Drop redundant column Cash.tbCode.OpeningBalance
        ///- Cash.vwStatement invoiced vat not carrying over before first payment
        ///
        ///Instructions:        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_24_4 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_24_4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.24.5
        ///
        ///Date: 31 January 2020
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inse [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_24_5 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_24_5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.24.6
        ///
        ///Date: 31 January 2020
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inse [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_24_6 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_24_6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.25.1
        ///
        ///Date: 29 February 2020
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It ins [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_25_1 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_25_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.26.1
        ///
        ///Date: 06 April 2020
        ///Author: Ian Monnox
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It insert [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_26_1 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_26_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.27.1
        ///
        ///Date: 01 May 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the upg [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_27_1 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_27_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.28.1
        ///
        ///Date: 01 July 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the up [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_28_1 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_28_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.28.2
        ///
        ///Date: 01 July 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the up [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_28_2 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_28_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.28.3
        ///
        ///Date: 01 July 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the up [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_28_3 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_28_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.28.4
        ///
        ///Date: 01 August 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_28_4 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_28_4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.28.5
        ///
        ///Date: 12 August 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_28_5 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_28_5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.29.1
        ///
        ///Date: 14 August 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_29_1 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_29_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.29.2
        ///
        ///Date: 14 August 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts the  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_29_2 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_29_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.29.3
        ///
        ///Date: 3 September 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts th [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_29_3 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_29_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.29.4
        ///
        ///Date: 14 September 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_29_4 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_29_4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.30.1
        ///
        ///Date: 18 September 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_30_1 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_30_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.30.2
        ///
        ///Date: 24 September 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the TC Node Configuration app.
        ///It inserts t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_30_2 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_30_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.30.3
        ///
        ///Date: 1 October 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the Node Configuration app.
        ///
        ///**************** [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_30_3 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_30_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.30.4
        ///
        ///Date: 8 October 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the Node Configuration app.
        ///
        ///**************** [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_30_4 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_30_4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.30.5
        ///
        ///Date: 12 October 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the Node Configuration app.
        ///
        ///*************** [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_30_5 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_30_5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.30.6
        ///
        ///Date: 5 Novemeber 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the Node Configuration app.
        ///
        ///************** [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_30_6 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_30_6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.31.1
        ///
        ///Date: 6 January 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the Node Configuration app.
        ///
        ///**************** [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_31_1 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_31_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /**************************************************************************************
        ///Trade Control
        ///Upgrade script
        ///Release: 3.31.2
        ///
        ///Date: 15 January 2020
        ///Author: IAM
        ///
        ///Trade Control by Trade Control Ltd is licensed under GNU General Public License v3.0. 
        ///
        ///You may obtain a copy of the License at
        ///
        ///	https://www.gnu.org/licenses/gpl-3.0.en.html
        ///
        ///Change log:
        ///
        ///	https://github.com/tradecontrol/sqlnode
        ///
        ///Instructions:
        ///This script should be applied by the Node Configuration app.
        ///
        ///*************** [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string tc_upgrade_3_31_2 {
            get {
                return ResourceManager.GetString("tc_upgrade_3_31_2", resourceCulture);
            }
        }
    }
}
