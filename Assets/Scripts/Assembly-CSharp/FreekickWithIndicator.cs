public class FreekickWithIndicator : global::UnityEngine.MonoBehaviour, IFLHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler, InputListener
{
    [global::UnityEngine.SerializeField]
    private AISampleBase aISample;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.LineRenderer lineRenderer;
    private const float g = 9.8f;
    private const float speed = 22f;
    private const float maxAngle = 35f;
    private float minAngle;
    private const float friction = 0.02f;
    private const float reboundSpeedAttenuation = 0.5f;
    private const float reboundSpeedLimit = 0.6f;
    private float currentAngle;
    private global::UnityEngine.Vector3 horizontalSpeedDir;
    private global::UnityEngine.Vector3 speedDir;
    private float minimumPower;
    private global::UnityEngine.Vector3 referenceDir;
    private global::UnityEngine.Quaternion leftLimit;
    private global::UnityEngine.Quaternion rightLimit;
    private InGameCameraModel GameMode;
    public void HandleInput(global::EngineMessages.InputData eventlist)
    {
    }

    private bool UpdateAngle(float dt)
    {
        return false;
    }

    private bool UpdateHorizontalSpeedDir(float dt)
    {
        return false;
    }

    public void OnFLClientMessage(FLClientOpCode opCode, object content)
    {
    }

    public void Kick(float power)
    {
    }

    private bool CheckShoot(out global::UnityEngine.Vector3 pos, int positionCountOffset = 0)
    {
        pos = default;
        return false;
    }

    public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void Init(global::UnityEngine.Vector3 ballPos, InGameCameraModel mode)
    {
    }

    private void CreateSimulatedCurve(global::UnityEngine.Vector3 ballPos)
    {
    }
}