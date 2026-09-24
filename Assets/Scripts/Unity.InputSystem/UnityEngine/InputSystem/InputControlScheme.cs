namespace UnityEngine.InputSystem
{
    [global::System.Serializable]
    public struct InputControlScheme : global::System.IEquatable<global::UnityEngine.InputSystem.InputControlScheme>
    {
        public struct MatchResult : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControlScheme.MatchResult.Match>, global::System.Collections.IEnumerable, global::System.IDisposable
        {
            internal enum Result
            {
                AllSatisfied = 0,
                MissingRequired = 1,
                MissingOptional = 2
            }

            public struct Match
            {
                internal int m_RequirementIndex;
                internal global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;
                internal global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> m_Controls;
                public global::UnityEngine.InputSystem.InputControl control => null;
                public global::UnityEngine.InputSystem.InputDevice device => null;
                public int requirementIndex => 0;
                public global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement requirement => default;
                public bool isOptional => false;
            }

            private struct Enumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputControlScheme.MatchResult.Match>, global::System.Collections.IEnumerator, global::System.IDisposable
            {
                internal int m_Index;
                internal global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;
                internal global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> m_Controls;
                public global::UnityEngine.InputSystem.InputControlScheme.MatchResult.Match Current => default;

                object global::System.Collections.IEnumerator.Current => null;

                public bool MoveNext()
                {
                    return false;
                }

                public void Reset()
                {
                }

                public void Dispose()
                {
                }
            }

            internal global::UnityEngine.InputSystem.InputControlScheme.MatchResult.Result m_Result;
            internal float m_Score;
            internal global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputDevice> m_Devices;
            internal global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> m_Controls;
            internal global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_Requirements;
            public float score => 0f;
            public bool isSuccessfulMatch => false;
            public bool hasMissingRequiredDevices => false;
            public bool hasMissingOptionalDevices => false;
            public global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputDevice> devices => default;

            // C# has no syntax for parameterized property 'Item'.
            public global::UnityEngine.InputSystem.InputControlScheme.MatchResult.Match this[int index]
            {
                get
                {
                    return default;
                }
            }

            public global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputControlScheme.MatchResult.Match> GetEnumerator()
            {
                return null;
            }

            global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }

            public void Dispose()
            {
            }
        }

        [global::System.Serializable]
        public struct DeviceRequirement : global::System.IEquatable<global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement>
        {
            [global::System.Flags]
            internal enum Flags
            {
                None = 0,
                Optional = 1,
                Or = 2
            }

            [global::UnityEngine.SerializeField]
            internal string m_ControlPath;
            [global::UnityEngine.SerializeField]
            internal global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement.Flags m_Flags;
            public string controlPath
            {
                get
                {
                    return null;
                }

                set
                {
                }
            }

            public bool isOptional
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool isAND
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool isOR
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public override string ToString()
            {
                return null;
            }

            public bool Equals(global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement other)
            {
                return false;
            }

            public override bool Equals(object obj)
            {
                return false;
            }

            public override int GetHashCode()
            {
                return 0;
            }

            public static bool operator ==(global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right)
            {
                return false;
            }

            public static bool operator !=(global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement left, global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement right)
            {
                return false;
            }
        }

        [global::System.Serializable]
        internal struct SchemeJson
        {
            [global::System.Serializable]
            public struct DeviceJson
            {
                public string devicePath;
                public bool isOptional;
                public bool isOR;
                public global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement ToDeviceEntry()
                {
                    return default;
                }

                public static global::UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson From(global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement requirement)
                {
                    return default;
                }
            }

            public string name;
            public string bindingGroup;
            public global::UnityEngine.InputSystem.InputControlScheme.SchemeJson.DeviceJson[] devices;
            public global::UnityEngine.InputSystem.InputControlScheme ToScheme()
            {
                return default;
            }

            public static global::UnityEngine.InputSystem.InputControlScheme.SchemeJson ToJson(global::UnityEngine.InputSystem.InputControlScheme scheme)
            {
                return default;
            }

            public static global::UnityEngine.InputSystem.InputControlScheme.SchemeJson[] ToJson(global::UnityEngine.InputSystem.InputControlScheme[] schemes)
            {
                return null;
            }

            public static global::UnityEngine.InputSystem.InputControlScheme[] ToSchemes(global::UnityEngine.InputSystem.InputControlScheme.SchemeJson[] schemes)
            {
                return null;
            }
        }

        [global::UnityEngine.SerializeField]
        internal string m_Name;
        [global::UnityEngine.SerializeField]
        internal string m_BindingGroup;
        [global::UnityEngine.SerializeField]
        internal global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement[] m_DeviceRequirements;
        public string name => null;

        public string bindingGroup
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> deviceRequirements => default;

        public InputControlScheme(string name, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControlScheme.DeviceRequirement> devices = null, string bindingGroup = null)
        {
            m_Name = null;
            m_BindingGroup = null;
            m_DeviceRequirements = null;
        }

        internal void SetNameAndBindingGroup(string name, string bindingGroup = null)
        {
        }

        public static global::UnityEngine.InputSystem.InputControlScheme? FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, global::UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccesfulMatch = false)
            where TDevices : global::System.Collections.Generic.IReadOnlyList<global::UnityEngine.InputSystem.InputDevice> where TSchemes : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControlScheme>
        {
            return null;
        }

        public static bool FindControlSchemeForDevices<TDevices, TSchemes>(TDevices devices, TSchemes schemes, out global::UnityEngine.InputSystem.InputControlScheme controlScheme, out global::UnityEngine.InputSystem.InputControlScheme.MatchResult matchResult, global::UnityEngine.InputSystem.InputDevice mustIncludeDevice = null, bool allowUnsuccessfulMatch = false)
            where TDevices : global::System.Collections.Generic.IReadOnlyList<global::UnityEngine.InputSystem.InputDevice> where TSchemes : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControlScheme>
        {
            controlScheme = default;
            matchResult = default;
            return false;
        }

        public static global::UnityEngine.InputSystem.InputControlScheme? FindControlSchemeForDevice<TSchemes>(global::UnityEngine.InputSystem.InputDevice device, TSchemes schemes)
            where TSchemes : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputControlScheme>
        {
            return null;
        }

        public bool SupportsDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        public global::UnityEngine.InputSystem.InputControlScheme.MatchResult PickDevicesFrom<TDevices>(TDevices devices, global::UnityEngine.InputSystem.InputDevice favorDevice = null)
            where TDevices : global::System.Collections.Generic.IReadOnlyList<global::UnityEngine.InputSystem.InputDevice>
        {
            return default;
        }

        public bool Equals(global::UnityEngine.InputSystem.InputControlScheme other)
        {
            return false;
        }

        public override bool Equals(object obj)
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

        public static bool operator ==(global::UnityEngine.InputSystem.InputControlScheme left, global::UnityEngine.InputSystem.InputControlScheme right)
        {
            return false;
        }

        public static bool operator !=(global::UnityEngine.InputSystem.InputControlScheme left, global::UnityEngine.InputSystem.InputControlScheme right)
        {
            return false;
        }
    }
}