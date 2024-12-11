using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Match Inst Cross Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class MatchInstCrossId
    {
        /// <summary>
        ///  Fix Tag for Match Inst Cross Id
        /// </summary>
        public const ushort FixTag = 28744;

        /// <summary>
        ///  Length of Match Inst Cross Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Match Inst Cross Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Match Inst Cross Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + MatchInstCrossId.Length)
            {
                throw new System.Exception("Invalid Length for Match Inst Cross Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Match Inst Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MatchInstCrossId.Length;
        }

        /// <summary>
        ///  Encode Match Inst Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Match Inst Cross Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MatchInstCrossId.Length)
            {
                throw new System.Exception("Invalid Length for Match Inst Cross Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Match Inst Cross Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MatchInstCrossId.Length;
        }

        /// <summary>
        ///  Set Match Inst Cross Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Match Inst Cross Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + MatchInstCrossId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Match Inst Cross Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Match Inst Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MatchInstCrossId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Match Inst Cross Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}