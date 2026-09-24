public interface ICommentatorControler
{
	global::UnityEngine.AudioSource audioSource { set; }

	global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode { get; }

	global::System.Collections.Generic.IEnumerable<FLClientOpCode> FocusClientOpcode { get; }

	global::System.Func<string, global::UnityEngine.AudioClip> LoadClip { set; }

	global::UnityEngine.MonoBehaviour monoHelper { set; }

	void HandleMessage(OpCode code, object message, IMatch match);

	void HandleMessage(FLClientOpCode code, object message, IMatch match);

	void OnMatchStart(IMatch match);

	void OnMatchCreate(IMatch match, Peripherals peripherals);

	void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match);
}
