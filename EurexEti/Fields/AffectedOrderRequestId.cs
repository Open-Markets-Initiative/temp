using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Affected Order Request Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class AffectedOrderRequestId
    {
        /// <summary>
        ///  Fix Tag for Affected Order Request Id
        /// </summary>
        public const ushort FixTag = 28783;

        /// <summary>
        ///  Length of Affected Order Request Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Affected Order Request Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Affected Order Request Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + AffectedOrderRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Affected Order Request Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Affected Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + AffectedOrderRequestId.Length;
        }

        /// <summary>
        ///  Encode Affected Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Affected Order Request Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + AffectedOrderRequestId.Length)
            {
                throw new System.Exception("Invalid Length for Affected Order Request Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Affected Order Request Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + AffectedOrderRequestId.Length;
        }

        /// <summary>
        ///  Set Affected Order Request Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Affected Order Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + AffectedOrderRequestId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Affected Order Request Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Affected Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + AffectedOrderRequestId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Affected Order Request Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}