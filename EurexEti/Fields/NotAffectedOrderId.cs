using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Not Affected Order Id: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class NotAffectedOrderId
    {
        /// <summary>
        ///  Fix Tag for Not Affected Order Id
        /// </summary>
        public const ushort FixTag = 1371;

        /// <summary>
        ///  Length of Not Affected Order Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Not Affected Order Id
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

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
        ///  Check available length and set Not Affected Order Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NotAffectedOrderId.Length)
            {
                throw new System.Exception("Invalid Length for Not Affected Order Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Not Affected Order Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + NotAffectedOrderId.Length;
        }

        /// <summary>
        ///  Set Not Affected Order Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Not Affected Order Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + NotAffectedOrderId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Not Affected Order Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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