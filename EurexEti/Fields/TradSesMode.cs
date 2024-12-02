using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trad Ses Mode: Enum
    /// </summary>

    public sealed class TradSesMode
    {
        /// <summary>
        ///  Development
        /// </summary>
        public const byte Testing = 1;

        /// <summary>
        ///  Simulation
        /// </summary>
        public const byte Simulated = 2;

        /// <summary>
        ///  Production
        /// </summary>
        public const byte Production = 3;

        /// <summary>
        ///  Acceptance
        /// </summary>
        public const byte Acceptance = 4;

        /// <summary>
        ///  Disaster Recovery
        /// </summary>
        public const byte DisasterRecovery = 5;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradSesModeMaximumValue = 5;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradSesModeMinimumValue = 1;

        /// <summary>
        ///  Length of Trad Ses Mode in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trad Ses Mode
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradSesMode.Length)
            {
                throw new System.Exception("Invalid Length for Trad Ses Mode");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trad Ses Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradSesMode.Length;
        }

        /// <summary>
        ///  TryDecode Trad Ses Mode
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradSesMode.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trad Ses Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradSesMode.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trad Ses Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}