﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HK.Modding.Analyzer {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HK.Modding.Analyzer.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似  的本地化字符串。
        /// </summary>
        public static string HKM_Error_Desc {
            get {
                return ResourceManager.GetString("HKM_Error_Desc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 IL Offset: {0}  Excpetion: {1} 的本地化字符串。
        /// </summary>
        public static string HKM_Error_Msg {
            get {
                return ResourceManager.GetString("HKM_Error_Msg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Excpetion 的本地化字符串。
        /// </summary>
        public static string HKM_Error_Title {
            get {
                return ResourceManager.GetString("HKM_Error_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}(...) was not called before the hook exited 的本地化字符串。
        /// </summary>
        public static string HKM001_Format {
            get {
                return ResourceManager.GetString("HKM001_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}(...) not called 的本地化字符串。
        /// </summary>
        public static string HKM001_Title {
            get {
                return ResourceManager.GetString("HKM001_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Assign {0} to other fields/properties/events 的本地化字符串。
        /// </summary>
        public static string HKM002_Format {
            get {
                return ResourceManager.GetString("HKM002_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} leaks 的本地化字符串。
        /// </summary>
        public static string HKM002_Title {
            get {
                return ResourceManager.GetString("HKM002_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Call ModHooks.{0} before the mods are loaded 的本地化字符串。
        /// </summary>
        public static string HKM003_Format {
            get {
                return ResourceManager.GetString("HKM003_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Call ModHooks.{0} before the mods are loaded 的本地化字符串。
        /// </summary>
        public static string HKM003_Title {
            get {
                return ResourceManager.GetString("HKM003_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use {0}.UnsafeInstance replaces {0}.instance to determine if {0} exists 的本地化字符串。
        /// </summary>
        public static string HKM004_Format {
            get {
                return ResourceManager.GetString("HKM004_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use {0}.UnsafeInstance replaces {0}.instance 的本地化字符串。
        /// </summary>
        public static string HKM004_Title {
            get {
                return ResourceManager.GetString("HKM004_Title", resourceCulture);
            }
        }
    }
}
