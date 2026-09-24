public class GUI26CupTourEventMapLineStyle : global::UnityEngine.MonoBehaviour
{
    public enum LineState
    {
        Passed = 0,
        Current = 1,
        Future = 2
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Sprite[] lineSpritesByState;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color[] lineColorsByState;
    public void SetState(GUITourEventMapLine line, GUI26CupTourEventMapLineStyle.LineState state)
    {
    }

    private global::UnityEngine.Sprite GetSprite(int stateIndex)
    {
        return null;
    }

    private global::UnityEngine.Color? GetColor(int stateIndex)
    {
        return null;
    }
}