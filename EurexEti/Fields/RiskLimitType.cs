using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Type: Enum
    /// </summary>

    public sealed class RiskLimitType
    {
        /// <summary>
        ///  Long limit
        /// </summary>
        public const byte Longlimit = 4;

        /// <summary>
        ///  Short limit
        /// </summary>
        public const byte Shortlimit = 5;

        /// <summary>
        ///  Fix Tag for Risk Limit Type
        /// </summary>
        public const ushort FixTag = 1530;

        /// <summary>
        ///  Length of Risk Limit Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Risk Limit Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + RiskLimitType.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Risk Limit Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + RiskLimitType.Length;
        }

        /// <summary>
        ///  TryDecode Risk Limit Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RiskLimitType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Risk Limit Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RiskLimitType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Risk Limit Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}