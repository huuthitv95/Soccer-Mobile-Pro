public interface InGameButtonConfiguratorGroup
{
	GUIInGameButtonConfigurator CurrentSelected { get; set; }

	void NotifySelectedChanged(GUIInGameButtonConfigurator configurator);

	bool CheckIntersect(GUIInGameButtonConfigurator configurator, ref IngameButtonConfiguration.IngameButtonConfig config, bool checkHideWarning);

	void OnDragEnd();
}
