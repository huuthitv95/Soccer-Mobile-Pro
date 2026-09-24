namespace FL
{
    public class RewardRevealHandler : global::FL.IRewardRevealSupport
    {
        private global::Srv.RewardRevealArchive revealArchive;
        private global::System.Action SaveAction;
        public RewardRevealHandler(global::Srv.RewardRevealArchive archive, global::System.Action saveAction)
        {
        }

        public void Reset()
        {
        }

        public bool IsRewardRevealed(int id)
        {
            return false;
        }

        public void RevealReward(int id)
        {
        }
    }
}