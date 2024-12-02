using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Basket Root Party Grps: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoBasketRootPartyGrps
    {
        /// <summary>
        ///  Length of No Basket Root Party Grps in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Basket Root Party Grps
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoBasketRootPartyGrps.Length)
            {
                throw new System.Exception("Invalid Length for No Basket Root Party Grps");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Basket Root Party Grps
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoBasketRootPartyGrps.Length;
        }

        /// <summary>
        ///  Encode No Basket Root Party Grps
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Basket Root Party Grps
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoBasketRootPartyGrps.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Basket Root Party Grps
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoBasketRootPartyGrps.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Basket Root Party Grps
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}