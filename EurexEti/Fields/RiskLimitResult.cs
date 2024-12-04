using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Result: Enum
    /// </summary>

    public sealed class RiskLimitResult
    {
        /// <summary>
        ///  Margin Based Risk Limits not enabled for business unit
        /// </summary>
        public const ushort DisabledForBu = 10580;

        /// <summary>
        ///  Received Remaining Risk Allowance event ID is lower than lowest entry in Temporary Transaction List
        /// </summary>
        public const ushort LowRraEventId = 10581;

        /// <summary>
        ///  Received Remaining Risk Allowance event ID exceeds last entry in Temporary Transaction List
        /// </summary>
        public const ushort HighRraEventId = 10582;

        /// <summary>
        ///  Fix Tag for Risk Limit Result
        /// </summary>
        public const ushort FixTag = 1764;

        /// <summary>
        ///  Length of Risk Limit Result in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Risk Limit Result
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + RiskLimitResult.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Result");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Risk Limit Result
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            *(ushort*) (pointer + offset) = value;

            current = offset + RiskLimitResult.Length;
        }

        /// <summary>
        ///  TryDecode Risk Limit Result
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + RiskLimitResult.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Risk Limit Result
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RiskLimitResult.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Risk Limit Result
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}