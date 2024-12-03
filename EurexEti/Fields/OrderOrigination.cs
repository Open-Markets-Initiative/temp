using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Origination: Enum
    /// </summary>

    public sealed class OrderOrigination
    {
        /// <summary>
        ///  Order received from a direct access customer
        /// </summary>
        public const byte Directaccessorsponsoredaccesscustomer = 5;

        /// <summary>
        ///  Fix Tag for Order Origination
        /// </summary>
        public const ushort FixTag = 1724;

        /// <summary>
        ///  Length of Order Origination in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Order Origination
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OrderOrigination.Length)
            {
                throw new System.Exception("Invalid Length for Order Origination");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Origination
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OrderOrigination.Length;
        }

        /// <summary>
        ///  TryDecode Order Origination
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OrderOrigination.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Origination
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderOrigination.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Origination
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}