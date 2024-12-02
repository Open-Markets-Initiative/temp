using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Reversal Initiation Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ReversalInitiationTime
    {
        /// <summary>
        ///  Length of Reversal Initiation Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Reversal Initiation Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ReversalInitiationTime.Length)
            {
                throw new System.Exception("Invalid Length for Reversal Initiation Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Reversal Initiation Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ReversalInitiationTime.Length;
        }

        /// <summary>
        ///  Encode Reversal Initiation Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Reversal Initiation Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ReversalInitiationTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Reversal Initiation Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ReversalInitiationTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Reversal Initiation Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}