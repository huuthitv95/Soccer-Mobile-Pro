namespace LeTai.Effects
{
    public static class ShaderProperties
    {
        private static bool isInitialized;
        public static int[] intermediateRT;
        public static int blurRadius;
        public static int blurTextureCropRegion;
        public static void Init()
        {
        }

        public static void Init(int stackDepth)
        {
        }
    }
}