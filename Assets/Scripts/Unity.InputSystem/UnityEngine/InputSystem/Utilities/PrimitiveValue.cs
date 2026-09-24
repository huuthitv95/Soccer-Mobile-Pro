namespace UnityEngine.InputSystem.Utilities
{
    [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2)]
    public struct PrimitiveValue : global::System.IEquatable<global::UnityEngine.InputSystem.Utilities.PrimitiveValue>, global::System.IConvertible
    {
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        private global::System.TypeCode m_Type;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private bool m_BoolValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private char m_CharValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private byte m_ByteValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private sbyte m_SByteValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private short m_ShortValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private ushort m_UShortValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private int m_IntValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private uint m_UIntValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private long m_LongValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private ulong m_ULongValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private float m_FloatValue;
        [global::System.Runtime.InteropServices.FieldOffset(4)]
        private double m_DoubleValue;
        internal unsafe byte* valuePtr => null;
        public global::System.TypeCode type => global::System.TypeCode.Empty;
        public bool isEmpty => false;

        public PrimitiveValue(bool value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(char value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(byte value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(sbyte value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(short value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(ushort value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(int value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(uint value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(long value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(ulong value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(float value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public PrimitiveValue(double value)
        {
            m_Type = global::System.TypeCode.Empty;
            m_BoolValue = false;
            m_CharValue = '\0';
            m_ByteValue = 0;
            m_SByteValue = 0;
            m_ShortValue = 0;
            m_UShortValue = 0;
            m_IntValue = 0;
            m_UIntValue = 0u;
            m_LongValue = 0L;
            m_ULongValue = 0uL;
            m_FloatValue = 0f;
            m_DoubleValue = 0.0;
        }

        public global::UnityEngine.InputSystem.Utilities.PrimitiveValue ConvertTo(global::System.TypeCode type)
        {
            return default;
        }

        public bool Equals(global::UnityEngine.InputSystem.Utilities.PrimitiveValue other)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public static bool operator ==(global::UnityEngine.InputSystem.Utilities.PrimitiveValue left, global::UnityEngine.InputSystem.Utilities.PrimitiveValue right)
        {
            return false;
        }

        public static bool operator !=(global::UnityEngine.InputSystem.Utilities.PrimitiveValue left, global::UnityEngine.InputSystem.Utilities.PrimitiveValue right)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromString(string value)
        {
            return default;
        }

        public global::System.TypeCode GetTypeCode()
        {
            return global::System.TypeCode.Empty;
        }

        public bool ToBoolean(global::System.IFormatProvider provider = null)
        {
            return false;
        }

        public byte ToByte(global::System.IFormatProvider provider = null)
        {
            return 0;
        }

        public char ToChar(global::System.IFormatProvider provider = null)
        {
            return '\0';
        }

        public global::System.DateTime ToDateTime(global::System.IFormatProvider provider = null)
        {
            return default;
        }

        public decimal ToDecimal(global::System.IFormatProvider provider = null)
        {
            return 0m;
        }

        public double ToDouble(global::System.IFormatProvider provider = null)
        {
            return 0.0;
        }

        public short ToInt16(global::System.IFormatProvider provider = null)
        {
            return 0;
        }

        public int ToInt32(global::System.IFormatProvider provider = null)
        {
            return 0;
        }

        public long ToInt64(global::System.IFormatProvider provider = null)
        {
            return 0L;
        }

        public sbyte ToSByte(global::System.IFormatProvider provider = null)
        {
            return 0;
        }

        public float ToSingle(global::System.IFormatProvider provider = null)
        {
            return 0f;
        }

        public string ToString(global::System.IFormatProvider provider)
        {
            return null;
        }

        public object ToType(global::System.Type conversionType, global::System.IFormatProvider provider)
        {
            return null;
        }

        public ushort ToUInt16(global::System.IFormatProvider provider = null)
        {
            return 0;
        }

        public uint ToUInt32(global::System.IFormatProvider provider = null)
        {
            return 0u;
        }

        public ulong ToUInt64(global::System.IFormatProvider provider = null)
        {
            return 0uL;
        }

        public object ToObject()
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue From<TValue>(TValue value)
            where TValue : struct
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromObject(object value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(bool value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(char value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(byte value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(sbyte value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(short value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(ushort value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(int value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(uint value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(long value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(ulong value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(float value)
        {
            return default;
        }

        public static implicit operator global::UnityEngine.InputSystem.Utilities.PrimitiveValue(double value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromBoolean(bool value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromChar(char value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromByte(byte value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromSByte(sbyte value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt16(short value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt16(ushort value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt32(int value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt32(uint value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromInt64(long value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromUInt64(ulong value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromSingle(float value)
        {
            return default;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue FromDouble(double value)
        {
            return default;
        }
    }
}