namespace UnityEngine.UI.Extensions
{
	public class Accordion : global::UnityEngine.MonoBehaviour
	{
		public enum Transition
		{
			Instant = 0,
			Tween = 1
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Extensions.Accordion.Transition m_Transition;

		[global::UnityEngine.SerializeField]
		private float m_TransitionDuration;

		public global::UnityEngine.UI.Extensions.Accordion.Transition transition
		{
			get
			{
				return global::UnityEngine.UI.Extensions.Accordion.Transition.Instant;
			}
			set
			{
			}
		}

		public float transitionDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
