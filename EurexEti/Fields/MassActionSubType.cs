using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Mass Action Sub Type: Enum
    /// </summary>

    public sealed class MassActionSubType
    {
        /// <summary>
        ///  Book or cancel
        /// </summary>
        public const byte BookorCancel = 1;

        /// <summary>
        ///  Fix Tag for Mass Action Sub Type
        /// </summary>
        public const ushort FixTag = 28768;

        /// <summary>
        ///  Length of Mass Action Sub Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Mass Action Sub Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MassActionSubType.Length)
            {
                throw new System.Exception("Invalid Length for Mass Action Sub Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mass Action Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MassActionSubType.Length;
        }

        /// <summary>
        ///  TryDecode Mass Action Sub Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MassActionSubType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Mass Action Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MassActionSubType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mass Action Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}