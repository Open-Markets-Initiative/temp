using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Event Type: Enum
    /// </summary>

    public sealed class QuoteEventType
    {
        /// <summary>
        ///  Modified side
        /// </summary>
        public const byte Modifiedquoteside = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte Removedquoteside = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte Partiallyfilled = 4;

        /// <summary>
        ///  Filled
        /// </summary>
        public const byte Filled = 5;

        /// <summary>
        ///  Quantity removed
        /// </summary>
        public const byte RemovedQuantity = 6;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteEventTypeMaximumValue = 6;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteEventTypeMinimumValue = 0;

        /// <summary>
        ///  Length of Quote Event Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Event Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteEventType.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Event Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteEventType.Length;
        }

        /// <summary>
        ///  TryDecode Quote Event Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteEventType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Event Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEventType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Event Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}