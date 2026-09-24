public abstract class FormationBtnPanelBase : global::UnityEngine.MonoBehaviour
{
	public enum FormationBtnPanelType
	{
		Normal = 0,
		ML = 1,
		PlayerCareer = 2,
		LocalPVP = 3
	}

	public abstract global::UnityEngine.UI.Button BtnFormation { get; }

	public abstract global::UnityEngine.UI.Button BtnEdit { get; }

	public abstract global::UnityEngine.UI.Button BtnTacticsStyle { get; }

	public abstract global::UnityEngine.UI.Button BtnRole { get; }

	public static FormationBtnPanelBase LoadPrefab(FormationBtnPanelBase.FormationBtnPanelType panelType, global::UnityEngine.Transform parent)
	{
		return null;
	}
}
