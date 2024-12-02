using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Session Sub Mode: Enum
    /// </summary>

    public sealed class SessionSubMode
    {
        /// <summary>
        ///  Regular Trading Session
        /// </summary>
        public const byte Regulartradingsession = 0;

        /// <summary>
        ///  Regular Back Office Session
        /// </summary>
        public const byte RegularBackOfficesession = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte SessionSubModeMaximumValue = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte SessionSubModeMinimumValue = 0;

        /// <summary>
        ///  Length of Session Sub Mode in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Session Sub Mode
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SessionSubMode.Length)
            {
                throw new System.Exception("Invalid Length for Session Sub Mode");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Session Sub Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SessionSubMode.Length;
        }

        /// <summary>
        ///  TryDecode Session Sub Mode
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SessionSubMode.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Session Sub Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SessionSubMode.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Session Sub Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}