using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Report Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class RiskLimitReportId
    {
        /// <summary>
        ///  Fix Tag for Risk Limit Report Id
        /// </summary>
        public const ushort FixTag = 1667;

        /// <summary>
        ///  Length of Risk Limit Report Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Risk Limit Report Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + RiskLimitReportId.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Report Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Risk Limit Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RiskLimitReportId.Length;
        }

        /// <summary>
        ///  Encode Risk Limit Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Risk Limit Report Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + RiskLimitReportId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Risk Limit Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RiskLimitReportId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Risk Limit Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}