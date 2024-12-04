using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mm Parameter Report Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class MmParameterReportId
    {
        /// <summary>
        ///  Fix Tag for Mm Parameter Report Id
        /// </summary>
        public const ushort FixTag = 28717;

        /// <summary>
        ///  Length of Mm Parameter Report Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Mm Parameter Report Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + MmParameterReportId.Length)
            {
                throw new System.Exception("Invalid Length for Mm Parameter Report Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mm Parameter Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MmParameterReportId.Length;
        }

        /// <summary>
        ///  Encode Mm Parameter Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Mm Parameter Report Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + MmParameterReportId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Mm Parameter Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MmParameterReportId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mm Parameter Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}