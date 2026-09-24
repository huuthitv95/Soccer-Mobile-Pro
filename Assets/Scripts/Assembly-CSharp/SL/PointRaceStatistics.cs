namespace SL
{
    public class PointRaceStatistics
    {
        public int teamId;
        public int score;
        public int win;
        public int draw;
        public int lose;
        public int goal;
        public int conceded;
        public int goalDifference;
        public int round;
        public int awayGoal;
        public void Reset()
        {
        }

        public static bool operator>(global::SL.PointRaceStatistics a, global::SL.PointRaceStatistics b)
        {
            return false;
        }

        public static bool operator <(global::SL.PointRaceStatistics a, global::SL.PointRaceStatistics b)
        {
            return false;
        }

        public static bool operator ==(global::SL.PointRaceStatistics a, global::SL.PointRaceStatistics b)
        {
            return false;
        }

        public static bool operator !=(global::SL.PointRaceStatistics a, global::SL.PointRaceStatistics b)
        {
            return false;
        }
    }
}