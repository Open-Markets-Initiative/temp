using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Quote Events Index: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoQuoteEventsIndex
    {
        /// <summary>
        ///  Fix Tag for No Quote Events Index
        /// </summary>
        public const ushort FixTag = 25011;

        /// <summary>
        ///  Length of No Quote Events Index in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Quote Events Index
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoQuoteEventsIndex.Length)
            {
                throw new System.Exception("Invalid Length for No Quote Events Index");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Quote Events Index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoQuoteEventsIndex.Length;
        }

        /// <summary>
        ///  Encode No Quote Events Index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Quote Events Index
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoQuoteEventsIndex.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Quote Events Index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoQuoteEventsIndex.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Quote Events Index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}