using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Transact Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class TransactTime
    {
        /// <summary>
        ///  Fix Tag for Transact Time
        /// </summary>
        public const ushort FixTag = 60;

        /// <summary>
        ///  Length of Transact Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Transact Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + TransactTime.Length)
            {
                throw new System.Exception("Invalid Length for Transact Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TransactTime.Length;
        }

        /// <summary>
        ///  Encode Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Transact Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + TransactTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TransactTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Transact Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}