public class ClubModeMainview : MainViewPage
{
    [global::System.Serializable]
    public class CupEntrys
    {
        [global::System.Serializable]
        private class SpecialItem
        {
            public string Key;
            public global::UnityEngine.Transform Value;
        }

        private class CupItem
        {
            private ClubModeMainview.CupEntrys cupEntrys;
            public global::SL.CupRules Rules { get; private set; }
            public global::UnityEngine.Transform Node { get; private set; }
            public global::UnityEngine.GameObject ArchiveFlag { get; private set; }

            public CupItem(ClubModeMainview.CupEntrys cupEntrys, global::SL.CupRules rules, global::UnityEngine.Transform node)
            {
            }

            public void Refresh()
            {
            }

            private void OnClick()
            {
            }
        }

        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<ClubModeMainview.CupEntrys.SpecialItem> specialItems;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Transform cupProto;
        [global::UnityEngine.SerializeField]
        private global::SL.UIAtlasType atlasType;
        [global::UnityEngine.SerializeField]
        private string defaultBg;
        private global::System.Collections.Generic.Dictionary<string, ClubModeMainview.CupEntrys.CupItem> cupItems;
        private global::System.Action<global::SL.CupRules> OnCupClick;
        private global::System.Func<global::SL.CupRules, bool> CheckArchive;
        private bool TryGetSpecialItem(string cupType, out global::UnityEngine.Transform node)
        {
            node = null;
            return false;
        }

        public void Initialize(global::System.Collections.Generic.List<global::SL.CupRules> allCups, global::System.Action<global::SL.CupRules> OnCupClick, global::System.Func<global::SL.CupRules, bool> CheckArchive)
        {
        }

        public void Refresh()
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private ClubModeMainview.CupEntrys cupEntrys;
    private bool initialized;
    public override void Initialize()
    {
    }

    private void Refresh()
    {
    }

    private bool CheckArchive(global::SL.CupRules cup)
    {
        return false;
    }

    private void OnCupClick(global::SL.CupRules cup)
    {
    }

    private void CreateCup(global::SL.CupRules cup)
    {
    }

    public void OnLeagueBtnClick()
    {
    }
}