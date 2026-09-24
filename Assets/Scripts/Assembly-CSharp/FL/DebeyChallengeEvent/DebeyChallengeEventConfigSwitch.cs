namespace FL.DebeyChallengeEvent
{
    public class DebeyChallengeEventConfigSwitch
    {
        private readonly global::FL.DebeyChallengeEvent.DebeyChallengeEventABTestDelegate abTestDelegate;
        private readonly global::System.Func<string, bool> checkExist;
        private global::System.DateTime startTm;
        private global::System.DateTime endTm;
        private string configFileName;
        public string ConfigFileName => null;
        public global::System.DateTime EndTime => default;
        public bool IsOpen => false;

        public DebeyChallengeEventConfigSwitch(global::FL.DebeyChallengeEvent.DebeyChallengeEventABTestDelegate abTestDelegate, global::System.Func<string, bool> checkExist)
        {
        }

        private void Refresh()
        {
        }
    }
}