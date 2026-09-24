namespace UnityEngine.InputSystem
{
    [global::System.Serializable]
    public struct InputBinding : global::System.IEquatable<global::UnityEngine.InputSystem.InputBinding>
    {
        [global::System.Flags]
        public enum DisplayStringOptions
        {
            DontUseShortDisplayNames = 1,
            DontOmitDevice = 2,
            DontIncludeInteractions = 4,
            IgnoreBindingOverrides = 8
        }

        [global::System.Flags]
        internal enum MatchOptions
        {
            EmptyGroupMatchesAny = 1
        }

        [global::System.Flags]
        internal enum Flags
        {
            None = 0,
            Composite = 4,
            PartOfComposite = 8
        }

        public const char Separator = ';';
        internal const string kSeparatorString = ";";
        [global::UnityEngine.SerializeField]
        private string m_Name;
        [global::UnityEngine.SerializeField]
        internal string m_Id;
        [global::UnityEngine.SerializeField]
        private string m_Path;
        [global::UnityEngine.SerializeField]
        private string m_Interactions;
        [global::UnityEngine.SerializeField]
        private string m_Processors;
        [global::UnityEngine.SerializeField]
        internal string m_Groups;
        [global::UnityEngine.SerializeField]
        private string m_Action;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputBinding.Flags m_Flags;
        [global::System.NonSerialized]
        private string m_OverridePath;
        [global::System.NonSerialized]
        private string m_OverrideInteractions;
        [global::System.NonSerialized]
        private string m_OverrideProcessors;
        public string name
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::System.Guid id
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public string path
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string overridePath
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string interactions
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string overrideInteractions
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string processors
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string overrideProcessors
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string groups
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public string action
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool isComposite
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool isPartOfComposite
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool hasOverrides => false;
        public string effectivePath => null;
        public string effectiveInteractions => null;
        public string effectiveProcessors => null;
        internal bool isEmpty => false;

        public InputBinding(string path, string action = null, string groups = null, string processors = null, string interactions = null, string name = null)
        {
            m_Name = null;
            m_Id = null;
            m_Path = null;
            m_Interactions = null;
            m_Processors = null;
            m_Groups = null;
            m_Action = null;
            m_Flags = global::UnityEngine.InputSystem.InputBinding.Flags.None;
            m_OverridePath = null;
            m_OverrideInteractions = null;
            m_OverrideProcessors = null;
        }

        public string GetNameOfComposite()
        {
            return null;
        }

        internal void GenerateId()
        {
        }

        internal void RemoveOverrides()
        {
        }

        public static global::UnityEngine.InputSystem.InputBinding MaskByGroup(string group)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.InputBinding MaskByGroups(params string[] groups)
        {
            return default;
        }

        public bool Equals(global::UnityEngine.InputSystem.InputBinding other)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public static bool operator ==(global::UnityEngine.InputSystem.InputBinding left, global::UnityEngine.InputSystem.InputBinding right)
        {
            return false;
        }

        public static bool operator !=(global::UnityEngine.InputSystem.InputBinding left, global::UnityEngine.InputSystem.InputBinding right)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }

        public string ToDisplayString(global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions options = (global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions)0, global::UnityEngine.InputSystem.InputControl control = null)
        {
            return null;
        }

        public string ToDisplayString(out string deviceLayoutName, out string controlPath, global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions options = (global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions)0, global::UnityEngine.InputSystem.InputControl control = null)
        {
            deviceLayoutName = null;
            controlPath = null;
            return null;
        }

        internal bool TriggersAction(global::UnityEngine.InputSystem.InputAction action)
        {
            return false;
        }

        public bool Matches(global::UnityEngine.InputSystem.InputBinding binding)
        {
            return false;
        }

        internal bool Matches(ref global::UnityEngine.InputSystem.InputBinding binding, global::UnityEngine.InputSystem.InputBinding.MatchOptions options = (global::UnityEngine.InputSystem.InputBinding.MatchOptions)0)
        {
            return false;
        }
    }
}