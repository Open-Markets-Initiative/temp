using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trd Reg Ts Time Out: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class TrdRegTsTimeOut
    {
        /// <summary>
        ///  Length of Trd Reg Ts Time Out in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Trd Reg Ts Time Out
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + TrdRegTsTimeOut.Length)
            {
                throw new System.Exception("Invalid Length for Trd Reg Ts Time Out");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trd Reg Ts Time Out
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TrdRegTsTimeOut.Length;
        }

        /// <summary>
        ///  Encode Trd Reg Ts Time Out
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Trd Reg Ts Time Out
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + TrdRegTsTimeOut.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trd Reg Ts Time Out
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TrdRegTsTimeOut.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trd Reg Ts Time Out
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}