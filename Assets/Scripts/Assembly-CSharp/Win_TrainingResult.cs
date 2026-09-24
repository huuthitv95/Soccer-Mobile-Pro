public class Win_TrainingResult : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    private global::System.Collections.Generic.Dictionary<int, global::FL.PlayerExpStruct> tempPlayerExp;
    private global::System.Collections.Generic.Dictionary<int, global::SL.Player.Hexagram> tempPlayerProperty;
    private float animationTime;
    public override void OnOpen(object parameter)
    {
    }

    public override void OnClose()
    {
    }

    public void Fill(RegionalLeague regionalLeague, global::System.Collections.Generic.List<ClubPlayer> players, global::System.Action next)
    {
    }

    private global::FL.PlayerExpStruct GetDeltaExp(int id)
    {
        return default;
    }

    private global::SL.Player.Hexagram GetOldProperty(int id)
    {
        return default;
    }

    private global::DG.Tweening.Tweener DONumberText(global::UnityEngine.UI.Text target, float endValue, float startValue, float duration, string format = "0%", float animationDelay = 0.5f)
    {
        return null;
    }

    private void UpdatePlayerInfo(ClubPlayer player, float DeltaExp, float newExp, int property, global::UnityEngine.Transform item, int oldProperty, string PropertyName)
    {
    }

    private void SetAbilityColor(global::UnityEngine.UI.Text text, float value)
    {
    }
}