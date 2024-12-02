using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Check Sum Correction: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class CheckSumCorrection
    {
        /// <summary>
        ///  Length of Check Sum Correction in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Check Sum Correction
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + CheckSumCorrection.Length)
            {
                throw new System.Exception("Invalid Length for Check Sum Correction");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Check Sum Correction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + CheckSumCorrection.Length;
        }

        /// <summary>
        ///  Encode Check Sum Correction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Check Sum Correction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + CheckSumCorrection.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Check Sum Correction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + CheckSumCorrection.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Check Sum Correction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}