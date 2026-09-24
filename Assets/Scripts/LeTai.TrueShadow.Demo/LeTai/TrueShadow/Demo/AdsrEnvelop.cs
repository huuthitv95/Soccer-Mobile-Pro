namespace LeTai.TrueShadow.Demo
{
    public class AdsrEnvelop : global::System.Collections.Generic.IEnumerator<double>, global::System.Collections.IEnumerator, global::System.IDisposable
    {
        public int numAttackSamples;
        public int numDecaySamples;
        public double sustainScale;
        public int numReleaseSamples;
        private int releaseSample;
        private int currentSample;
        public global::LeTai.TrueShadow.Demo.AdsrStage CurrentStage { get; private set; }
        public double Current { get; private set; }

        object global::System.Collections.IEnumerator.Current => null;

        public void Release()
        {
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }

        private void MaybeAdvancesStage()
        {
        }

        private static double Map(double value, double fromLow, double fromHigh, double toLow, double toHigh)
        {
            return 0.0;
        }

        public void Dispose()
        {
        }
    }
}