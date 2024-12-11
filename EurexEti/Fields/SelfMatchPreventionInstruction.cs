using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Self Match Prevention Instruction: Enum
    /// </summary>

    public static class SelfMatchPreventionInstruction
    {
        /// <summary>
        ///  Reject cross on business unit level
        /// </summary>
        public const byte CrossrejectedBu = 100;

        /// <summary>
        ///  Reject cross on market level
        /// </summary>
        public const byte CrossrejectedMarket = 101;

        /// <summary>
        ///  Fix Tag for Self Match Prevention Instruction
        /// </summary>
        public const ushort FixTag = 2964;

        /// <summary>
        ///  Length of Self Match Prevention Instruction in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Self Match Prevention Instruction
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Self Match Prevention Instruction
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SelfMatchPreventionInstruction.Length)
            {
                throw new System.Exception("Invalid Length for Self Match Prevention Instruction");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Self Match Prevention Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SelfMatchPreventionInstruction.Length;
        }

        /// <summary>
        ///  Check available length and set Self Match Prevention Instruction to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SelfMatchPreventionInstruction.Length)
            {
                throw new System.Exception("Invalid Length for Self Match Prevention Instruction");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Self Match Prevention Instruction to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SelfMatchPreventionInstruction.Length;
        }

        /// <summary>
        ///  Set Self Match Prevention Instruction to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Self Match Prevention Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SelfMatchPreventionInstruction.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Self Match Prevention Instruction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Self Match Prevention Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SelfMatchPreventionInstruction.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Self Match Prevention Instruction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}