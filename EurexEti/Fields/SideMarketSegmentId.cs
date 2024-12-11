using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Market Segment Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class SideMarketSegmentId
    {
        /// <summary>
        ///  Fix Tag for Side Market Segment Id
        /// </summary>
        public const ushort FixTag = 1898;

        /// <summary>
        ///  Length of Side Market Segment Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Side Market Segment Id
        /// </summary>
        public const int NoValue = 0x80000000;

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
        ///  Check available length and set Side Market Segment Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SideMarketSegmentId.Length)
            {
                throw new System.Exception("Invalid Length for Side Market Segment Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Side Market Segment Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SideMarketSegmentId.Length;
        }

        /// <summary>
        ///  Set Side Market Segment Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(int*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Side Market Segment Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + SideMarketSegmentId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Side Market Segment Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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