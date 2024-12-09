using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Not Affected Securities: Runtime Count Field
    /// </summary>

    public static class NoNotAffectedSecurities
    {
        /// <summary>
        ///  Fix Tag for No Not Affected Securities
        /// </summary>
        public const ushort FixTag = 28707;

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
        ///  Check available length and set No Not Affected Securities to 0
        /// </summary>
        public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NoNotAffectedSecurities.Length)
            {
                throw new System.Exception("Invalid Length for No Not Affected Securities");
            }

            Zero(pointer, offset, out current);
        }

        /// <summary>
        ///  Set No Not Affected Securities to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset, out int current)
        {
            Zero(pointer, offset);

            current = offset + NoNotAffectedSecurities.Length;
        }

        /// <summary>
        ///  Set No Not Affected Securities to 0
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset)
        {
            *(ushort*) (pointer + offset) = 0;
        }

        /// <summary>
        ///  TryDecode No Not Affected Securities
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoNotAffectedSecurities.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode No Not Affected Securities
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value > 0;
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