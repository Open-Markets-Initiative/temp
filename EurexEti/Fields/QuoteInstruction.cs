using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Instruction: Enum
    /// </summary>

    public static class QuoteInstruction
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
        ///  Fix Tag for Quote Instruction
        /// </summary>
        public const ushort FixTag = 25138;

        /// <summary>
        ///  Length of Quote Instruction in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Quote Instruction
        /// </summary>
        public const byte NoValue = 0xFF;

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
        ///  Check available length and set Quote Instruction to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuoteInstruction.Length)
            {
                throw new System.Exception("Invalid Length for Quote Instruction");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quote Instruction to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuoteInstruction.Length;
        }

        /// <summary>
        ///  Set Quote Instruction to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Quote Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteInstruction.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quote Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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