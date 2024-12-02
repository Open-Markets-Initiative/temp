using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Appl Resend Flag: Enum
    /// </summary>

    public sealed class ApplResendFlag
    {
        /// <summary>
        ///  False
        /// </summary>
        public const byte False = 0;

        /// <summary>
        ///  True
        /// </summary>
        public const byte True = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte ApplResendFlagMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte ApplResendFlagMinimumValue = 0;

        /// <summary>
        ///  Length of Appl Resend Flag in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Appl Resend Flag
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ApplResendFlag.Length)
            {
                throw new System.Exception("Invalid Length for Appl Resend Flag");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Resend Flag
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ApplResendFlag.Length;
        }

        /// <summary>
        ///  TryDecode Appl Resend Flag
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ApplResendFlag.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Resend Flag
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplResendFlag.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Resend Flag
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}