using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Routing Indicator: Enum
    /// </summary>

    public sealed class OrderRoutingIndicator
    {
        /// <summary>
        ///  Yes
        /// </summary>
        public const char Yes = 'Y';

        /// <summary>
        ///  No
        /// </summary>
        public const char No = 'N';

        /// <summary>
        ///  Fix Tag for Order Routing Indicator
        /// </summary>
        public const ushort FixTag = 25014;

        /// <summary>
        ///  Length of Order Routing Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Order Routing Indicator
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
        {
            if (length > offset + OrderRoutingIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Order Routing Indicator");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Routing Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

            Encode(pointer, offset, character, out current);
        }

        /// <summary>
        ///  Encode Order Routing Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
        {
            *(char*) (pointer + offset) = value;

            current = offset + OrderRoutingIndicator.Length;
        }

        /// <summary>
        ///  TryDecode Order Routing Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
        {
            if (length > offset + OrderRoutingIndicator.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Routing Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderRoutingIndicator.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Routing Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset)
        {
            return *(char*) (pointer + offset);
        }
    }
}