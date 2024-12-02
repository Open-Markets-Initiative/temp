using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Related Market Segment Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class RelatedMarketSegmentId
    {
        /// <summary>
        ///  Length of Related Market Segment Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Related Market Segment Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + RelatedMarketSegmentId.Length)
            {
                throw new System.Exception("Invalid Length for Related Market Segment Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Related Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RelatedMarketSegmentId.Length;
        }

        /// <summary>
        ///  Encode Related Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Related Market Segment Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + RelatedMarketSegmentId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Related Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RelatedMarketSegmentId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Related Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}