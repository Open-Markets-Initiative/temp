using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trd Rpt Status: Enum
    /// </summary>

    public static class TrdRptStatus
    {
        /// <summary>
        ///  Accepted
        /// </summary>
        public const byte Accepted = 0;

        /// <summary>
        ///  Rejected
        /// </summary>
        public const byte Rejected = 1;

        /// <summary>
        ///  Cancelled
        /// </summary>
        public const byte Cancelled = 2;

        /// <summary>
        ///  Pending new
        /// </summary>
        public const byte PendingNew = 4;

        /// <summary>
        ///  Pending Cancel
        /// </summary>
        public const byte PendingCancel = 5;

        /// <summary>
        ///  Terminated
        /// </summary>
        public const byte Terminated = 7;

        /// <summary>
        ///  Deemed verified
        /// </summary>
        public const byte DeemedVerified = 9;

        /// <summary>
        ///  Fix Tag for Trd Rpt Status
        /// </summary>
        public const ushort FixTag = 939;

        /// <summary>
        ///  Length of Trd Rpt Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trd Rpt Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TrdRptStatus.Length)
            {
                throw new System.Exception("Invalid Length for Trd Rpt Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trd Rpt Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TrdRptStatus.Length;
        }

        /// <summary>
        ///  Check available length and set Trd Rpt Status to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TrdRptStatus.Length)
            {
                throw new System.Exception("Invalid Length for Trd Rpt Status");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Trd Rpt Status to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TrdRptStatus.Length;
        }

        /// <summary>
        ///  Set Trd Rpt Status to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Trd Rpt Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TrdRptStatus.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Trd Rpt Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Trd Rpt Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TrdRptStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trd Rpt Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}