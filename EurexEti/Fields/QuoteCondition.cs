using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Condition: Enum
    /// </summary>

    public static class QuoteCondition
    {
        /// <summary>
        ///  Active
        /// </summary>
        public const char Active = 'A';

        /// <summary>
        ///  Closed
        /// </summary>
        public const char Closed = 'B';

        /// <summary>
        ///  Suspended
        /// </summary>
        public const char Suspended = 'z';

        /// <summary>
        ///  Expired
        /// </summary>
        public const char Expired = '8';

        /// <summary>
        ///  Fix Tag for Quote Condition
        /// </summary>
        public const ushort FixTag = 276;

        /// <summary>
        ///  Length of Quote Condition in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Condition
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
        {
            if (length > offset + QuoteCondition.Length)
            {
                throw new System.Exception("Invalid Length for Quote Condition");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Condition
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

            Encode(pointer, offset, character, out current);
        }

        /// <summary>
        ///  Encode Quote Condition
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
        {
            *(char*) (pointer + offset) = value;

            current = offset + QuoteCondition.Length;
        }

        /// <summary>
        ///  TryDecode Quote Condition
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
        {
            if (length > offset + QuoteCondition.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Condition
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteCondition.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Condition
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset)
        {
            return *(char*) (pointer + offset);
        }
    }
}