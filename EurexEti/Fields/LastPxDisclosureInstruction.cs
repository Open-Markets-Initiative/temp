using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Last Px Disclosure Instruction: Enum
    /// </summary>

    public sealed class LastPxDisclosureInstruction
    {
        /// <summary>
        ///  No
        /// </summary>
        public const byte No = 0;

        /// <summary>
        ///  Yes
        /// </summary>
        public const byte Yes = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte LastPxDisclosureInstructionMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte LastPxDisclosureInstructionMinimumValue = 0;

        /// <summary>
        ///  Length of Last Px Disclosure Instruction in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Last Px Disclosure Instruction
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + LastPxDisclosureInstruction.Length)
            {
                throw new System.Exception("Invalid Length for Last Px Disclosure Instruction");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Last Px Disclosure Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + LastPxDisclosureInstruction.Length;
        }

        /// <summary>
        ///  TryDecode Last Px Disclosure Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + LastPxDisclosureInstruction.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Last Px Disclosure Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LastPxDisclosureInstruction.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Last Px Disclosure Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}