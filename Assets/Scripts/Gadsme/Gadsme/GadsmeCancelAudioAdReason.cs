namespace Gadsme
{
	public enum GadsmeCancelAudioAdReason : uint
	{
		Unknown = 0u,
		NetworkError = 1u,
		InvalidData = 2u,
		AudioVolumeTooLowOrMuted = 4u,
		AnotherAudioAdActive = 8u,
		CurrentAudioAdPlayingAudio = 0x10u
	}
}
