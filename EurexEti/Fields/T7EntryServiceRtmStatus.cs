using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  T 7 Entry Service Rtm Status: Enum
    /// </summary>

    public sealed class T7EntryServiceRtmStatus
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
        ///  Fix Tag for T 7 Entry Service Rtm Status
        /// </summary>
        public const ushort FixTag = 25050;

        /// <summary>
        ///  Length of T 7 Entry Service Rtm Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode T 7 Entry Service Rtm Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + T7EntryServiceRtmStatus.Length)
            {
                throw new System.Exception("Invalid Length for T 7 Entry Service Rtm Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode T 7 Entry Service Rtm Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + T7EntryServiceRtmStatus.Length;
        }

        /// <summary>
        ///  TryDecode T 7 Entry Service Rtm Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + T7EntryServiceRtmStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode T 7 Entry Service Rtm Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + T7EntryServiceRtmStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode T 7 Entry Service Rtm Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}