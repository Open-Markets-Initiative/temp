using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Party Details: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoPartyDetails
    {
        /// <summary>
        ///  Fix Tag for No Party Details
        /// </summary>
        public const ushort FixTag = 1671;

        /// <summary>
        ///  Length of No Party Details in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode No Party Details
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + NoPartyDetails.Length)
            {
                throw new System.Exception("Invalid Length for No Party Details");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Party Details
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoPartyDetails.Length;
        }

        /// <summary>
        ///  Encode No Party Details
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Party Details
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoPartyDetails.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Party Details
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoPartyDetails.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Party Details
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}