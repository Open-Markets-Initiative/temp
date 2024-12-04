using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Market Segment Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class MarketSegmentId
    {
        /// <summary>
        ///  Fix Tag for Market Segment Id
        /// </summary>
        public const ushort FixTag = 1300;

        /// <summary>
        ///  Length of Market Segment Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Market Segment Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + MarketSegmentId.Length)
            {
                throw new System.Exception("Invalid Length for Market Segment Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MarketSegmentId.Length;
        }

        /// <summary>
        ///  Encode Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Market Segment Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + MarketSegmentId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MarketSegmentId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}