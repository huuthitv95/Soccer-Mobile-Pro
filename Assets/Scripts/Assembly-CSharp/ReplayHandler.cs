public interface ReplayHandler
{
	void OnReplayStart();

	void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail);

	void OnReplayEnd();

	void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match);

	void OnReplayReset();
}
