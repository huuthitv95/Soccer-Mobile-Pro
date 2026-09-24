namespace Gadsme
{
    internal class Tdabed9b_6 : global::UnityEngine.MonoBehaviour
    {
        private global::Gadsme.Tdabed9b_13 F61;
        internal global::System.Collections.Generic.List<global::Gadsme.Tdabed9b_2> F62;
        internal float F63;
        private int F64;
        private global::System.Collections.Generic.Dictionary<string, global::Gadsme.Tdabed9b_0<global::Gadsme.Tdabed9b_7>> F65;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F66;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F67;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F68;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F69;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F70;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F71;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F72;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmePlacement> F73;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAdContentInfo> F74;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAdContentInfo> F75;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAdContentInfo> F76;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAdContentInfo> F77;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAdContentInfo> F78;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAdContentInfo> F79;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAudioAdInfo> F80;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAudioAdInfo, global::Gadsme.GadsmeCancelAudioAdReason> F81;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAudioAdInfo> F82;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAudioAdInfo> F83;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAudioAdInfo> F84;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Gadsme.GadsmeAudioAdInfo, bool> F85;
        internal bool F86;
        internal global::Gadsme.Tdabed9b_9 F87;
        private float F88;
        internal global::System.Collections.Generic.Dictionary<string, string> F89;
        internal event global::System.Action<global::Gadsme.GadsmePlacement> PlacementAddEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmePlacement> PlacementRemoveEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmePlacement> PlacementClickedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmePlacement> PlacementLoadedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmePlacement> PlacementVisibleEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmePlacement> PlacementViewableEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmePlacement> PlacementNoAdEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmePlacement> PlacementFailedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAdContentInfo> AdContentViewableEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAdContentInfo> AdContentVisibleEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAdContentInfo> AdContentLoadedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAdContentInfo> AdContentClickedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAdContentInfo> AdContentNoAdEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAdContentInfo> AdContentFailedEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAudioAdInfo> LoadAudioAdEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAudioAdInfo, global::Gadsme.GadsmeCancelAudioAdReason> CancelAudioAdEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAudioAdInfo> AudioAdReadyToPlayEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAudioAdInfo> PlayAudioAdEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAudioAdInfo> AudioAdIncompletePlaythroughEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        internal event global::System.Action<global::Gadsme.GadsmeAudioAdInfo, bool> FinishAudioAdEvent
        {
            add
            {
            }

            remove
            {
            }
        }

        public void Awake()
        {
        }

        public void Start()
        {
        }

        public void OnDrawGizmos()
        {
        }

        public void Update()
        {
        }

        private void M61()
        {
        }

        private void M62(global::Gadsme.Tdabed9b_2 A26, bool A27 = false)
        {
        }

        protected void OnDestroy()
        {
        }

        public void LateUpdate()
        {
        }

        private void M63()
        {
        }

        public void M64(global::Gadsme.Tdabed9b_2 A28)
        {
        }

        [global::System.Diagnostics.DebuggerHidden]
        private global::System.Collections.IEnumerator M65()
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerHidden]
        private global::System.Collections.IEnumerator M66()
        {
            return null;
        }

        private int M67()
        {
            return 0;
        }

        private global::UnityEngine.Camera M68()
        {
            return null;
        }

        private global::UnityEngine.Vector3 M69(global::UnityEngine.Camera A29)
        {
            return default;
        }

        private bool M70(int A30, global::UnityEngine.Vector3 A31)
        {
            return false;
        }

        private int M71(int A32, global::UnityEngine.Vector3 A33)
        {
            return 0;
        }

        private string M72(string A34)
        {
            return null;
        }

        [global::System.Diagnostics.DebuggerHidden]
        private global::System.Collections.IEnumerator M73(global::Gadsme.Tdabed9b_2 A35)
        {
            return null;
        }

        public void M74(global::Gadsme.GadsmePlacement A36)
        {
        }

        public void M75(global::Gadsme.GadsmePlacement A37)
        {
        }

        internal global::Gadsme.Tdabed9b_2 M76(global::Gadsme.GadsmePlacement A38)
        {
            return null;
        }

        internal void M77(global::Gadsme.Tdabed9b_2 A39)
        {
        }

        internal global::Gadsme.Tdabed9b_2 M78(global::Gadsme.GadsmePlacement A40, string A41, string A42, int A43, bool A44)
        {
            return null;
        }

        internal void M79()
        {
        }

        private void M80(global::Gadsme.Tdabed9b_2 A45, global::Gadsme.Tdabed9b_7 A46)
        {
        }

        private void M81(global::Gadsme.Tdabed9b_2 A47, int A48)
        {
        }

        private void M82(global::Gadsme.Tdabed9b_2 A49, string A50)
        {
        }

        private void M83(global::Gadsme.Tdabed9b_2 A51)
        {
        }

        private void M84(global::Gadsme.Tdabed9b_2 A52)
        {
        }

        private void M85(global::Gadsme.Tdabed9b_2 A53)
        {
        }

        private void M86(global::Gadsme.Tdabed9b_2 A54)
        {
        }

        private void M87(global::Gadsme.Tdabed9b_2 A55)
        {
        }

        private void M88(global::Gadsme.GadsmePlacement A56)
        {
        }

        private void M89(global::Gadsme.GadsmePlacement A57)
        {
        }

        private void M90(global::Gadsme.GadsmePlacement A58)
        {
        }

        private void M91(global::Gadsme.GadsmePlacement A59, bool A60)
        {
        }

        internal void M92(global::Gadsme.GadsmeAudioAdInfo A61)
        {
        }

        internal void M93(global::Gadsme.GadsmeAudioAdInfo A62)
        {
        }

        internal void M94(global::Gadsme.GadsmeAudioAdInfo A63, global::Gadsme.GadsmeCancelAudioAdReason A64)
        {
        }

        internal void M95(global::Gadsme.GadsmeAudioAdInfo A65)
        {
        }

        internal void M96(global::Gadsme.GadsmeAudioAdInfo A66)
        {
        }

        internal void M97(global::Gadsme.GadsmeAudioAdInfo A67, bool A68)
        {
        }

        internal void M98(global::Gadsme.Tdabed9b_2 A69)
        {
        }

        internal void M99(global::Gadsme.Tdabed9b_2 A70)
        {
        }

        internal void M100(global::Gadsme.Tdabed9b_2 A71)
        {
        }

        internal void M101(global::Gadsme.Tdabed9b_2 A72)
        {
        }

        internal void M102(global::Gadsme.Tdabed9b_2 A73)
        {
        }

        internal void M103(global::Gadsme.Tdabed9b_2 A74)
        {
        }

        internal void M104(global::Gadsme.Tdabed9b_2 A75)
        {
        }

        internal void M105(global::Gadsme.Tdabed9b_2 A76)
        {
        }

        internal void M106(global::Gadsme.Tdabed9b_2 A77)
        {
        }

        internal void M107(global::UnityEngine.Texture A78, bool A79 = true)
        {
        }

        private void M108(global::Gadsme.Tdabed9b_2 A80)
        {
        }
    }
}