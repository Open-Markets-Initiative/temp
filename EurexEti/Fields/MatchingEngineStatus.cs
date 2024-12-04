using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Matching Engine Status: Enum
    /// </summary>

    public sealed class MatchingEngineStatus
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
        ///  Fix Tag for Matching Engine Status
        /// </summary>
        public const ushort FixTag = 25005;

        /// <summary>
        ///  Length of Matching Engine Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Matching Engine Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MatchingEngineStatus.Length)
            {
                throw new System.Exception("Invalid Length for Matching Engine Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Matching Engine Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MatchingEngineStatus.Length;
        }

        /// <summary>
        ///  TryDecode Matching Engine Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MatchingEngineStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Matching Engine Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MatchingEngineStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Matching Engine Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}