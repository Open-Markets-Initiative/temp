using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class OrderId
    {
        /// <summary>
        ///  Fix Tag for Order Id
        /// </summary>
        public const ushort FixTag = 37;

        /// <summary>
        ///  Length of Order Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Order Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + OrderId.Length)
            {
                throw new System.Exception("Invalid Length for Order Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + OrderId.Length;
        }

        /// <summary>
        ///  Encode Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Order Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + OrderId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}