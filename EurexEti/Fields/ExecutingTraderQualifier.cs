using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Executing Trader Qualifier: Enum
    /// </summary>

    public sealed class ExecutingTraderQualifier
    {
        /// <summary>
        ///  Algo
        /// </summary>
        public const byte Algo = 22;

        /// <summary>
        ///  Human/Natural person
        /// </summary>
        public const byte Human = 24;

        /// <summary>
        ///  
        /// </summary>
        public const byte ExecutingTraderQualifierMaximumValue = 24;

        /// <summary>
        ///  
        /// </summary>
        public const byte ExecutingTraderQualifierMinimumValue = 22;

        /// <summary>
        ///  Length of Executing Trader Qualifier in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Executing Trader Qualifier
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ExecutingTraderQualifier.Length)
            {
                throw new System.Exception("Invalid Length for Executing Trader Qualifier");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Executing Trader Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ExecutingTraderQualifier.Length;
        }

        /// <summary>
        ///  TryDecode Executing Trader Qualifier
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ExecutingTraderQualifier.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Executing Trader Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ExecutingTraderQualifier.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Executing Trader Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}