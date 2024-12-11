using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Type: Enum
    /// </summary>

    public static class RiskLimitType
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
        ///  Check available length and set Risk Limit Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RiskLimitType.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Risk Limit Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RiskLimitType.Length;
        }

        /// <summary>
        ///  Set Risk Limit Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Risk Limit Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RiskLimitType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Risk Limit Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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