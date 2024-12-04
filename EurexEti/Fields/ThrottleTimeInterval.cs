using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Throttle Time Interval: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ThrottleTimeInterval
    {
        /// <summary>
        ///  Fix Tag for Throttle Time Interval
        /// </summary>
        public const ushort FixTag = 1614;

        /// <summary>
        ///  Length of Throttle Time Interval in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Throttle Time Interval
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, long value, int length, out int current)
        {
            if (length > offset + ThrottleTimeInterval.Length)
            {
                throw new System.Exception("Invalid Length for Throttle Time Interval");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Throttle Time Interval
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, long value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ThrottleTimeInterval.Length;
        }

        /// <summary>
        ///  Encode Throttle Time Interval
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, long value)
        {
            *(long*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Throttle Time Interval
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
        {
            if (length > offset + ThrottleTimeInterval.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Throttle Time Interval
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static long Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ThrottleTimeInterval.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Throttle Time Interval
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static long Decode(byte* pointer, int offset)
        {
            return *(long*) (pointer + offset);
        }
    }
}