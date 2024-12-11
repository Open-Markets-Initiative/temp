using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Platform: Enum
    /// </summary>

    public static class RiskLimitPlatform
    {
        /// <summary>
        ///  On-Book
        /// </summary>
        public const byte OnBook = 0;

        /// <summary>
        ///  Off-Book(TES)
        /// </summary>
        public const byte OffBook = 1;

        /// <summary>
        ///  Fix Tag for Risk Limit Platform
        /// </summary>
        public const ushort FixTag = 1533;

        /// <summary>
        ///  Length of Risk Limit Platform in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Risk Limit Platform
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + RiskLimitPlatform.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Platform");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Risk Limit Platform
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + RiskLimitPlatform.Length;
        }

        /// <summary>
        ///  Check available length and set Risk Limit Platform to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RiskLimitPlatform.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Platform");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Risk Limit Platform to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RiskLimitPlatform.Length;
        }

        /// <summary>
        ///  Set Risk Limit Platform to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Risk Limit Platform
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RiskLimitPlatform.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Risk Limit Platform
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Risk Limit Platform
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RiskLimitPlatform.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Risk Limit Platform
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}