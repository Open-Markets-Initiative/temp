using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Category: Enum
    /// </summary>

    public static class OrderCategory
    {
        /// <summary>
        ///  Order
        /// </summary>
        public const char Order = '1';

        /// <summary>
        ///  Quote
        /// </summary>
        public const char Quote = '2';

        /// <summary>
        ///  Fix Tag for Order Category
        /// </summary>
        public const ushort FixTag = 1115;

        /// <summary>
        ///  Length of Order Category in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Order Category
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
        {
            if (length > offset + OrderCategory.Length)
            {
                throw new System.Exception("Invalid Length for Order Category");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Category
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

            Encode(pointer, offset, character, out current);
        }

        /// <summary>
        ///  Encode Order Category
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
        {
            *(char*) (pointer + offset) = value;

            current = offset + OrderCategory.Length;
        }

        /// <summary>
        ///  TryDecode Order Category
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
        {
            if (length > offset + OrderCategory.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Category
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderCategory.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Category
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset)
        {
            return *(char*) (pointer + offset);
        }
    }
}