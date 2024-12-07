using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Order Entries: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoOrderEntries
    {
        /// <summary>
        ///  Fix Tag for No Order Entries
        /// </summary>
        public const ushort FixTag = 2428;

        /// <summary>
        ///  Length of No Order Entries in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Order Entries
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoOrderEntries.Length)
            {
                throw new System.Exception("Invalid Length for No Order Entries");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Order Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoOrderEntries.Length;
        }

        /// <summary>
        ///  Encode No Order Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Order Entries
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoOrderEntries.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Order Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoOrderEntries.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Order Entries
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}