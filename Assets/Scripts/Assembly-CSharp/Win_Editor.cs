public class Win_Editor : global::Common.WindowBase
{
    private abstract class ContextUpdater
    {
        protected class LoopListAdapter<T> : global::UnityEngine.UI.LoopScrollPrefabSource, global::UnityEngine.UI.LoopScrollDataSource
        {
            private static readonly global::System.Reflection.FieldInfo DeletedStartField;
            private static readonly global::System.Reflection.FieldInfo DeletedEndField;
            private readonly Win_Editor win;
            private readonly global::UnityEngine.Transform root;
            private readonly global::UnityEngine.Transform list;
            private readonly global::UnityEngine.Transform proto;
            private readonly global::System.Action<T, global::UnityEngine.Transform> onBind;
            private readonly global::UnityEngine.UI.LoopScrollRect loopScrollRect;
            private readonly global::System.Collections.Generic.Stack<global::UnityEngine.Transform> pool;
            private global::System.Collections.Generic.IList<T> datas;
            private readonly bool useLoop;
            public global::UnityEngine.Transform Template => null;
            public global::UnityEngine.Transform List => null;

            public LoopListAdapter(Win_Editor win, global::UnityEngine.Transform root, global::System.Action<T, global::UnityEngine.Transform> onBind)
            {
            }

            public void Refresh(global::System.Collections.Generic.IList<T> source)
            {
            }

            public global::UnityEngine.GameObject GetObject(int index)
            {
                return null;
            }

            public void ReturnObject(global::UnityEngine.Transform trans)
            {
            }

            public void ProvideData(global::UnityEngine.Transform transform, int idx)
            {
            }

            private void ResetLoopInternalState()
            {
            }

            private void EnsureLoopVerticalSettings()
            {
            }
        }

        protected global::UnityEngine.Transform root;
        protected global::UnityEngine.UI.Toggle toggle;
        protected Win_Editor win;
        public ContextUpdater(global::UnityEngine.Transform root, global::UnityEngine.UI.Toggle toggle, Win_Editor win)
        {
        }

        public abstract void Updater();
        protected void UpdateList<T>(global::System.Collections.Generic.List<T> datas, global::UnityEngine.Transform list, global::UnityEngine.Transform proto, global::System.Action<T, global::UnityEngine.Transform> updater)
        {
        }

        protected void HandleEditableSpirit(global::System.Action<global::UnityEngine.Sprite> action, global::UnityEngine.UI.InputField inputField, EditableSpirit editableSpirit, string logTag)
        {
        }

        protected void HandleEditableTexture2d(global::System.Action<global::UnityEngine.Texture2D> action, global::UnityEngine.UI.InputField inputField, EditableTexture2d editableTexture)
        {
        }

        protected void HandleEditableText(global::UnityEngine.UI.Text text, global::UnityEngine.UI.InputField inputField, EditableName editableName, string logTag)
        {
        }

        protected void HandleEditableText(global::UnityEngine.UI.Text text, global::UnityEngine.UI.InputField inputField, global::System.Func<string> numGetter, global::System.Action<string> numSetter, string logTag, global::System.Func<string, bool> CheckValidity)
        {
        }

        public abstract void Reset();
    }

    private class EventUpdater : Win_Editor.ContextUpdater
    {
        private global::UnityEngine.Transform proto;
        private global::UnityEngine.Transform list;
        private Win_Editor.ContextUpdater.LoopListAdapter<object> loopAdapter;
        private global::System.Collections.Generic.List<object> datas;
        public EventUpdater(global::UnityEngine.Transform root, global::UnityEngine.UI.Toggle toggle, Win_Editor win) : base(root, toggle, win)
        {
        }

        public override void Reset()
        {
        }

        public override void Updater()
        {
        }

        private void updateItem(object data, global::UnityEngine.Transform item)
        {
        }
    }

    private class TeamContext : Win_Editor.ContextUpdater
    {
        private global::UnityEngine.Transform proto;
        private global::UnityEngine.Transform list;
        private Win_Editor.ContextUpdater.LoopListAdapter<TeamsData> loopAdapter;
        private global::System.Collections.Generic.List<TeamsData> datas;
        private global::UnityEngine.Rect rect;
        private global::UnityEngine.UI.Button btn_choseEvent;
        private string currentEventName;
        public TeamContext(global::UnityEngine.Transform root, global::UnityEngine.UI.Toggle toggle, Win_Editor win) : base(root, toggle, win)
        {
        }

        public void Select(TeamsData team, IMatchManager matchManager, bool UpdateUI = true)
        {
        }

        public override void Updater()
        {
        }

        private void updateItem(TeamsData data, global::UnityEngine.Transform item)
        {
        }

        public void initializeDatas(object matchManager)
        {
        }

        private void UpdateEventName(object matchManager)
        {
        }

        public override void Reset()
        {
        }
    }

    private class PlayerContext : Win_Editor.ContextUpdater
    {
        private global::UnityEngine.Transform proto;
        private global::UnityEngine.Transform list;
        private Win_Editor.ContextUpdater.LoopListAdapter<ClubPlayer> loopAdapter;
        private global::System.Collections.Generic.List<ClubPlayer> datas;
        private IMatchManager matchManager;
        private TeamsData Team;
        public PlayerContext(global::UnityEngine.Transform root, global::UnityEngine.UI.Toggle toggle, Win_Editor win) : base(root, toggle, win)
        {
        }

        public void Select(TeamsData team, IMatchManager matchManager)
        {
        }

        public override void Updater()
        {
        }

        private void updateItem(ClubPlayer data, global::UnityEngine.Transform item)
        {
        }

        private void initializeDatas(TeamsData team)
        {
        }

        public override void Reset()
        {
        }
    }

    private class JerseyContext : Win_Editor.ContextUpdater
    {
        private global::UnityEngine.Transform proto;
        private global::UnityEngine.Transform list;
        private Win_Editor.ContextUpdater.LoopListAdapter<EditableTexture2d> loopAdapter;
        private global::System.Collections.Generic.List<EditableTexture2d> datas;
        private TeamsData _team;
        private global::UnityEngine.Rect rect;
        public JerseyContext(global::UnityEngine.Transform root, global::UnityEngine.UI.Toggle toggle, Win_Editor win) : base(root, toggle, win)
        {
        }

        public void Select(TeamsData team)
        {
        }

        private void ExtractionDatas(TeamsData team)
        {
        }

        public override void Updater()
        {
        }

        private void updateItem(EditableTexture2d data, global::UnityEngine.Transform item)
        {
        }

        public override void Reset()
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle t_event;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle t_team;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle t_jersey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle t_player;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform eventContext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform teamContext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform jerseyContext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerContext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReset;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnReset_bottomBanner;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnHelp;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnHelp_bottomBanner;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject loading;
    [global::UnityEngine.SerializeField]
    private Win_CommonChooseEvent win_CommonChooseEvent;
    private Win_Editor.ContextUpdater currentPage;
    private Win_Editor.EventUpdater eventEditor;
    private Win_Editor.TeamContext teamEditor;
    private Win_Editor.JerseyContext jerseyEditor;
    private Win_Editor.PlayerContext playerEditor;
    private IMatchManager targetEvent;
    private bool enterFromSettings;
    public override void OnClose()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public Win_Editor Layout(bool enterFromSettings)
    {
        return null;
    }

    public Win_Editor SelectTeam(TeamsData team, IMatchManager matchManager)
    {
        return null;
    }

    private global::SL.LeagueProto GetLastEvent()
    {
        return null;
    }

    private void UpdateTeamContextForSettings()
    {
    }

    private void ShowLoading(bool show)
    {
    }
}