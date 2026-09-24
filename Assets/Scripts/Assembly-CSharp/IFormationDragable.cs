public interface IFormationDragable : global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler
{
	ClubPlayer Player { get; set; }

	FormationItemType ItemType { get; }

	global::UnityEngine.GameObject gameObject { get; }

	GUIPlayer GUIPlayer { get; }

	bool ChangePosition(IFormationDragable targetPlayer);

	void OnCovered(bool covered, FormationTool.UIPosition pos);

	global::UnityEngine.RectTransform GetRectTransform();

	void UpdateRevisedFormationUI();

	void UpdateOriginalFormationUI();

	void DoPlayerRestoreStamina();

	void DoPlayerStateAnimation();
}
