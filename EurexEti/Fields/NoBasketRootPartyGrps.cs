using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Basket Root Party Grps: Runtime Count Field
    /// </summary>

    public static class NoBasketRootPartyGrps
    {
        /// <summary>
        ///  Fix Tag for No Basket Root Party Grps
        /// </summary>
        public const ushort FixTag = 25165;

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
        ///  Check available length and set No Basket Root Party Grps to 0
        /// </summary>
        public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NoBasketRootPartyGrps.Length)
            {
                throw new System.Exception("Invalid Length for No Basket Root Party Grps");
            }

            Zero(pointer, offset, out current);
        }

        /// <summary>
        ///  Set No Basket Root Party Grps to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset, out int current)
        {
            Zero(pointer, offset);

            current = offset + NoBasketRootPartyGrps.Length;
        }

        /// <summary>
        ///  Set No Basket Root Party Grps to 0
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = 0;
        }

        /// <summary>
        ///  TryDecode No Basket Root Party Grps
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoBasketRootPartyGrps.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode No Basket Root Party Grps
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value > 0;
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