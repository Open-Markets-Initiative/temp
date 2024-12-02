using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Throttle No Msgs: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class ThrottleNoMsgs
    {
        /// <summary>
        ///  Length of Throttle No Msgs in bytes
        /// </summary>
        public const int Length = 4;

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
        ///  TryDecode Throttle No Msgs
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + ThrottleNoMsgs.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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