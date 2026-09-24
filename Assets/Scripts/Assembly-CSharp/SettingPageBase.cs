public abstract class SettingPageBase : global::UnityEngine.MonoBehaviour
{
	public abstract void Init(Win_Setting.GameSettingCategory category, bool inGame);

	public abstract void OnClose();
}
