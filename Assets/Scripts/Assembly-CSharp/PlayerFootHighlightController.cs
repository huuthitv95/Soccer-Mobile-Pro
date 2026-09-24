public class PlayerFootHighlightController : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform selected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform NormalSelected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform MoveSelected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform PressSelected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform arrow;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform LongArrow;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform BallSelected;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject defensiveHelpPlayer;
    public bool BallSelectedActive
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool Active
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public bool DefensiveHelpPlayerActive
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public static PlayerFootHighlightController Load(global::UnityEngine.Transform parent)
    {
        return null;
    }

    public void UpdateArrow(global::UnityEngine.Vector2 dir, bool sprint, bool press, InGameCameraModel cameraModel)
    {
    }

    public void UpdateBallArrow(global::UnityEngine.Vector2 dir)
    {
    }

    public void SetSelectedPosition(global::UnityEngine.Vector3 position)
    {
    }

    public void SetSelectedActive(bool active)
    {
    }

    public void SetBallSelectedPosition(global::UnityEngine.Vector3 position)
    {
    }

    public void SetDefensiveHelpPlayerPosition(global::UnityEngine.Vector3 position, global::UnityEngine.Vector3 ballPos)
    {
    }
}