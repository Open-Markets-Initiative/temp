using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Pct Count: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class PctCount
    {
        /// <summary>
        ///  Fix Tag for Pct Count
        /// </summary>
        public const ushort FixTag = 28615;

        /// <summary>
        ///  Length of Pct Count in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Pct Count
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + PctCount.Length)
            {
                throw new System.Exception("Invalid Length for Pct Count");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Pct Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + PctCount.Length;
        }

        /// <summary>
        ///  Encode Pct Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Pct Count
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + PctCount.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Pct Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PctCount.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Pct Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}