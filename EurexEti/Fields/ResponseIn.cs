using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Response In: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class ResponseIn
    {
        /// <summary>
        ///  Fix Tag for Response In
        /// </summary>
        public const ushort FixTag = 7765;

        /// <summary>
        ///  Length of Response In in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Response In
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

        /// <summary>
        ///  Encode Response In
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ResponseIn.Length)
            {
                throw new System.Exception("Invalid Length for Response In");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Response In
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ResponseIn.Length;
        }

        /// <summary>
        ///  Encode Response In
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Response In to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ResponseIn.Length)
            {
                throw new System.Exception("Invalid Length for Response In");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Response In to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ResponseIn.Length;
        }

        /// <summary>
        ///  Set Response In to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Response In
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ResponseIn.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Response In
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Response In
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ResponseIn.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Response In
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}