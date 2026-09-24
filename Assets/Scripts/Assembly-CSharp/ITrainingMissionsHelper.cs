public interface ITrainingMissionsHelper
{
	global::UnityEngine.Transform TutorialUI { get; }

	TouchInputSystem inputSystem { get; }

	bool IsSingleLevel { get; }

	bool IsAlive { get; }

	void DrawLimitArea(AIMatchConfigurer.TrainingConfigure config, int step);

	void ShowMissionInfo(string info);

	void ShowTimer(bool show);

	void ShowFail(string text, global::System.Action callBack);

	void UpdateTimer(float time);

	void DoNext();

	void Restart(global::System.Action callback);

	void ShowInput(bool show);

	void EnableJoystickInput(bool enable);

	void ShowMissionTips(bool show, string title, string content);

	void ShowSuccess(global::System.Action callBack);

	void ShowSkipBtn(bool show);

	void ResetCurrentStep(global::System.Action callBack);
}
