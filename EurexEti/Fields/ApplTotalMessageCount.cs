using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Appl Total Message Count: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class ApplTotalMessageCount
    {
        /// <summary>
        ///  Length of Appl Total Message Count in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Appl Total Message Count
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + ApplTotalMessageCount.Length)
            {
                throw new System.Exception("Invalid Length for Appl Total Message Count");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Total Message Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ApplTotalMessageCount.Length;
        }

        /// <summary>
        ///  Encode Appl Total Message Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Appl Total Message Count
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + ApplTotalMessageCount.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Total Message Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplTotalMessageCount.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Total Message Count
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}