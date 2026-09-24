public class IngameButtonConfiguration : global::Common.Singleton<IngameButtonConfiguration>
{
    public enum ButtonType
    {
        Joystick = 0,
        Sprint = 1,
        Shoot = 2,
        Through = 3,
        Pass = 4,
        Count = 5
    }

    public struct IngameButtonConfig
    {
        public IngameButtonConfiguration.ButtonType buttonType;
        public global::UnityEngine.Vector2 position;
        public float scale;
        public float alpha;
        private static global::System.Collections.Generic.Dictionary<IngameButtonConfiguration.ButtonType, float> radiusDict;
        public float radius => 0f;

        public float CalculateRealScale()
        {
            return 0f;
        }

        public float CalculateRealAlpha()
        {
            return 0f;
        }

        public static float CalculateRealAlpha(float normalizedAlpha)
        {
            return 0f;
        }

        public bool CheckIntersect(IngameButtonConfiguration.IngameButtonConfig other)
        {
            return false;
        }

        public bool CheckIntersect(global::UnityEngine.Rect rect)
        {
            return false;
        }

        public IngameButtonConfig(IngameButtonConfiguration.IngameButtonConfig other)
        {
            buttonType = IngameButtonConfiguration.ButtonType.Joystick;
            position = default;
            scale = 0f;
            alpha = 0f;
        }
    }

    private global::System.Collections.Generic.List<IngameButtonConfiguration.IngameButtonConfig> buttonConfig;
    private readonly global::System.Collections.Generic.List<IngameButtonConfiguration.IngameButtonConfig> defaultButtonConfig;
    private global::Google.Protobuf.Collections.RepeatedField<global::Srv.IngameButtonConfig> archive;
    public global::System.Collections.Generic.IEnumerable<IngameButtonConfiguration.IngameButtonConfig> DefaultButtonConfig => null;
    public global::System.Collections.Generic.IEnumerable<IngameButtonConfiguration.IngameButtonConfig> ButtonConfigs => null;

    public void UpdateButtonConfig(int slotId, IngameButtonConfiguration.IngameButtonConfig config, bool save = true)
    {
    }

    public void UpdateButtonConfig(int slotId, IngameButtonConfiguration.ButtonType buttonType, global::UnityEngine.Vector2 position, float scale, float alpha, bool save = true)
    {
    }
}