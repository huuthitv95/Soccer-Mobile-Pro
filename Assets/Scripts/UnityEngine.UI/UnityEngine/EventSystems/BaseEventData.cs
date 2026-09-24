namespace UnityEngine.EventSystems
{
	public class BaseEventData : global::UnityEngine.EventSystems.AbstractEventData
	{
		private readonly global::UnityEngine.EventSystems.EventSystem m_EventSystem;

		public global::UnityEngine.EventSystems.BaseInputModule currentInputModule => null;

		public global::UnityEngine.GameObject selectedObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BaseEventData(global::UnityEngine.EventSystems.EventSystem eventSystem)
		{
		}
	}
}
