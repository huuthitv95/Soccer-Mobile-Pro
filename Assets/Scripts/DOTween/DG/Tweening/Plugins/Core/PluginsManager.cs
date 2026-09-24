namespace DG.Tweening.Plugins.Core
{
    internal static class PluginsManager
    {
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _floatPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _doublePlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _intPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _uintPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _longPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _ulongPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _vector2Plugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _vector3Plugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _vector4Plugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _quaternionPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _colorPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _rectPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _rectOffsetPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _stringPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _vector3ArrayPlugin;
        private static global::DG.Tweening.Plugins.Core.ITweenPlugin _color2Plugin;
        private static global::System.Collections.Generic.Dictionary<global::System.Type, global::DG.Tweening.Plugins.Core.ITweenPlugin> _customPlugins;
        internal static global::DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>()
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return null;
        }

        public static global::DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>()
            where TPlugin : global::DG.Tweening.Plugins.Core.ITweenPlugin, new()
            where TPlugOptions : struct, global::DG.Tweening.Plugins.Options.IPlugOptions
        {
            return null;
        }

        internal static void PurgeAll()
        {
        }
    }
}