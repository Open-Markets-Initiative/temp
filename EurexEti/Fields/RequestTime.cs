using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Request Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class RequestTime
    {
        /// <summary>
        ///  Fix Tag for Request Time
        /// </summary>
        public const ushort FixTag = 5979;

        /// <summary>
        ///  Length of Request Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Request Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + RequestTime.Length)
            {
                throw new System.Exception("Invalid Length for Request Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Request Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RequestTime.Length;
        }

        /// <summary>
        ///  Encode Request Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Request Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + RequestTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Request Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RequestTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Request Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}