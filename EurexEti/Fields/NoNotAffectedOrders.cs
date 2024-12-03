using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Not Affected Orders: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoNotAffectedOrders
    {
        /// <summary>
        ///  Fix Tag for No Not Affected Orders
        /// </summary>
        public const ushort FixTag = 1370;

        /// <summary>
        ///  Length of No Not Affected Orders in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode No Not Affected Orders
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + NoNotAffectedOrders.Length)
            {
                throw new System.Exception("Invalid Length for No Not Affected Orders");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Not Affected Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoNotAffectedOrders.Length;
        }

        /// <summary>
        ///  Encode No Not Affected Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Not Affected Orders
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoNotAffectedOrders.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Not Affected Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoNotAffectedOrders.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Not Affected Orders
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}