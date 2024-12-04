using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Platform: Enum
    /// </summary>

    public sealed class RiskLimitPlatform
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
        ///  TryDecode Risk Limit Platform
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RiskLimitPlatform.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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