using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Target Party I Ds: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoTargetPartyIDs
    {
        /// <summary>
        ///  Length of No Target Party I Ds in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Target Party I Ds
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoTargetPartyIDs.Length)
            {
                throw new System.Exception("Invalid Length for No Target Party I Ds");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Target Party I Ds
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoTargetPartyIDs.Length;
        }

        /// <summary>
        ///  Encode No Target Party I Ds
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Target Party I Ds
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoTargetPartyIDs.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Target Party I Ds
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoTargetPartyIDs.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Target Party I Ds
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}