using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Quote Entries: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoQuoteEntries
    {
        /// <summary>
        ///  Fix Tag for No Quote Entries
        /// </summary>
        public const ushort FixTag = 295;

        /// <summary>
        ///  Length of No Quote Entries in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Quote Entries
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoQuoteEntries.Length)
            {
                throw new System.Exception("Invalid Length for No Quote Entries");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Quote Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoQuoteEntries.Length;
        }

        /// <summary>
        ///  Encode No Quote Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Quote Entries
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoQuoteEntries.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Quote Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoQuoteEntries.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Quote Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}