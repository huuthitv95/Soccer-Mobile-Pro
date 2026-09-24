namespace FLTest.GlobalConfig
{
    public static class PlayerSkillTester
    {
        public class PlayerSkillConfig
        {
            public int playerId;
            public global::EngineMessages.PlayerSkill playerSkill;
        }

        [global::FLTest.GlobalConfig.GlobalConfig]
        public class PlayerSkillTestConfig
        {
            public global::System.Collections.Generic.List<global::FLTest.GlobalConfig.PlayerSkillTester.PlayerSkillConfig> playerSkills;
        }

        private static readonly global::FLTest.GlobalConfig.PlayerSkillTester.PlayerSkillTestConfig _config;
        private static global::FLTest.GlobalConfig.PlayerSkillTester.PlayerSkillTestConfig Config => null;

        public static void ApplyDebugConfig(int playerId, global::System.Collections.Generic.ICollection<global::EngineMessages.PlayerSkill> skills)
        {
        }
    }
}