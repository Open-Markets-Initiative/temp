using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Leg Symbol: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class LegSymbol
    {
        /// <summary>
        ///  Fix Tag for Leg Symbol
        /// </summary>
        public const ushort FixTag = 600;

        /// <summary>
        ///  Length of Leg Symbol in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Leg Symbol
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + LegSymbol.Length)
            {
                throw new System.Exception("Invalid Length for Leg Symbol");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + LegSymbol.Length;
        }

        /// <summary>
        ///  Encode Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Leg Symbol
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + LegSymbol.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegSymbol.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}