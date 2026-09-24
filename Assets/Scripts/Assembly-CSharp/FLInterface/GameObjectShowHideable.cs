namespace FLInterface
{
    [global::System.Serializable]
    public class GameObjectShowHideable : global::FLInterface.IShowHideable
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject gameObject;
        public bool enabled => false;

        public void Hide()
        {
        }

        public void Show()
        {
        }
    }
}