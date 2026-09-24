namespace TMPro
{
	public static class TMP_TextUtilities
	{
		private struct LineSegment
		{
			public global::UnityEngine.Vector3 Point1;

			public global::UnityEngine.Vector3 Point2;

			public LineSegment(global::UnityEngine.Vector3 p1, global::UnityEngine.Vector3 p2)
			{
				Point1 = default;
				Point2 = default;
			}
		}

		private static global::UnityEngine.Vector3[] m_rectWorldCorners;

		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

		public static int GetCursorIndexFromPosition(global::TMPro.TMP_Text textComponent, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera)
		{
			return 0;
		}

		public static int GetCursorIndexFromPosition(global::TMPro.TMP_Text textComponent, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera, out global::TMPro.CaretPosition cursor)
		{
			cursor = default;
			return 0;
		}

		public static int FindNearestLine(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera)
		{
			return 0;
		}

		public static int FindNearestCharacterOnLine(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, int line, global::UnityEngine.Camera camera, bool visibleOnly)
		{
			return 0;
		}

		public static bool IsIntersectingRectTransform(global::UnityEngine.RectTransform rectTransform, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera)
		{
			return false;
		}

		public static int FindIntersectingCharacter(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera, bool visibleOnly)
		{
			return 0;
		}

		public static int FindNearestCharacter(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera, bool visibleOnly)
		{
			return 0;
		}

		public static int FindIntersectingWord(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera)
		{
			return 0;
		}

		public static int FindNearestWord(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera)
		{
			return 0;
		}

		public static int FindIntersectingLine(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera)
		{
			return 0;
		}

		public static int FindIntersectingLink(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera)
		{
			return 0;
		}

		public static int FindNearestLink(global::TMPro.TMP_Text text, global::UnityEngine.Vector3 position, global::UnityEngine.Camera camera)
		{
			return 0;
		}

		private static bool PointIntersectRectangle(global::UnityEngine.Vector3 m, global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, global::UnityEngine.Vector3 c, global::UnityEngine.Vector3 d)
		{
			return false;
		}

		public static bool ScreenPointToWorldPointInRectangle(global::UnityEngine.Transform transform, global::UnityEngine.Vector2 screenPoint, global::UnityEngine.Camera cam, out global::UnityEngine.Vector3 worldPoint)
		{
			worldPoint = default;
			return false;
		}

		private static bool IntersectLinePlane(global::TMPro.TMP_TextUtilities.LineSegment line, global::UnityEngine.Vector3 point, global::UnityEngine.Vector3 normal, out global::UnityEngine.Vector3 intersectingPoint)
		{
			intersectingPoint = default;
			return false;
		}

		public static float DistanceToLine(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b, global::UnityEngine.Vector3 point)
		{
			return 0f;
		}

		public static char ToLowerFast(char c)
		{
			return '\0';
		}

		public static char ToUpperFast(char c)
		{
			return '\0';
		}

		internal static uint ToUpperASCIIFast(uint c)
		{
			return 0u;
		}

		public static int GetHashCode(string s)
		{
			return 0;
		}

		public static int GetSimpleHashCode(string s)
		{
			return 0;
		}

		public static uint GetSimpleHashCodeLowercase(string s)
		{
			return 0u;
		}

		public static int HexToInt(char hex)
		{
			return 0;
		}

		public static int StringHexToInt(string s)
		{
			return 0;
		}
	}
}
