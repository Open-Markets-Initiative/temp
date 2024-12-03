using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Cust Order Handling Inst: Enum
    /// </summary>

    public sealed class CustOrderHandlingInst
    {
        /// <summary>
        ///  Desk
        /// </summary>
        public const char W = 'W';

        /// <summary>
        ///  Electronic
        /// </summary>
        public const char Y = 'Y';

        /// <summary>
        ///  Vendor-provided Platform billed by Executing Broker
        /// </summary>
        public const char C = 'C';

        /// <summary>
        ///  Sponsored Access via Exchange API or FIX provided by Executing Broker
        /// </summary>
        public const char G = 'G';

        /// <summary>
        ///  Premium Algorithmic Trading Provider billed by Executing Broker
        /// </summary>
        public const char H = 'H';

        /// <summary>
        ///  Other, including Other-provided Screen
        /// </summary>
        public const char D = 'D';

        /// <summary>
        ///  Fix Tag for Cust Order Handling Inst
        /// </summary>
        public const ushort FixTag = 1031;

        /// <summary>
        ///  Length of Cust Order Handling Inst in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Cust Order Handling Inst
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
        {
            if (length > offset + CustOrderHandlingInst.Length)
            {
                throw new System.Exception("Invalid Length for Cust Order Handling Inst");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Cust Order Handling Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

            Encode(pointer, offset, character, out current);
        }

        /// <summary>
        ///  Encode Cust Order Handling Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
        {
            *(char*) (pointer + offset) = value;

            current = offset + CustOrderHandlingInst.Length;
        }

        /// <summary>
        ///  TryDecode Cust Order Handling Inst
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
        {
            if (length > offset + CustOrderHandlingInst.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Cust Order Handling Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset, out int current)
        {
            current = offset + CustOrderHandlingInst.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Cust Order Handling Inst
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset)
        {
            return *(char*) (pointer + offset);
        }
    }
}