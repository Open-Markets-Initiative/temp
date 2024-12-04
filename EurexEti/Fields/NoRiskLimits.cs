using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Risk Limits: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoRiskLimits
    {
        /// <summary>
        ///  Fix Tag for No Risk Limits
        /// </summary>
        public const ushort FixTag = 1669;

        /// <summary>
        ///  Length of No Risk Limits in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Risk Limits
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoRiskLimits.Length)
            {
                throw new System.Exception("Invalid Length for No Risk Limits");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Risk Limits
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoRiskLimits.Length;
        }

        /// <summary>
        ///  Encode No Risk Limits
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Risk Limits
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoRiskLimits.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Risk Limits
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoRiskLimits.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Risk Limits
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}