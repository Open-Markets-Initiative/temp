using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Not Affected Order Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class NotAffectedOrderId
    {
        /// <summary>
        ///  Length of Not Affected Order Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Not Affected Order Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + NotAffectedOrderId.Length)
            {
                throw new System.Exception("Invalid Length for Not Affected Order Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Not Affected Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NotAffectedOrderId.Length;
        }

        /// <summary>
        ///  Encode Not Affected Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Not Affected Order Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + NotAffectedOrderId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Not Affected Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NotAffectedOrderId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Not Affected Order Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}