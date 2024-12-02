using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Not Affected Securities: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoNotAffectedSecurities
    {
        /// <summary>
        ///  Length of No Not Affected Securities in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode No Not Affected Securities
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + NoNotAffectedSecurities.Length)
            {
                throw new System.Exception("Invalid Length for No Not Affected Securities");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Not Affected Securities
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoNotAffectedSecurities.Length;
        }

        /// <summary>
        ///  Encode No Not Affected Securities
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Not Affected Securities
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoNotAffectedSecurities.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Not Affected Securities
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoNotAffectedSecurities.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Not Affected Securities
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}