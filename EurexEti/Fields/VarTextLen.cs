using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Var Text Len: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class VarTextLen
    {
        /// <summary>
        ///  Length of Var Text Len in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Var Text Len
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + VarTextLen.Length)
            {
                throw new System.Exception("Invalid Length for Var Text Len");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Var Text Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + VarTextLen.Length;
        }

        /// <summary>
        ///  Encode Var Text Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Var Text Len
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + VarTextLen.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Var Text Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + VarTextLen.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Var Text Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}