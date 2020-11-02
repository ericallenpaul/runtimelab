﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Interop {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Interop.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to A type marked with &apos;BlittableTypeAttribute&apos; must be blittable..
        /// </summary>
        internal static string BlittableTypeMustBeBlittableDescription {
            get {
                return ResourceManager.GetString("BlittableTypeMustBeBlittableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is marked with &apos;BlittableTypeAttribute&apos; but is not blittable.
        /// </summary>
        internal static string BlittableTypeMustBeBlittableMessage {
            get {
                return ResourceManager.GetString("BlittableTypeMustBeBlittableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;BlittableTypeAttribute&apos; and &apos;NativeMarshallingAttribute&apos; attributes are mutually exclusive..
        /// </summary>
        internal static string CannotHaveMultipleMarshallingAttributesDescription {
            get {
                return ResourceManager.GetString("CannotHaveMultipleMarshallingAttributesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is marked with &apos;BlittableTypeAttribute&apos; and &apos;NativeMarshallingAttribute&apos;. A type can only have one of these two attributes..
        /// </summary>
        internal static string CannotHaveMultipleMarshallingAttributesMessage {
            get {
                return ResourceManager.GetString("CannotHaveMultipleMarshallingAttributesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source-generated P/Invokes will ignore any configuration that is not supported..
        /// </summary>
        internal static string ConfigurationNotSupportedDescription {
            get {
                return ResourceManager.GetString("ConfigurationNotSupportedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; configuration is not supported by source-generated P/Invokes. If the specified configuration is required, use a regular `DllImport` instead..
        /// </summary>
        internal static string ConfigurationNotSupportedMessage {
            get {
                return ResourceManager.GetString("ConfigurationNotSupportedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified &apos;{0}&apos; configuration for parameter &apos;{1}&apos; is not supported by source-generated P/Invokes. If the specified configuration is required, use a regular `DllImport` instead..
        /// </summary>
        internal static string ConfigurationNotSupportedMessageParameter {
            get {
                return ResourceManager.GetString("ConfigurationNotSupportedMessageParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified &apos;{0}&apos; configuration for the return value of method &apos;{1}&apos; is not supported by source-generated P/Invokes. If the specified configuration is required, use a regular `DllImport` instead..
        /// </summary>
        internal static string ConfigurationNotSupportedMessageReturn {
            get {
                return ResourceManager.GetString("ConfigurationNotSupportedMessageReturn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified value &apos;{0}&apos; for &apos;{1}&apos; is not supported by source-generated P/Invokes. If the specified configuration is required, use a regular `DllImport` instead..
        /// </summary>
        internal static string ConfigurationNotSupportedMessageValue {
            get {
                return ResourceManager.GetString("ConfigurationNotSupportedMessageValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified configuration is not supported by source-generated P/Invokes..
        /// </summary>
        internal static string ConfigurationNotSupportedTitle {
            get {
                return ResourceManager.GetString("ConfigurationNotSupportedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Methods marked with &apos;GeneratedDllImportAttribute&apos; should be &apos;static&apos; and &apos;partial&apos;. P/Invoke source generation will ignore methods that are not &apos;static&apos; and &apos;partial&apos;..
        /// </summary>
        internal static string GeneratedDllImportMissingModifiersDescription {
            get {
                return ResourceManager.GetString("GeneratedDllImportMissingModifiersDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; should be &apos;static&apos; and &apos;partial&apos; when marked with &apos;GeneratedDllImportAttribute&apos;. P/Invoke source generation will ignore methods that are not &apos;static&apos; and &apos;partial&apos;..
        /// </summary>
        internal static string GeneratedDllImportMissingModifiersMessage {
            get {
                return ResourceManager.GetString("GeneratedDllImportMissingModifiersMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method marked with &apos;GeneratedDllImportAttribute&apos; should be &apos;static&apos; and &apos;partial&apos;.
        /// </summary>
        internal static string GeneratedDllImportMissingModifiersTitle {
            get {
                return ResourceManager.GetString("GeneratedDllImportMissingModifiersTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The return type of &apos;GetPinnableReference&apos; (after accounting for &apos;ref&apos;) must be blittable..
        /// </summary>
        internal static string GetPinnableReferenceReturnTypeBlittableDescription {
            get {
                return ResourceManager.GetString("GetPinnableReferenceReturnTypeBlittableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The dereferenced type of the return type of the &apos;GetPinnableReference&apos; method must be blittable.
        /// </summary>
        internal static string GetPinnableReferenceReturnTypeBlittableMessage {
            get {
                return ResourceManager.GetString("GetPinnableReferenceReturnTypeBlittableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A type that supports marshalling from managed to native by pinning should also support marshalling from managed to native where pinning is impossible..
        /// </summary>
        internal static string GetPinnableReferenceShouldSupportAllocatingMarshallingFallbackDescription {
            get {
                return ResourceManager.GetString("GetPinnableReferenceShouldSupportAllocatingMarshallingFallbackDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has a &apos;GetPinnableReference&apos; method but its native type does not support marshalling in scenarios where pinning is impossible.
        /// </summary>
        internal static string GetPinnableReferenceShouldSupportAllocatingMarshallingFallbackMessage {
            get {
                return ResourceManager.GetString("GetPinnableReferenceShouldSupportAllocatingMarshallingFallbackMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marshalling char with &apos;CharSet.{0}&apos; is not supported. Instead, manually convert the char type to the desired byte representation and pass to the source-generated P/Invoke..
        /// </summary>
        internal static string MarshallingCharAsSpecifiedCharSetNotSupported {
            get {
                return ResourceManager.GetString("MarshallingCharAsSpecifiedCharSetNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marshalling string or char without explicit marshalling information is not supported. Specify either &apos;GeneratedDllImportAttribute.CharSet&apos; or &apos;MarshalAsAttribute&apos;..
        /// </summary>
        internal static string MarshallingStringOrCharAsUndefinedNotSupported {
            get {
                return ResourceManager.GetString("MarshallingStringOrCharAsUndefinedNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A native type for a given type must be blittable..
        /// </summary>
        internal static string NativeTypeMustBeBlittableDescription {
            get {
                return ResourceManager.GetString("NativeTypeMustBeBlittableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type &apos;{0}&apos; for the type &apos;{1}&apos; is not blittable.
        /// </summary>
        internal static string NativeTypeMustBeBlittableMessage {
            get {
                return ResourceManager.GetString("NativeTypeMustBeBlittableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A native type for a given type must be non-null..
        /// </summary>
        internal static string NativeTypeMustBeNonNullDescription {
            get {
                return ResourceManager.GetString("NativeTypeMustBeNonNullDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type for the type &apos;{0}&apos; is null.
        /// </summary>
        internal static string NativeTypeMustBeNonNullMessage {
            get {
                return ResourceManager.GetString("NativeTypeMustBeNonNullMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type must be pointer sized so the pinned result of &apos;GetPinnableReference&apos; can be cast to the native type..
        /// </summary>
        internal static string NativeTypeMustBePointerSizedDescription {
            get {
                return ResourceManager.GetString("NativeTypeMustBePointerSizedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type &apos;{0}&apos; must be pointer sized because the managed type &apos;{1}&apos; has a &apos;GetPinnableReference&apos; method.
        /// </summary>
        internal static string NativeTypeMustBePointerSizedMessage {
            get {
                return ResourceManager.GetString("NativeTypeMustBePointerSizedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type must have at least one of the two marshalling methods to enable marshalling the managed type..
        /// </summary>
        internal static string NativeTypeMustHaveRequiredShapeDescription {
            get {
                return ResourceManager.GetString("NativeTypeMustHaveRequiredShapeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type &apos;{0}&apos; must be a value type and have a constructor that takes one parameter of type &apos;{1}&apos; or a parameterless instance method named &apos;ToManaged&apos; that returns &apos;{1}&apos;.
        /// </summary>
        internal static string NativeTypeMustHaveRequiredShapeMessage {
            get {
                return ResourceManager.GetString("NativeTypeMustHaveRequiredShapeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When constructor taking a Span&lt;byte&gt; is specified on the native type, the type must also have a public integer constant named StackBufferSize to provide the size of the stack-allocated buffer..
        /// </summary>
        internal static string StackallocConstructorMustHaveStackBufferSizeConstantDescription {
            get {
                return ResourceManager.GetString("StackallocConstructorMustHaveStackBufferSizeConstantDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type &apos;{0}&apos; must have a &apos;public const int StackBufferSize&apos; field that specifies the size of the stack buffer because it has a constructor that takes a stack-allocated Span&lt;byte&gt;.
        /// </summary>
        internal static string StackallocConstructorMustHaveStackBufferSizeConstantMessage {
            get {
                return ResourceManager.GetString("StackallocConstructorMustHaveStackBufferSizeConstantMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A type that supports marshalling from managed to native by stack allocation should also support marshalling from managed to native where stack allocation is impossible..
        /// </summary>
        internal static string StackallocMarshallingShouldSupportAllocatingMarshallingFallbackDescription {
            get {
                return ResourceManager.GetString("StackallocMarshallingShouldSupportAllocatingMarshallingFallbackDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Native type &apos;{0}&apos; has a stack-allocating constructor does not support marshalling in scenarios where stack allocation is impossible.
        /// </summary>
        internal static string StackallocMarshallingShouldSupportAllocatingMarshallingFallbackMessage {
            get {
                return ResourceManager.GetString("StackallocMarshallingShouldSupportAllocatingMarshallingFallbackMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to P/Invoke source generation is only supported on .NET {0} or above. The generated source will not be compatible with other frameworks..
        /// </summary>
        internal static string TargetFrameworkNotSupportedDescription {
            get {
                return ResourceManager.GetString("TargetFrameworkNotSupportedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;GeneratedDllImportAttribute&apos; cannot be used for source-generated P/Invokes on the current target framework. Source-generated P/Invokes require .NET {0} or above..
        /// </summary>
        internal static string TargetFrameworkNotSupportedMessage {
            get {
                return ResourceManager.GetString("TargetFrameworkNotSupportedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current target framework is not supported by source-generated P/Invokes.
        /// </summary>
        internal static string TargetFrameworkNotSupportedTitle {
            get {
                return ResourceManager.GetString("TargetFrameworkNotSupportedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to For types that are not supported by source-generated P/Invokes, the resulting P/Invoke will rely on the underlying runtime to marshal the specified type..
        /// </summary>
        internal static string TypeNotSupportedDescription {
            get {
                return ResourceManager.GetString("TypeNotSupportedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not supported by source-generated P/Invokes. The generated source will not handle marshalling of parameter &apos;{1}&apos;..
        /// </summary>
        internal static string TypeNotSupportedMessageParameter {
            get {
                return ResourceManager.GetString("TypeNotSupportedMessageParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} The generated source will not handle marshalling of parameter &apos;{1}&apos;..
        /// </summary>
        internal static string TypeNotSupportedMessageParameterWithDetails {
            get {
                return ResourceManager.GetString("TypeNotSupportedMessageParameterWithDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not supported by source-generated P/Invokes. The generated source will not handle marshalling of the return value of method &apos;{1}&apos;..
        /// </summary>
        internal static string TypeNotSupportedMessageReturn {
            get {
                return ResourceManager.GetString("TypeNotSupportedMessageReturn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} The generated source will not handle marshalling of the return value of method &apos;{1}&apos;..
        /// </summary>
        internal static string TypeNotSupportedMessageReturnWithDetails {
            get {
                return ResourceManager.GetString("TypeNotSupportedMessageReturnWithDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified type is not supported by source-generated P/Invokes.
        /// </summary>
        internal static string TypeNotSupportedTitle {
            get {
                return ResourceManager.GetString("TypeNotSupportedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type&apos;s &apos;Value&apos; property must have a getter to support marshalling from managed to native..
        /// </summary>
        internal static string ValuePropertyMustHaveGetterDescription {
            get {
                return ResourceManager.GetString("ValuePropertyMustHaveGetterDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Value&apos; property on the native type &apos;{0}&apos; must have a getter.
        /// </summary>
        internal static string ValuePropertyMustHaveGetterMessage {
            get {
                return ResourceManager.GetString("ValuePropertyMustHaveGetterMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The native type&apos;s &apos;Value&apos; property must have a setter to support marshalling from native to managed..
        /// </summary>
        internal static string ValuePropertyMustHaveSetterDescription {
            get {
                return ResourceManager.GetString("ValuePropertyMustHaveSetterDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Value&apos; property on the native type &apos;{0}&apos; must have a setter.
        /// </summary>
        internal static string ValuePropertyMustHaveSetterMessage {
            get {
                return ResourceManager.GetString("ValuePropertyMustHaveSetterMessage", resourceCulture);
            }
        }
    }
}
