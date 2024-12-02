using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Match Inst Cross Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class MatchInstCrossId
    {
        /// <summary>
        ///  Length of Match Inst Cross Id in bytes
        /// </summary>
        public const int Length = 4;

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
        ///  TryDecode Match Inst Cross Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + MatchInstCrossId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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