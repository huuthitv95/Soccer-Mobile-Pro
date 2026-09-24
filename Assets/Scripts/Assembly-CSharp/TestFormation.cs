public class TestFormation : global::UnityEngine.MonoBehaviour
{
    private global::UnityEngine.Transform selected;
    private float[, ] formations;
    private global::UnityEngine.Transform ballPos;
    private global::UnityEngine.Transform selectMark;
    private global::UnityEngine.Transform[, ] players;
    private global::UnityEngine.Vector3[, ] staticPoses;
    private global::UnityEngine.Vector3[, ] dynamicPoses;
    private global::UnityEngine.LineRenderer[, ] lines;
    public int selectTeam;
    private int selectPlayer;
    private void Start()
    {
    }

    private global::System.Collections.IEnumerator Run()
    {
        return null;
    }

    private void Update()
    {
    }

    private global::EngineMessages.MatchConfig InitMatchConfig()
    {
        return null;
    }

    private void ReceiveMessage(global::Common.GameMessage message)
    {
    }
}