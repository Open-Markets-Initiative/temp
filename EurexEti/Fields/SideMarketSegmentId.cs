using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Side Market Segment Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class SideMarketSegmentId
    {
        /// <summary>
        ///  Length of Side Market Segment Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Side Market Segment Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + SideMarketSegmentId.Length)
            {
                throw new System.Exception("Invalid Length for Side Market Segment Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Side Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SideMarketSegmentId.Length;
        }

        /// <summary>
        ///  Encode Side Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Side Market Segment Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + SideMarketSegmentId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Side Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SideMarketSegmentId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Side Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}