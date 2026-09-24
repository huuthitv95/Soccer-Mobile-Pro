namespace DG.Tweening.Core
{
	public class DOTweenSettings : global::UnityEngine.ScriptableObject
	{
		public enum SettingsLocation
		{
			AssetsDirectory = 0,
			DOTweenDirectory = 1,
			DemigiantDirectory = 2
		}

		[global::System.Serializable]
		public class SafeModeOptions
		{
			public global::DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;
		}

		[global::System.Serializable]
		public class ModulesSetup
		{
			public bool showPanel;

			public bool audioEnabled;

			public bool physicsEnabled;

			public bool physics2DEnabled;

			public bool spriteEnabled;

			public bool uiEnabled;

			public bool textMeshProEnabled;

			public bool tk2DEnabled;
		}

		public const string AssetName = "DOTweenSettings";

		public const string AssetFullFilename = "DOTweenSettings.asset";

		public bool useSafeMode;

		public global::DG.Tweening.Core.DOTweenSettings.SafeModeOptions safeModeOptions;

		public float timeScale;

		public bool useSmoothDeltaTime;

		public float maxSmoothUnscaledTime;

		public global::DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;

		public bool showUnityEditorReport;

		public global::DG.Tweening.LogBehaviour logBehaviour;

		public bool drawGizmos;

		public bool defaultRecyclable;

		public global::DG.Tweening.AutoPlay defaultAutoPlay;

		public global::DG.Tweening.UpdateType defaultUpdateType;

		public bool defaultTimeScaleIndependent;

		public global::DG.Tweening.Ease defaultEaseType;

		public float defaultEaseOvershootOrAmplitude;

		public float defaultEasePeriod;

		public bool defaultAutoKill;

		public global::DG.Tweening.LoopType defaultLoopType;

		public bool debugMode;

		public bool debugStoreTargetId;

		public bool showPreviewPanel;

		public global::DG.Tweening.Core.DOTweenSettings.SettingsLocation storeSettingsLocation;

		public global::DG.Tweening.Core.DOTweenSettings.ModulesSetup modules;

		public bool showPlayingTweens;

		public bool showPausedTweens;
	}
}
