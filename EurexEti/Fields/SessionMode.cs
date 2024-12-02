using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Session Mode: Enum
    /// </summary>

    public sealed class SessionMode
    {
        /// <summary>
        ///  ETI HF
        /// </summary>
        public const byte Etihf = 1;

        /// <summary>
        ///  ETI LF
        /// </summary>
        public const byte Etilf = 2;

        /// <summary>
        ///  GUI
        /// </summary>
        public const byte Gui = 3;

        /// <summary>
        ///  FIX LF
        /// </summary>
        public const byte Fixlf = 4;

        /// <summary>
        ///  
        /// </summary>
        public const byte SessionModeMaximumValue = 4;

        /// <summary>
        ///  
        /// </summary>
        public const byte SessionModeMinimumValue = 1;

        /// <summary>
        ///  Length of Session Mode in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Session Mode
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SessionMode.Length)
            {
                throw new System.Exception("Invalid Length for Session Mode");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Session Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SessionMode.Length;
        }

        /// <summary>
        ///  TryDecode Session Mode
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SessionMode.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Session Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SessionMode.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Session Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}