public class KeyboardInputSystem : InputSystem
{
    private struct KeyboardInput
    {
        public global::UnityEngine.KeyCode code;
        public global::EngineMessages.InputFunction off;
        public global::EngineMessages.InputFunction def;
        public bool offensive;
        public bool KeyDown;
    }

    private KeyboardInputSystem.KeyboardInput[] defaultKeys;
    private KeyboardInputSystem.KeyboardInput[] keyInputs;
    private global::System.Collections.Generic.Queue<global::EngineMessages.InputEvent> pendingEvents;
    private bool Offensive;
    private void Start()
    {
    }

    public void UpdateOffenseTteam(bool offense, int playerid)
    {
    }

    private void CheckDirectKey()
    {
    }

    public void UpdateKeyboardEvents()
    {
    }

    public void ResetButton(bool resetAll = false)
    {
    }

    public void OnMatchReset()
    {
    }

    public void FetchEvents(ref global::EngineMessages.InputData eventList)
    {
    }

    private void OnApplicationFocus(bool focus)
    {
    }
}