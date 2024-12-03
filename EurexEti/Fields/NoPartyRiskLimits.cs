using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Party Risk Limits: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoPartyRiskLimits
    {
        /// <summary>
        ///  Fix Tag for No Party Risk Limits
        /// </summary>
        public const ushort FixTag = 1677;

        /// <summary>
        ///  Length of No Party Risk Limits in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode No Party Risk Limits
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + NoPartyRiskLimits.Length)
            {
                throw new System.Exception("Invalid Length for No Party Risk Limits");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Party Risk Limits
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoPartyRiskLimits.Length;
        }

        /// <summary>
        ///  Encode No Party Risk Limits
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Party Risk Limits
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoPartyRiskLimits.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Party Risk Limits
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoPartyRiskLimits.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Party Risk Limits
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}