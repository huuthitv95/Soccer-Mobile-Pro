namespace FL
{
    public class MirroredMatchChallengeManager : global::FL.IChanllengeEventController, global::FL.IFreeKickChallengeSupport, global::FL.IFreeKickMatchResultListener, global::FL.ISpecialFootballSupplier
    {
        private global::FL.MirroredMatchChallengeEvent m_event;
        private global::Srv.MirroredMatchChallengeArchive m_archive;
        public global::FL.PointsStoreMananger PointsStoreMananger;
        private int tmpFinalExtraReward;
        private int ballIdx;
        public bool NeedAnimation
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::FL.MirroredMatchChallengeEvent Event => null;
        public global::FL.EventSwitch EventSwitch => null;
        public global::FL.EventRewardHandler EventRewardHandler => null;
        public global::FL.EventLoginRewardHandler EventLoginRewardHandler => null;
        public int remainingReactivations => 0;

        public bool IsFirstOpen
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public MirroredMatchChallengeManager(global::FL.MirroredMatchChallengeEvent targetEvent, global::Srv.MirroredMatchChallengeArchive archive)
        {
        }

        public int GetPointNum()
        {
            return 0;
        }

        public int GetReactivationCost(int challengeId)
        {
            return 0;
        }

        public bool ReacitiveChallengeCostPoints(int challengeId)
        {
            return false;
        }

        private void OnClearArchive()
        {
        }

        public void ReacitiveChallenge(int id)
        {
        }

        public void CheckFreeReactive()
        {
        }

        public void MarkLoginRewardClaimed()
        {
        }

        public bool CheckLoginReward()
        {
            return false;
        }

        private void OnGainReward(global::FLDataTable.PointsShopConfig config)
        {
        }

        public bool CheckToNextRound()
        {
            return false;
        }

        public void ClaimMissionReward(ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, global::System.Action nextWindow, bool coinWindowCloseAbledf = false)
        {
        }

        public void ClaimRoundBonus(global::System.Action nextWindow)
        {
        }

        public float GetMatchDifficulty(int challengeId)
        {
            return 0f;
        }

        public bool NeedShowRedPoint()
        {
            return false;
        }

        public bool CheckCurrentRoundCompleted(int challengeId)
        {
            return false;
        }

        public void OnChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin)
        {
        }

        public void CheckInit()
        {
        }

        public void OpenEventMainView()
        {
        }

        public Win_ChallengeTip OpenEventTipView()
        {
            return null;
        }

        public void OnFreeKickChallengeFinish(CupMatchBase.MatchSettlementData matchData, ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge, bool isWin, int goalCount)
        {
        }

        public MirroredMatchChallengeConfig.FreeKickChallengeConfigs GetFreeKickChallengeConfig(int challengeId)
        {
            return null;
        }

        public int GetSpecialFootballId()
        {
            return 0;
        }

        public bool UseSpecialFootball()
        {
            return false;
        }

        public int GetSpecialJerseyId()
        {
            return 0;
        }

        public bool UseSpecialJersey()
        {
            return false;
        }

        public ChampionshipRoadConfig.ClassicMatchConfig CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }

        ChampionshipRoadConfig.ClassicMatchConfig global::FL.IChanllengeEventController.CurrentMatchConfig(in ChampionshipRoadConfig.ClassicTeamMatchChallenge challenge)
        {
            return default;
        }
    }
}