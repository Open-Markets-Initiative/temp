using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Sub Id Type: Enum
    /// </summary>

    public sealed class PartySubIdType
    {
        /// <summary>
        ///  Buyer
        /// </summary>
        public const ushort Buyer = 14001;

        /// <summary>
        ///  Seller
        /// </summary>
        public const ushort Seller = 14002;

        /// <summary>
        ///  Fix Tag for Party Sub Id Type
        /// </summary>
        public const ushort FixTag = 803;

        /// <summary>
        ///  Length of Party Sub Id Type in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Party Sub Id Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + PartySubIdType.Length)
            {
                throw new System.Exception("Invalid Length for Party Sub Id Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Sub Id Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            *(ushort*) (pointer + offset) = value;

            current = offset + PartySubIdType.Length;
        }

        /// <summary>
        ///  TryDecode Party Sub Id Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + PartySubIdType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Sub Id Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartySubIdType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Sub Id Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}