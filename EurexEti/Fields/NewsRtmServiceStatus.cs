using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  News Rtm Service Status: Enum
    /// </summary>

    public sealed class NewsRtmServiceStatus
    {
        /// <summary>
        ///  Unavailable
        /// </summary>
        public const byte Unavailable = 0;

        /// <summary>
        ///  Available
        /// </summary>
        public const byte Available = 1;

        /// <summary>
        ///  Fix Tag for News Rtm Service Status
        /// </summary>
        public const ushort FixTag = 25237;

        /// <summary>
        ///  Length of News Rtm Service Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode News Rtm Service Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NewsRtmServiceStatus.Length)
            {
                throw new System.Exception("Invalid Length for News Rtm Service Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode News Rtm Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + NewsRtmServiceStatus.Length;
        }

        /// <summary>
        ///  TryDecode News Rtm Service Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NewsRtmServiceStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode News Rtm Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NewsRtmServiceStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode News Rtm Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}