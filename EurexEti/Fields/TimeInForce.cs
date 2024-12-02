using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Time In Force: Enum
    /// </summary>

    public sealed class TimeInForce
    {
        /// <summary>
        ///  Day (GFD)
        /// </summary>
        public const byte Day = 0;

        /// <summary>
        ///  Good Till Cancelled (GTC) - Standard Orders only
        /// </summary>
        public const byte Gtc = 1;

        /// <summary>
        ///  Immediate or Cancel (IOC)
        /// </summary>
        public const byte Ioc = 3;

        /// <summary>
        ///  Fill Or Kill (FOK)
        /// </summary>
        public const byte Fok = 4;

        /// <summary>
        ///  Good Till Date (GTD) - Standard Orders only
        /// </summary>
        public const byte Gtd = 6;

        /// <summary>
        ///  
        /// </summary>
        public const byte TimeInForceMaximumValue = 6;

        /// <summary>
        ///  
        /// </summary>
        public const byte TimeInForceMinimumValue = 0;

        /// <summary>
        ///  Length of Time In Force in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Time In Force
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TimeInForce.Length)
            {
                throw new System.Exception("Invalid Length for Time In Force");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Time In Force
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TimeInForce.Length;
        }

        /// <summary>
        ///  TryDecode Time In Force
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TimeInForce.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Time In Force
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TimeInForce.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Time In Force
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}