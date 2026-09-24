internal class CompetitionChallengeEventMgrWrapper : RTCEventEntryController
{
    public CompetitionChallengeEventMgr controller => null;

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

    public bool CheckLoginReward()
    {
        return false;
    }

    public void CheckInit()
    {
    }

    public bool IsOpen()
    {
        return false;
    }

    public bool NeedShowRedPoint()
    {
        return false;
    }

    public void OpenEventMainView()
    {
    }
}