namespace FLMessageSystem
{
	public struct MatchCompletedMessage
	{
		public CupMatchBase Match { get; private set; }

		public MatchCompletedMessage(CupMatchBase match)
		{
			Match = null;
		}
	}
}
