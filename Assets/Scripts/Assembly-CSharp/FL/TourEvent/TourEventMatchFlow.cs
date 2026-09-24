namespace FL.TourEvent
{
    public static class TourEventMatchFlow
    {
        public static bool TryGet(CupMatchBase match, out global::FL.TourEvent.TourEventMatch tourEventMatch)
        {
            tourEventMatch = null;
            return false;
        }

        public static void ReturnToMap(global::FL.TourEvent.TourEventMatch match)
        {
        }
    }
}