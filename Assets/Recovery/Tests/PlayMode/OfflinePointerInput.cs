// Deterministic mouse input through the real StandaloneInputModule.
using UnityEngine;
using UnityEngine.EventSystems;
namespace Soccer.Recovery.Tests
{
    public sealed class OfflinePointerInput : BaseInput
    {
        public Vector2 Position;
        public bool Down, Up, Held;
        public override bool mousePresent => true;
        public override bool touchSupported => false;
        public override Vector2 mousePosition => Position;
        public override Vector2 mouseScrollDelta => Vector2.zero;
        public override bool GetMouseButtonDown(int button) => button == 0 && Down;
        public override bool GetMouseButtonUp(int button) => button == 0 && Up;
        public override bool GetMouseButton(int button) => button == 0 && Held;
        public override float GetAxisRaw(string name) => 0;
        public override bool GetButtonDown(string name) => false;
    }
}
