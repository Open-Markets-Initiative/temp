using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Related Trade Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class SrqsRelatedTradeId
    {
        /// <summary>
        ///  Fix Tag for Srqs Related Trade Id
        /// </summary>
        public const ushort FixTag = 25152;

        /// <summary>
        ///  Length of Srqs Related Trade Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Srqs Related Trade Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Srqs Related Trade Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + SrqsRelatedTradeId.Length)
            {
                throw new System.Exception("Invalid Length for Srqs Related Trade Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Srqs Related Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SrqsRelatedTradeId.Length;
        }

        /// <summary>
        ///  Encode Srqs Related Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Srqs Related Trade Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SrqsRelatedTradeId.Length)
            {
                throw new System.Exception("Invalid Length for Srqs Related Trade Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Srqs Related Trade Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SrqsRelatedTradeId.Length;
        }

        /// <summary>
        ///  Set Srqs Related Trade Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Srqs Related Trade Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + SrqsRelatedTradeId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Srqs Related Trade Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Srqs Related Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SrqsRelatedTradeId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Srqs Related Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}