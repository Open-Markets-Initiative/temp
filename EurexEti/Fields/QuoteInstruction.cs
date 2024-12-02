using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Instruction: Enum
    /// </summary>

    public sealed class QuoteInstruction
    {
        /// <summary>
        ///  Do not re-quote
        /// </summary>
        public const byte DoNotQuote = 0;

        /// <summary>
        ///  (Re-)Quote
        /// </summary>
        public const byte Quote = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteInstructionMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteInstructionMinimumValue = 0;

        /// <summary>
        ///  Length of Quote Instruction in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Instruction
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteInstruction.Length)
            {
                throw new System.Exception("Invalid Length for Quote Instruction");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteInstruction.Length;
        }

        /// <summary>
        ///  TryDecode Quote Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteInstruction.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteInstruction.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}