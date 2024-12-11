using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mass Action Sub Type: Enum
    /// </summary>

    public static class MassActionSubType
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
        ///  Check available length and set Mass Action Sub Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MassActionSubType.Length)
            {
                throw new System.Exception("Invalid Length for Mass Action Sub Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Mass Action Sub Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MassActionSubType.Length;
        }

        /// <summary>
        ///  Set Mass Action Sub Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Mass Action Sub Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MassActionSubType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Mass Action Sub Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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