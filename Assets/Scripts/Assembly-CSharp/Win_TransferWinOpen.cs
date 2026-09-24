public class Win_TransferWinOpen : global::Common.WindowBase
{
    public class Parameter
    {
        public string TitleStringId;
        public string DescStringId;
    }

    [global::UnityEngine.SerializeField]
    private StringID titleString;
    [global::UnityEngine.SerializeField]
    private StringID descString;
    public override void OnOpen(object parameter)
    {
    }
}