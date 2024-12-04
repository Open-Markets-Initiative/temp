using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No New Basket Side Alloc: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoNewBasketSideAlloc
    {
        /// <summary>
        ///  Fix Tag for No New Basket Side Alloc
        /// </summary>
        public const ushort FixTag = 25252;

        /// <summary>
        ///  Length of No New Basket Side Alloc in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode No New Basket Side Alloc
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + NoNewBasketSideAlloc.Length)
            {
                throw new System.Exception("Invalid Length for No New Basket Side Alloc");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No New Basket Side Alloc
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoNewBasketSideAlloc.Length;
        }

        /// <summary>
        ///  Encode No New Basket Side Alloc
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No New Basket Side Alloc
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoNewBasketSideAlloc.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No New Basket Side Alloc
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoNewBasketSideAlloc.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No New Basket Side Alloc
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}