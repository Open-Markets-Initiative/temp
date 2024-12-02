using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Reversal Approval Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ReversalApprovalTime
    {
        /// <summary>
        ///  Length of Reversal Approval Time in bytes
        /// </summary>
        public const int Length = 8;

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
        ///  TryDecode Reversal Approval Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ReversalApprovalTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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