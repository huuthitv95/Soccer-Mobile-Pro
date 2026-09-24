namespace FLTest.GlobalConfig
{
    public static class IAPPlayerTester
    {
        public class IAPPlayerState
        {
            public int playerId;
            public bool CheckPurchased()
            {
                return false;
            }

            public void MarkAsPurchased()
            {
            }
        }

        [global::FLTest.GlobalConfig.GlobalConfig]
        public class IAPPlayerTestConfig
        {
            public global::System.Collections.Generic.List<global::FLTest.GlobalConfig.IAPPlayerTester.IAPPlayerState> allPlayers;
        }
    }
}