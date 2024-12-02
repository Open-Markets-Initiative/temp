using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Throttle Disconnect Limit: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class ThrottleDisconnectLimit
    {
        /// <summary>
        ///  Length of Throttle Disconnect Limit in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Throttle Disconnect Limit
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + ThrottleDisconnectLimit.Length)
            {
                throw new System.Exception("Invalid Length for Throttle Disconnect Limit");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Throttle Disconnect Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ThrottleDisconnectLimit.Length;
        }

        /// <summary>
        ///  Encode Throttle Disconnect Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Throttle Disconnect Limit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + ThrottleDisconnectLimit.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Throttle Disconnect Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ThrottleDisconnectLimit.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Throttle Disconnect Limit
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}