namespace UnityEngine.InputSystem.LowLevel
{
	public struct InputEventPtr : global::System.IEquatable<global::UnityEngine.InputSystem.LowLevel.InputEventPtr>
	{
		private unsafe readonly global::UnityEngine.InputSystem.LowLevel.InputEvent* m_EventPtr;

		public bool valid => false;

		public bool handled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int id
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::UnityEngine.InputSystem.Utilities.FourCC type => default;

		public uint sizeInBytes => 0u;

		public int deviceId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public double time
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		internal double internalTime
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* data => null;

		internal global::UnityEngine.InputSystem.Utilities.FourCC stateFormat => default;

		internal uint stateSizeInBytes => 0u;

		internal uint stateOffset => 0u;

		public unsafe InputEventPtr(global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
		{
			m_EventPtr = null;
		}

		public bool IsA<TOtherEvent>() where TOtherEvent : struct, global::UnityEngine.InputSystem.LowLevel.IInputEventTypeInfo
		{
			return false;
		}

		public global::UnityEngine.InputSystem.LowLevel.InputEventPtr Next()
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}

		public unsafe global::UnityEngine.InputSystem.LowLevel.InputEvent* ToPointer()
		{
			return null;
		}

		public bool Equals(global::UnityEngine.InputSystem.LowLevel.InputEventPtr other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(global::UnityEngine.InputSystem.LowLevel.InputEventPtr left, global::UnityEngine.InputSystem.LowLevel.InputEventPtr right)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.InputSystem.LowLevel.InputEventPtr left, global::UnityEngine.InputSystem.LowLevel.InputEventPtr right)
		{
			return false;
		}

		public unsafe static implicit operator global::UnityEngine.InputSystem.LowLevel.InputEventPtr(global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
		{
			return default;
		}

		public unsafe static global::UnityEngine.InputSystem.LowLevel.InputEventPtr From(global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
		{
			return default;
		}

		public unsafe static implicit operator global::UnityEngine.InputSystem.LowLevel.InputEvent*(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
		{
			return null;
		}

		public unsafe static global::UnityEngine.InputSystem.LowLevel.InputEvent* FromInputEventPtr(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
		{
			return null;
		}
	}
}
