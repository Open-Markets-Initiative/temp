using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Secondary Quote Id: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class SecondaryQuoteId
    {
        /// <summary>
        ///  Fix Tag for Secondary Quote Id
        /// </summary>
        public const ushort FixTag = 1751;

        /// <summary>
        ///  Length of Secondary Quote Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Secondary Quote Id
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

        /// <summary>
        ///  Encode Secondary Quote Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + SecondaryQuoteId.Length)
            {
                throw new System.Exception("Invalid Length for Secondary Quote Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Secondary Quote Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SecondaryQuoteId.Length;
        }

        /// <summary>
        ///  Encode Secondary Quote Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Secondary Quote Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SecondaryQuoteId.Length)
            {
                throw new System.Exception("Invalid Length for Secondary Quote Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Secondary Quote Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SecondaryQuoteId.Length;
        }

        /// <summary>
        ///  Set Secondary Quote Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Secondary Quote Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + SecondaryQuoteId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Secondary Quote Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Secondary Quote Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SecondaryQuoteId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Secondary Quote Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}