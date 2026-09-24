public class PlayerTemporaryBoostManager
{
    private global::Srv.PlayerTemporaryBoostRecord record;
    private readonly global::System.Action markDirty;
    public static readonly int BoostValue;
    public global::Common.Event<int> OnTemporaryBoostAdded;
    public global::Common.Event<int> OnStaminaBoostAdded;
    public PlayerTemporaryBoostManager(global::Srv.PlayerTemporaryBoostRecord record, global::System.Action markDirty)
    {
    }

    public void AddTemporaryBoost(int playerId, int value)
    {
    }

    public bool HasTemporaryBoost(int playerId)
    {
        return false;
    }

    public bool TryGetTemporaryBoost(int playerId, out int value)
    {
        value = default;
        return false;
    }

    public void RemoveTemporaryBoost(int playerId)
    {
    }

    public bool HasStaminaBoost(int playerId)
    {
        return false;
    }

    public void AddStaminaBoost(int playerId)
    {
    }

    public void RemoveStaminaBoost(int playerId)
    {
    }
}