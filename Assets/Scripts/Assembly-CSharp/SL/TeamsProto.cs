namespace SL
{
    public class TeamsProto
    {
        public class JerseyInfo
        {
            public EditableTexture2d Home;
            public EditableTexture2d Away;
            public EditableTexture2d HomeGK;
            public EditableTexture2d AwayGK;
            public JerseyInfo(global::SL.TeamsProto team)
            {
            }
        }

        protected global::System.Collections.Generic.List<int> allPlayers;
        private static FormationTool.UIRole[] tmpUIRole;
        public int id { get; protected set; }
        public EditableName TeamName { get; protected set; }
        public EditableSpirit flag { get; protected set; }
        public virtual EditableName TeamNameAbbr { get; protected set; }
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, FormationTool.UIRole>>> formation { get; set; }
        public virtual int PlayerCount => 0;
        public global::System.Collections.Generic.List<int> OriginalPlayers => null;
        public virtual int Ability { get; private set; }
        public string Nation { get; private set; }
        public string City { get; private set; }
        public string classification { get; private set; }
        public string classification2 { get; private set; }
        public virtual string RealName { get; protected set; }
        public virtual string RealNameAbbr { get; protected set; }
        public global::SL.TeamsProto.JerseyInfo jerseyInfo { get; protected set; }

        public static global::UnityEngine.Sprite GetNationIcon(string name)
        {
            return null;
        }

        public static global::SL.TeamsProto Deserialization(global::System.Collections.Generic.List<string> row)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::SL.TeamsProto> LoadFromFile()
        {
            return null;
        }

        public void CopyForm(global::SL.TeamsProto teamsProto)
        {
        }

        public void CopyAppearanceFrom(global::SL.TeamsProto teamsProto)
        {
        }
    }
}