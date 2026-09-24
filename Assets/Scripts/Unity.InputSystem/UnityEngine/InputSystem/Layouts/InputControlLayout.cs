namespace UnityEngine.InputSystem.Layouts
{
    public class InputControlLayout
    {
        public struct ControlItem
        {
            [global::System.Flags]
            private enum Flags
            {
                isModifyingExistingControl = 1,
                IsNoisy = 2,
                IsSynthetic = 4,
                IsFirstDefinedInThisLayout = 8,
                DontReset = 0x10
            }

            public global::UnityEngine.InputSystem.Utilities.InternedString name { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.InternedString layout { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.InternedString variants { get; internal set; }
            public string useStateFrom { get; internal set; }
            public string displayName { get; internal set; }
            public string shortDisplayName { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.InternedString> usages { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.InternedString> aliases { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.NamedValue> parameters { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.NameAndParameters> processors { get; internal set; }
            public uint offset { get; internal set; }
            public uint bit { get; internal set; }
            public uint sizeInBits { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.FourCC format { get; internal set; }
            private global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem.Flags flags { get; set; }
            public int arraySize { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.PrimitiveValue defaultState { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.PrimitiveValue minValue { get; internal set; }
            public global::UnityEngine.InputSystem.Utilities.PrimitiveValue maxValue { get; internal set; }

            public bool isModifyingExistingControl
            {
                get
                {
                    return false;
                }

                internal set
                {
                }
            }

            public bool isNoisy
            {
                get
                {
                    return false;
                }

                internal set
                {
                }
            }

            public bool isSynthetic
            {
                get
                {
                    return false;
                }

                internal set
                {
                }
            }

            public bool dontReset
            {
                get
                {
                    return false;
                }

                internal set
                {
                }
            }

            public bool isFirstDefinedInThisLayout
            {
                get
                {
                    return false;
                }

                internal set
                {
                }
            }

            public bool isArray => false;

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem Merge(global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem other)
            {
                return default;
            }
        }

        public class Builder
        {
            public struct ControlBuilder
            {
                internal global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder builder;
                internal int index;
                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDisplayName(string displayName)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithLayout(string layout)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(global::UnityEngine.InputSystem.Utilities.FourCC format)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithFormat(string format)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithByteOffset(uint offset)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithBitOffset(uint bit)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsSynthetic(bool value)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder IsNoisy(bool value)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder DontReset(bool value)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithSizeInBits(uint sizeInBits)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithRange(float minValue, float maxValue)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(params global::UnityEngine.InputSystem.Utilities.InternedString[] usages)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(global::System.Collections.Generic.IEnumerable<string> usages)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithUsages(params string[] usages)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithParameters(string parameters)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithProcessors(string processors)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder WithDefaultState(global::UnityEngine.InputSystem.Utilities.PrimitiveValue value)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder UsingStateFrom(string path)
                {
                    return default;
                }

                public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AsArrayOfControlsWithSize(int arraySize)
                {
                    return default;
                }
            }

            private string m_ExtendsLayout;
            private int m_ControlCount;
            private global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] m_Controls;
            public string name { get; set; }
            public string displayName { get; set; }
            public global::System.Type type { get; set; }
            public global::UnityEngine.InputSystem.Utilities.FourCC stateFormat { get; set; }
            public int stateSizeInBytes { get; set; }

            public string extendsLayout
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public bool? updateBeforeRender { get; set; }
            public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controls => default;

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder.ControlBuilder AddControl(string name)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithName(string name)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithDisplayName(string displayName)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithType<T>()
                where T : global::UnityEngine.InputSystem.InputControl
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(global::UnityEngine.InputSystem.Utilities.FourCC format)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithFormat(string format)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder WithSizeInBytes(int sizeInBytes)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.Builder Extend(string baseLayoutName)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout Build()
            {
                return null;
            }
        }

        [global::System.Flags]
        private enum Flags
        {
            IsGenericTypeOfDevice = 1,
            HideInUI = 2,
            IsOverride = 4,
            CanRunInBackground = 8,
            CanRunInBackgroundIsSet = 0x10,
            IsNoisy = 0x20
        }

        [global::System.Serializable]
        internal struct LayoutJsonNameAndDescriptorOnly
        {
            public string name;
            public string extend;
            public string[] extendMultiple;
            public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher.MatcherJson device;
        }

        [global::System.Serializable]
        private struct LayoutJson
        {
            public string name;
            public string extend;
            public string[] extendMultiple;
            public string format;
            public string beforeRender;
            public string runInBackground;
            public string[] commonUsages;
            public string displayName;
            public string description;
            public string type;
            public string variant;
            public bool isGenericTypeOfDevice;
            public bool hideInUI;
            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[] controls;
            public global::UnityEngine.InputSystem.Layouts.InputControlLayout ToLayout()
            {
                return null;
            }

            public static global::UnityEngine.InputSystem.Layouts.InputControlLayout.LayoutJson FromLayout(global::UnityEngine.InputSystem.Layouts.InputControlLayout layout)
            {
                return default;
            }
        }

        [global::System.Serializable]
        private class ControlItemJson
        {
            public string name;
            public string layout;
            public string variants;
            public string usage;
            public string alias;
            public string useStateFrom;
            public uint offset;
            public uint bit;
            public uint sizeInBits;
            public string format;
            public int arraySize;
            public string[] usages;
            public string[] aliases;
            public string parameters;
            public string processors;
            public string displayName;
            public string shortDisplayName;
            public bool noisy;
            public bool dontReset;
            public bool synthetic;
            public string defaultState;
            public string minValue;
            public string maxValue;
            public global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem ToLayout()
            {
                return default;
            }

            public static global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItemJson[] FromControlItems(global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] items)
            {
                return null;
            }
        }

        internal struct Collection
        {
            public struct LayoutMatcher
            {
                public global::UnityEngine.InputSystem.Utilities.InternedString layoutName;
                public global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher;
            }

            public struct PrecompiledLayout
            {
                public global::System.Func<global::UnityEngine.InputSystem.InputDevice> factoryMethod;
                public string metadata;
            }

            public const float kBaseScoreForNonGeneratedLayouts = 1f;
            public global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, global::System.Type> layoutTypes;
            public global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, string> layoutStrings;
            public global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, global::System.Func<global::UnityEngine.InputSystem.Layouts.InputControlLayout>> layoutBuilders;
            public global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, global::UnityEngine.InputSystem.Utilities.InternedString> baseLayoutTable;
            public global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, global::UnityEngine.InputSystem.Utilities.InternedString[]> layoutOverrides;
            public global::System.Collections.Generic.HashSet<global::UnityEngine.InputSystem.Utilities.InternedString> layoutOverrideNames;
            public global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, global::UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.PrecompiledLayout> precompiledLayouts;
            public global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputControlLayout.Collection.LayoutMatcher> layoutMatchers;
            public void Allocate()
            {
            }

            public global::UnityEngine.InputSystem.Utilities.InternedString TryFindLayoutForType(global::System.Type layoutType)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.Utilities.InternedString TryFindMatchingLayout(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription)
            {
                return default;
            }

            public bool HasLayout(global::UnityEngine.InputSystem.Utilities.InternedString name)
            {
                return false;
            }

            private global::UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayoutInternal(global::UnityEngine.InputSystem.Utilities.InternedString name)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout TryLoadLayout(global::UnityEngine.InputSystem.Utilities.InternedString name, global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, global::UnityEngine.InputSystem.Layouts.InputControlLayout> table = null)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.Utilities.InternedString GetBaseLayoutName(global::UnityEngine.InputSystem.Utilities.InternedString layoutName)
            {
                return default;
            }

            public global::UnityEngine.InputSystem.Utilities.InternedString GetRootLayoutName(global::UnityEngine.InputSystem.Utilities.InternedString layoutName)
            {
                return default;
            }

            public bool ComputeDistanceInInheritanceHierarchy(global::UnityEngine.InputSystem.Utilities.InternedString firstLayout, global::UnityEngine.InputSystem.Utilities.InternedString secondLayout, out int distance)
            {
                distance = default;
                return false;
            }

            public global::UnityEngine.InputSystem.Utilities.InternedString FindLayoutThatIntroducesControl(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache)
            {
                return default;
            }

            public global::System.Type GetControlTypeForLayout(global::UnityEngine.InputSystem.Utilities.InternedString layoutName)
            {
                return null;
            }

            public bool ValueTypeIsAssignableFrom(global::UnityEngine.InputSystem.Utilities.InternedString layoutName, global::System.Type valueType)
            {
                return false;
            }

            public bool IsGeneratedLayout(global::UnityEngine.InputSystem.Utilities.InternedString layout)
            {
                return false;
            }

            public global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Utilities.InternedString> GetBaseLayouts(global::UnityEngine.InputSystem.Utilities.InternedString layout, bool includeSelf = true)
            {
                return null;
            }

            public bool IsBasedOn(global::UnityEngine.InputSystem.Utilities.InternedString parentLayout, global::UnityEngine.InputSystem.Utilities.InternedString childLayout)
            {
                return false;
            }

            public void AddMatcher(global::UnityEngine.InputSystem.Utilities.InternedString layout, global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher matcher)
            {
            }
        }

        public class LayoutNotFoundException : global::System.Exception
        {
            public string layout { get; }

            public LayoutNotFoundException()
            {
            }

            public LayoutNotFoundException(string name, string message)
            {
            }

            public LayoutNotFoundException(string name)
            {
            }

            public LayoutNotFoundException(string message, global::System.Exception innerException)
            {
            }

            protected LayoutNotFoundException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
            {
            }
        }

        internal struct Cache
        {
            public global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.Utilities.InternedString, global::UnityEngine.InputSystem.Layouts.InputControlLayout> table;
            public void Clear()
            {
            }

            public global::UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true)
            {
                return null;
            }
        }

        internal struct CacheRefInstance : global::System.IDisposable
        {
            public bool valid;
            public void Dispose()
            {
            }
        }

        private static global::UnityEngine.InputSystem.Utilities.InternedString s_DefaultVariant;
        public const string VariantSeparator = ";";
        private global::UnityEngine.InputSystem.Utilities.InternedString m_Name;
        private global::System.Type m_Type;
        private global::UnityEngine.InputSystem.Utilities.InternedString m_Variants;
        private global::UnityEngine.InputSystem.Utilities.FourCC m_StateFormat;
        internal int m_StateSizeInBytes;
        internal bool? m_UpdateBeforeRender;
        internal global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.Utilities.InternedString> m_BaseLayouts;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.Utilities.InternedString> m_AppliedOverrides;
        private global::UnityEngine.InputSystem.Utilities.InternedString[] m_CommonUsages;
        internal global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] m_Controls;
        internal string m_DisplayName;
        private string m_Description;
        private global::UnityEngine.InputSystem.Layouts.InputControlLayout.Flags m_Flags;
        internal static global::UnityEngine.InputSystem.Layouts.InputControlLayout.Collection s_Layouts;
        internal static global::UnityEngine.InputSystem.Layouts.InputControlLayout.Cache s_CacheInstance;
        internal static int s_CacheInstanceRef;
        public static global::UnityEngine.InputSystem.Utilities.InternedString DefaultVariant => default;
        public global::UnityEngine.InputSystem.Utilities.InternedString name => default;
        public string displayName => null;
        public global::System.Type type => null;
        public global::UnityEngine.InputSystem.Utilities.InternedString variants => default;
        public global::UnityEngine.InputSystem.Utilities.FourCC stateFormat => default;
        public int stateSizeInBytes => 0;
        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Utilities.InternedString> baseLayouts => null;
        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.Utilities.InternedString> appliedOverrides => null;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Utilities.InternedString> commonUsages => default;
        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controls => default;
        public bool updateBeforeRender => false;
        public bool isDeviceLayout => false;
        public bool isControlLayout => false;

        public bool isOverride
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        public bool isGenericTypeOfDevice
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        public bool hideInUI
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        public bool isNoisy
        {
            get
            {
                return false;
            }

            internal set
            {
            }
        }

        public bool? canRunInBackground
        {
            get
            {
                return null;
            }

            internal set
            {
            }
        }

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem this[string path]
        {
            get
            {
                return default;
            }
        }

        internal static ref global::UnityEngine.InputSystem.Layouts.InputControlLayout.Cache cache
        {
            get
            {
                throw null;
            }
        }

        public global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem? FindControl(global::UnityEngine.InputSystem.Utilities.InternedString path)
        {
            return null;
        }

        public global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem? FindControlIncludingArrayElements(string path, out int arrayIndex)
        {
            arrayIndex = default;
            return null;
        }

        public global::System.Type GetValueType()
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Layouts.InputControlLayout FromType(string name, global::System.Type type)
        {
            return null;
        }

        public string ToJson()
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Layouts.InputControlLayout FromJson(string json)
        {
            return null;
        }

        private InputControlLayout(string name, global::System.Type type)
        {
        }

        private static void AddControlItems(global::System.Type type, global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName)
        {
        }

        private static void AddControlItemsFromFields(global::System.Type type, global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName)
        {
        }

        private static void AddControlItemsFromProperties(global::System.Type type, global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlLayouts, string layoutName)
        {
        }

        private static void AddControlItemsFromMembers(global::System.Reflection.MemberInfo[] members, global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems, string layoutName)
        {
        }

        private static void AddControlItemsFromMember(global::System.Reflection.MemberInfo member, global::UnityEngine.InputSystem.Layouts.InputControlAttribute[] attributes, global::System.Collections.Generic.List<global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> controlItems)
        {
        }

        private static global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem CreateControlItemFromMember(global::System.Reflection.MemberInfo member, global::UnityEngine.InputSystem.Layouts.InputControlAttribute attribute)
        {
            return default;
        }

        private static string InferLayoutFromValueType(global::System.Type type)
        {
            return null;
        }

        public void MergeLayout(global::UnityEngine.InputSystem.Layouts.InputControlLayout other)
        {
        }

        private static global::System.Collections.Generic.Dictionary<string, global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> CreateLookupTableForControls(global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem[] controlItems, global::System.Collections.Generic.List<string> variants = null)
        {
            return null;
        }

        internal static bool VariantsMatch(global::UnityEngine.InputSystem.Utilities.InternedString expected, global::UnityEngine.InputSystem.Utilities.InternedString actual)
        {
            return false;
        }

        internal static bool VariantsMatch(string expected, string actual)
        {
            return false;
        }

        internal static void ParseHeaderFieldsFromJson(string json, out global::UnityEngine.InputSystem.Utilities.InternedString name, out global::UnityEngine.InputSystem.Utilities.InlinedArray<global::UnityEngine.InputSystem.Utilities.InternedString> baseLayouts, out global::UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher)
        {
            name = default;
            baseLayouts = default;
            deviceMatcher = default;
        }

        internal static global::UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstance CacheRef()
        {
            return default;
        }
    }
}