using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Fill Ref Id: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class FillRefId
    {
        /// <summary>
        ///  Fix Tag for Fill Ref Id
        /// </summary>
        public const ushort FixTag = 2421;

        /// <summary>
        ///  Length of Fill Ref Id in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Fill Ref Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + FillRefId.Length)
            {
                throw new System.Exception("Invalid Length for Fill Ref Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Fill Ref Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + FillRefId.Length;
        }

        /// <summary>
        ///  Encode Fill Ref Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Fill Ref Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + FillRefId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Fill Ref Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + FillRefId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Fill Ref Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}