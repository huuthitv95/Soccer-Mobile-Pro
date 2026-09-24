public interface PlaySoundHelper
{
	void Play(string soundId, bool loop = false, bool isBg = false, global::UnityEngine.AudioSource audioSource = null);

	void UpdateSoundListenerPos(global::UnityEngine.Vector3 pos);
}
