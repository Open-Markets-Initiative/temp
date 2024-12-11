using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Throttle No Msgs: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class ThrottleNoMsgs
    {
        /// <summary>
        ///  Fix Tag for Throttle No Msgs
        /// </summary>
        public const ushort FixTag = 1613;

        /// <summary>
        ///  Length of Throttle No Msgs in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Throttle No Msgs
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Throttle No Msgs
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + ThrottleNoMsgs.Length)
            {
                throw new System.Exception("Invalid Length for Throttle No Msgs");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Throttle No Msgs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ThrottleNoMsgs.Length;
        }

        /// <summary>
        ///  Encode Throttle No Msgs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Throttle No Msgs to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ThrottleNoMsgs.Length)
            {
                throw new System.Exception("Invalid Length for Throttle No Msgs");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Throttle No Msgs to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ThrottleNoMsgs.Length;
        }

        /// <summary>
        ///  Set Throttle No Msgs to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Throttle No Msgs
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + ThrottleNoMsgs.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Throttle No Msgs
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Throttle No Msgs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ThrottleNoMsgs.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Throttle No Msgs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}