internal interface RTCEventEntryController
{
	bool IsFirstOpen { get; set; }

	bool IsOpen();

	void CheckInit();

	bool CheckLoginReward();

	void OpenEventMainView();

	bool NeedShowRedPoint();
}
