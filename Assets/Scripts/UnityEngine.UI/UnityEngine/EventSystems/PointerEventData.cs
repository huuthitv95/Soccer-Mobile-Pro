namespace UnityEngine.EventSystems
{
	public class PointerEventData : global::UnityEngine.EventSystems.BaseEventData
	{
		public enum InputButton
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}

		public enum FramePressState
		{
			Pressed = 0,
			Released = 1,
			PressedAndReleased = 2,
			NotChanged = 3
		}

		private global::UnityEngine.GameObject m_PointerPress;

		public global::System.Collections.Generic.List<global::UnityEngine.GameObject> hovered;

		public global::UnityEngine.GameObject pointerEnter { get; set; }

		public global::UnityEngine.GameObject lastPress { get; private set; }

		public global::UnityEngine.GameObject rawPointerPress { get; set; }

		public global::UnityEngine.GameObject pointerDrag { get; set; }

		public global::UnityEngine.GameObject pointerClick { get; set; }

		public global::UnityEngine.EventSystems.RaycastResult pointerCurrentRaycast { get; set; }

		public global::UnityEngine.EventSystems.RaycastResult pointerPressRaycast { get; set; }

		public bool eligibleForClick { get; set; }

		public int pointerId { get; set; }

		public global::UnityEngine.Vector2 position { get; set; }

		public global::UnityEngine.Vector2 delta { get; set; }

		public global::UnityEngine.Vector2 pressPosition { get; set; }

		[global::System.Obsolete]
		public global::UnityEngine.Vector3 worldPosition { get; set; }

		[global::System.Obsolete]
		public global::UnityEngine.Vector3 worldNormal { get; set; }

		public float clickTime { get; set; }

		public int clickCount { get; set; }

		public global::UnityEngine.Vector2 scrollDelta { get; set; }

		public bool useDragThreshold { get; set; }

		public bool dragging { get; set; }

		public global::UnityEngine.EventSystems.PointerEventData.InputButton button { get; set; }

		public global::UnityEngine.Camera enterEventCamera => null;

		public global::UnityEngine.Camera pressEventCamera => null;

		public global::UnityEngine.GameObject pointerPress
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PointerEventData(global::UnityEngine.EventSystems.EventSystem eventSystem)
			: base(null)
		{
		}

		public bool IsPointerMoving()
		{
			return false;
		}

		public bool IsScrolling()
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
