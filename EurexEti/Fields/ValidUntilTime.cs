using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Valid Until Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ValidUntilTime
    {
        /// <summary>
        ///  Fix Tag for Valid Until Time
        /// </summary>
        public const ushort FixTag = 62;

        /// <summary>
        ///  Length of Valid Until Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Valid Until Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ValidUntilTime.Length)
            {
                throw new System.Exception("Invalid Length for Valid Until Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Valid Until Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ValidUntilTime.Length;
        }

        /// <summary>
        ///  Encode Valid Until Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Valid Until Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ValidUntilTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Valid Until Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ValidUntilTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Valid Until Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}