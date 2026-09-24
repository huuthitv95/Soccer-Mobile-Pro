internal class IChanllengeEventControllerWarpper : RTCEventEntryController
{
    private global::FL.IChanllengeEventController controller;
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

    public IChanllengeEventControllerWarpper(global::FL.IChanllengeEventController controller)
    {
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