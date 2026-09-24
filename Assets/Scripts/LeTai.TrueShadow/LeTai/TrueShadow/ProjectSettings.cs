namespace LeTai.TrueShadow
{
	public class ProjectSettings : global::UnityEngine.ScriptableObject
	{
		public const string DEFAULT_RESOURCE_PATH = "True Shadow Project Settings Default";

		public const string RESOURCE_PATH = "True Shadow Project Settings";

		private static global::LeTai.TrueShadow.ProjectSettings instance;

		[global::UnityEngine.SerializeField]
		internal bool useGlobalAngleByDefault;

		[global::UnityEngine.SerializeField]
		[global::LeTai.TrueShadow.Knob]
		internal float globalAngle;

		[global::UnityEngine.SerializeField]
		internal bool showQuickPresetsButtons;

		[global::UnityEngine.SerializeField]
		internal global::System.Collections.Generic.List<global::LeTai.TrueShadow.QuickPreset> quickPresets;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Action<float> m_globalAngleChanged;

		public static global::LeTai.TrueShadow.ProjectSettings Instance => null;

		public bool UseGlobalAngleByDefault
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public float GlobalAngle
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public bool ShowQuickPresetsButtons
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public global::System.Collections.Generic.List<global::LeTai.TrueShadow.QuickPreset> QuickPresets
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public event global::System.Action<float> globalAngleChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}
	}
}
