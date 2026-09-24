namespace DG.Tweening
{
	public static class DOTweenCYInstruction
	{
		public class WaitForCompletion : global::UnityEngine.CustomYieldInstruction
		{
			private readonly global::DG.Tweening.Tween t;

			public override bool keepWaiting => false;

			public WaitForCompletion(global::DG.Tweening.Tween tween)
			{
			}
		}

		public class WaitForRewind : global::UnityEngine.CustomYieldInstruction
		{
			private readonly global::DG.Tweening.Tween t;

			public override bool keepWaiting => false;

			public WaitForRewind(global::DG.Tweening.Tween tween)
			{
			}
		}

		public class WaitForKill : global::UnityEngine.CustomYieldInstruction
		{
			private readonly global::DG.Tweening.Tween t;

			public override bool keepWaiting => false;

			public WaitForKill(global::DG.Tweening.Tween tween)
			{
			}
		}

		public class WaitForElapsedLoops : global::UnityEngine.CustomYieldInstruction
		{
			private readonly global::DG.Tweening.Tween t;

			private readonly int elapsedLoops;

			public override bool keepWaiting => false;

			public WaitForElapsedLoops(global::DG.Tweening.Tween tween, int elapsedLoops)
			{
			}
		}

		public class WaitForPosition : global::UnityEngine.CustomYieldInstruction
		{
			private readonly global::DG.Tweening.Tween t;

			private readonly float position;

			public override bool keepWaiting => false;

			public WaitForPosition(global::DG.Tweening.Tween tween, float position)
			{
			}
		}

		public class WaitForStart : global::UnityEngine.CustomYieldInstruction
		{
			private readonly global::DG.Tweening.Tween t;

			public override bool keepWaiting => false;

			public WaitForStart(global::DG.Tweening.Tween tween)
			{
			}
		}
	}
}
