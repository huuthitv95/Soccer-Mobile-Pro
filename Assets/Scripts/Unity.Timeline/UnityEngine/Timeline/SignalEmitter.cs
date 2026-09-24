namespace UnityEngine.Timeline
{
	[global::System.Serializable]
	[global::UnityEngine.ExcludeFromPreset]
	public class SignalEmitter : global::UnityEngine.Timeline.Marker, global::UnityEngine.Playables.INotification, global::UnityEngine.Timeline.INotificationOptionProvider
	{
		[global::UnityEngine.SerializeField]
		private bool m_Retroactive;

		[global::UnityEngine.SerializeField]
		private bool m_EmitOnce;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Timeline.SignalAsset m_Asset;

		public bool retroactive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool emitOnce
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.Timeline.SignalAsset asset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		global::UnityEngine.PropertyName global::UnityEngine.Playables.INotification.id => default;

		global::UnityEngine.Timeline.NotificationFlags global::UnityEngine.Timeline.INotificationOptionProvider.flags => (global::UnityEngine.Timeline.NotificationFlags)0;
	}
}
