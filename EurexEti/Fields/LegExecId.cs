using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Leg Exec Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class LegExecId
    {
        /// <summary>
        ///  Fix Tag for Leg Exec Id
        /// </summary>
        public const ushort FixTag = 1893;

        /// <summary>
        ///  Length of Leg Exec Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Leg Exec Id
        /// </summary>
        public const int NoValue = 0x80000000;

        /// <summary>
        ///  Encode Leg Exec Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + LegExecId.Length)
            {
                throw new System.Exception("Invalid Length for Leg Exec Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + LegExecId.Length;
        }

        /// <summary>
        ///  Encode Leg Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Leg Exec Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + LegExecId.Length)
            {
                throw new System.Exception("Invalid Length for Leg Exec Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Leg Exec Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + LegExecId.Length;
        }

        /// <summary>
        ///  Set Leg Exec Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(int*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Leg Exec Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + LegExecId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Leg Exec Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Leg Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegExecId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}