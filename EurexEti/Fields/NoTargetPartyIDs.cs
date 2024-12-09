using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Target Party I Ds: Runtime Count Field
    /// </summary>

    public static class NoTargetPartyIDs
    {
        /// <summary>
        ///  Fix Tag for No Target Party I Ds
        /// </summary>
        public const ushort FixTag = 1461;

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
        ///  Check available length and set No Target Party I Ds to 0
        /// </summary>
        public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NoTargetPartyIDs.Length)
            {
                throw new System.Exception("Invalid Length for No Target Party I Ds");
            }

            Zero(pointer, offset, out current);
        }

        /// <summary>
        ///  Set No Target Party I Ds to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset, out int current)
        {
            Zero(pointer, offset);

            current = offset + NoTargetPartyIDs.Length;
        }

        /// <summary>
        ///  Set No Target Party I Ds to 0
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = 0;
        }

        /// <summary>
        ///  TryDecode No Target Party I Ds
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoTargetPartyIDs.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode No Target Party I Ds
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value > 0;
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