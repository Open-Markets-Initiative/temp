using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Reversal Approval Time: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class ReversalApprovalTime
    {
        /// <summary>
        ///  Fix Tag for Reversal Approval Time
        /// </summary>
        public const ushort FixTag = 25198;

        /// <summary>
        ///  Length of Reversal Approval Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Reversal Approval Time
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

        /// <summary>
        ///  Encode Reversal Approval Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ReversalApprovalTime.Length)
            {
                throw new System.Exception("Invalid Length for Reversal Approval Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Reversal Approval Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ReversalApprovalTime.Length;
        }

        /// <summary>
        ///  Encode Reversal Approval Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Reversal Approval Time to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ReversalApprovalTime.Length)
            {
                throw new System.Exception("Invalid Length for Reversal Approval Time");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Reversal Approval Time to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ReversalApprovalTime.Length;
        }

        /// <summary>
        ///  Set Reversal Approval Time to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Reversal Approval Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ReversalApprovalTime.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Reversal Approval Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Reversal Approval Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ReversalApprovalTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Reversal Approval Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}