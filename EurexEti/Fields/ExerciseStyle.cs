using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Exercise Style: Enum
    /// </summary>

    public sealed class ExerciseStyle
    {
        /// <summary>
        ///  European
        /// </summary>
        public const byte European = 0;

        /// <summary>
        ///  American
        /// </summary>
        public const byte American = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte ExerciseStyleMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte ExerciseStyleMinimumValue = 0;

        /// <summary>
        ///  Length of Exercise Style in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Exercise Style
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ExerciseStyle.Length)
            {
                throw new System.Exception("Invalid Length for Exercise Style");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Exercise Style
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ExerciseStyle.Length;
        }

        /// <summary>
        ///  TryDecode Exercise Style
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ExerciseStyle.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Exercise Style
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ExerciseStyle.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Exercise Style
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}