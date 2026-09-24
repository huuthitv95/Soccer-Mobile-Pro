namespace FL.TourEvent
{
    public class TourEventConfigSwitch
    {
        private readonly global::FL.TourEvent.TourEventABTestDelegate abTestDelegate;
        private readonly global::System.Func<string, bool> checkExist;
        private global::System.DateTime startTm;
        private global::System.DateTime endTm;
        private global::System.DateTime refreshTime;
        private string configFileName;
        public string ConfigFileName => null;
        public global::System.DateTime EndTime => default;
        public bool IsOpen => false;

        public TourEventConfigSwitch(global::FL.TourEvent.TourEventABTestDelegate abTestDelegate, global::System.Func<string, bool> checkExist)
        {
        }

        private void RefreshIfNeeded()
        {
        }
    }
}