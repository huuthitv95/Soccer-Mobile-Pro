public class GoogleGamesAuthenucate : global::UnityEngine.MonoBehaviour
{
    private bool isAuthenucated;
    private global::System.Threading.Tasks.Task<bool> pendingLogin;
    public static GoogleGamesAuthenucate Instance { get; private set; }
    public bool IsAuthenucated => false;

    private void Awake()
    {
    }

    internal void InvalidateAuthentication()
    {
    }

    private void Start()
    {
    }

    private global::System.Threading.Tasks.Task<bool> LoginAsync(bool manual)
    {
        return null;
    }

    private global::System.Threading.Tasks.Task<bool> AuthenticateAsync(bool manual)
    {
        return null;
    }

    internal void ManualLogin(global::System.Action<bool> callback)
    {
    }
}