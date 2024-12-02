using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Hedging Instruction: Enum
    /// </summary>

    public sealed class HedgingInstruction
    {
        /// <summary>
        ///  Execute hedge transaction in the closing auction of the underlying
        /// </summary>
        public const byte OnClose = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte HedgingInstructionMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte HedgingInstructionMinimumValue = 1;

        /// <summary>
        ///  Length of Hedging Instruction in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Hedging Instruction
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + HedgingInstruction.Length)
            {
                throw new System.Exception("Invalid Length for Hedging Instruction");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Hedging Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + HedgingInstruction.Length;
        }

        /// <summary>
        ///  TryDecode Hedging Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + HedgingInstruction.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Hedging Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + HedgingInstruction.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Hedging Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}