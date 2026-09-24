namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class Pen : global::UnityEngine.InputSystem.Pointer
    {
        public global::UnityEngine.InputSystem.Controls.ButtonControl tip { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl eraser { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl firstBarrelButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl secondBarrelButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl thirdBarrelButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl fourthBarrelButton { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl inRange { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.Vector2Control tilt { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.AxisControl twist { get; protected set; }
        public new static global::UnityEngine.InputSystem.Pen current { get; internal set; }

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.Controls.ButtonControl this[global::UnityEngine.InputSystem.PenButton button]
        {
            get
            {
                return null;
            }
        }

        public override void MakeCurrent()
        {
        }

        protected override void OnRemoved()
        {
        }

        protected override void FinishSetup()
        {
        }
    }
}