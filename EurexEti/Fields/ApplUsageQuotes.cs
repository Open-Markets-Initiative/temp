using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Appl Usage Quotes: Enum
    /// </summary>

    public static class ApplUsageQuotes
    {
        /// <summary>
        ///  Automated
        /// </summary>
        public const char Automated = 'A';

        /// <summary>
        ///  Manual
        /// </summary>
        public const char Manual = 'M';

        /// <summary>
        ///  Both (Automated and Manual)
        /// </summary>
        public const char AutoSelect = 'B';

        /// <summary>
        ///  None
        /// </summary>
        public const char None = 'N';

        /// <summary>
        ///  Fix Tag for Appl Usage Quotes
        /// </summary>
        public const ushort FixTag = 25013;

        /// <summary>
        ///  Length of Appl Usage Quotes in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Appl Usage Quotes
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, char value, int length, out int current)
        {
            if (length > offset + ApplUsageQuotes.Length)
            {
                throw new System.Exception("Invalid Length for Appl Usage Quotes");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Usage Quotes
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var character = string.IsNullOrWhiteSpace(value) || value.Length != 1 ? default(char) : value[0];

            Encode(pointer, offset, character, out current);
        }

        /// <summary>
        ///  Encode Appl Usage Quotes
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, char value, out int current)
        {
            *(char*) (pointer + offset) = value;

            current = offset + ApplUsageQuotes.Length;
        }

        /// <summary>
        ///  TryDecode Appl Usage Quotes
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out char value, out int current)
        {
            if (length > offset + ApplUsageQuotes.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Usage Quotes
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplUsageQuotes.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Usage Quotes
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static char Decode(byte* pointer, int offset)
        {
            return *(char*) (pointer + offset);
        }
    }
}