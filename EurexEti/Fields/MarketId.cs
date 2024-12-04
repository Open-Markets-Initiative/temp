using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Market Id: Enum
    /// </summary>

    public sealed class MarketId
    {
        /// <summary>
        ///  XEUR
        /// </summary>
        public const ushort Xeur = 1;

        /// <summary>
        ///  XEEE
        /// </summary>
        public const ushort Xeee = 2;

        /// <summary>
        ///  NODX
        /// </summary>
        public const ushort Nodx = 12;

        /// <summary>
        ///  Fix Tag for Market Id
        /// </summary>
        public const ushort FixTag = 1301;

        /// <summary>
        ///  Length of Market Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Market Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + MarketId.Length)
            {
                throw new System.Exception("Invalid Length for Market Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            *(ushort*) (pointer + offset) = value;

            current = offset + MarketId.Length;
        }

        /// <summary>
        ///  TryDecode Market Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + MarketId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MarketId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Market Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}