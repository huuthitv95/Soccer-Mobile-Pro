namespace UnityEngine.UI
{
    public static class DefaultControls
    {
        public interface IFactoryControls
        {
            global::UnityEngine.GameObject CreateGameObject(string name, params global::System.Type[] components);
        }

        private class DefaultRuntimeFactory : global::UnityEngine.UI.DefaultControls.IFactoryControls
        {
            public static global::UnityEngine.UI.DefaultControls.IFactoryControls Default;
            public global::UnityEngine.GameObject CreateGameObject(string name, params global::System.Type[] components)
            {
                return null;
            }
        }

        public struct Resources
        {
            public global::UnityEngine.Sprite standard;
            public global::UnityEngine.Sprite background;
            public global::UnityEngine.Sprite inputField;
            public global::UnityEngine.Sprite knob;
            public global::UnityEngine.Sprite checkmark;
            public global::UnityEngine.Sprite dropdown;
            public global::UnityEngine.Sprite mask;
        }

        private static global::UnityEngine.UI.DefaultControls.IFactoryControls m_CurrentFactory;
        private const float kWidth = 160f;
        private const float kThickHeight = 30f;
        private const float kThinHeight = 20f;
        private static global::UnityEngine.Vector2 s_ThickElementSize;
        private static global::UnityEngine.Vector2 s_ThinElementSize;
        private static global::UnityEngine.Vector2 s_ImageElementSize;
        private static global::UnityEngine.Color s_DefaultSelectableColor;
        private static global::UnityEngine.Color s_PanelColor;
        private static global::UnityEngine.Color s_TextColor;
        public static global::UnityEngine.UI.DefaultControls.IFactoryControls factory => null;

        private static global::UnityEngine.GameObject CreateUIElementRoot(string name, global::UnityEngine.Vector2 size, params global::System.Type[] components)
        {
            return null;
        }

        private static global::UnityEngine.GameObject CreateUIObject(string name, global::UnityEngine.GameObject parent, params global::System.Type[] components)
        {
            return null;
        }

        private static void SetDefaultTextValues(global::UnityEngine.UI.Text lbl)
        {
        }

        private static void SetDefaultColorTransitionValues(global::UnityEngine.UI.Selectable slider)
        {
        }

        private static void SetParentAndAlign(global::UnityEngine.GameObject child, global::UnityEngine.GameObject parent)
        {
        }

        private static void SetLayerRecursively(global::UnityEngine.GameObject go, int layer)
        {
        }

        public static global::UnityEngine.GameObject CreatePanel(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateButton(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateText(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateImage(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateRawImage(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateSlider(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateScrollbar(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateToggle(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateInputField(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateDropdown(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }

        public static global::UnityEngine.GameObject CreateScrollView(global::UnityEngine.UI.DefaultControls.Resources resources)
        {
            return null;
        }
    }
}