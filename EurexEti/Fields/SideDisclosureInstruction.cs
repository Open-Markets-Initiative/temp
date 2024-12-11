using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Disclosure Instruction: Enum
    /// </summary>

    public static class SideDisclosureInstruction
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
        ///  Fix Tag for Side Disclosure Instruction
        /// </summary>
        public const ushort FixTag = 25130;

        /// <summary>
        ///  Length of Side Disclosure Instruction in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Side Disclosure Instruction
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Side Disclosure Instruction
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SideDisclosureInstruction.Length)
            {
                throw new System.Exception("Invalid Length for Side Disclosure Instruction");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Side Disclosure Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SideDisclosureInstruction.Length;
        }

        /// <summary>
        ///  Check available length and set Side Disclosure Instruction to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SideDisclosureInstruction.Length)
            {
                throw new System.Exception("Invalid Length for Side Disclosure Instruction");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Side Disclosure Instruction to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SideDisclosureInstruction.Length;
        }

        /// <summary>
        ///  Set Side Disclosure Instruction to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Side Disclosure Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SideDisclosureInstruction.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Side Disclosure Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Side Disclosure Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SideDisclosureInstruction.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Side Disclosure Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}