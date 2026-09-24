public class StartSession : global::UnityEngine.MonoBehaviour
{
    public global::UnityEngine.Camera Camera;
    private static global::SL.ABTest.AdBoradType AdBoradType;
    private EventLog.Param[] revenueParam;
    private void Awake()
    {
    }

    private void OnImpressionEvent(global::Gadsme.GadsmeImpressionData obj)
    {
    }

    private void OnPlacementVisible(global::Gadsme.GadsmePlacement obj)
    {
    }

    public static void RegisterCamera(global::UnityEngine.Camera camera)
    {
    }

    public static void DeregisterCamera()
    {
    }

    private static bool IsSupport()
    {
        return false;
    }
}