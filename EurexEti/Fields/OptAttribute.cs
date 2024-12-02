using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Opt Attribute: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class OptAttribute
    {
        /// <summary>
        ///  Length of Opt Attribute in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Opt Attribute
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OptAttribute.Length)
            {
                throw new System.Exception("Invalid Length for Opt Attribute");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + OptAttribute.Length;
        }

        /// <summary>
        ///  Encode Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Opt Attribute
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OptAttribute.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OptAttribute.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Opt Attribute
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}