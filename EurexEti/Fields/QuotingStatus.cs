using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quoting Status: Enum
    /// </summary>

    public static class QuotingStatus
    {
        /// <summary>
        ///  Open/Active
        /// </summary>
        public const byte OpenActive = 1;

        /// <summary>
        ///  Open/Working
        /// </summary>
        public const byte OpenIdle = 2;

        /// <summary>
        ///  Closed/Inactive
        /// </summary>
        public const byte ClosedInactive = 3;

        /// <summary>
        ///  Fix Tag for Quoting Status
        /// </summary>
        public const ushort FixTag = 28787;

        /// <summary>
        ///  Length of Quoting Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Quoting Status
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Quoting Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuotingStatus.Length)
            {
                throw new System.Exception("Invalid Length for Quoting Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quoting Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuotingStatus.Length;
        }

        /// <summary>
        ///  Check available length and set Quoting Status to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuotingStatus.Length)
            {
                throw new System.Exception("Invalid Length for Quoting Status");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quoting Status to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuotingStatus.Length;
        }

        /// <summary>
        ///  Set Quoting Status to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Quoting Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuotingStatus.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quoting Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Quoting Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuotingStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quoting Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}