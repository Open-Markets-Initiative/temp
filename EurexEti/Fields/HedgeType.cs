using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Hedge Type: Enum
    /// </summary>

    public sealed class HedgeType
    {
        /// <summary>
        ///  Duration Hedge
        /// </summary>
        public const byte DurationHedge = 0;

        /// <summary>
        ///  Nominal Hedge
        /// </summary>
        public const byte NominalHedge = 1;

        /// <summary>
        ///  Price Factor Hedge
        /// </summary>
        public const byte PriceFactorHedge = 2;

        /// <summary>
        ///  Fix Tag for Hedge Type
        /// </summary>
        public const ushort FixTag = 29008;

        /// <summary>
        ///  Length of Hedge Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Hedge Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + HedgeType.Length)
            {
                throw new System.Exception("Invalid Length for Hedge Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Hedge Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + HedgeType.Length;
        }

        /// <summary>
        ///  TryDecode Hedge Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + HedgeType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Hedge Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + HedgeType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Hedge Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}