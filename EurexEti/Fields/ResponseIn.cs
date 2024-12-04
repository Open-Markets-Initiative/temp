using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Response In: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ResponseIn
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
        ///  TryDecode Response In
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ResponseIn.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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