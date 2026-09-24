namespace FLMessageSystem.IngameMessages
{
	public struct MatchCameraModeChanged
	{
		public CameraSetting.MatchCameraMode mode;

		public MatchCameraModeChanged(CameraSetting.MatchCameraMode mode)
		{
			this.mode = CameraSetting.MatchCameraMode.Parallel;
		}
	}
}
