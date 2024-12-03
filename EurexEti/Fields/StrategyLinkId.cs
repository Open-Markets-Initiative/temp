using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Strategy Link Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class StrategyLinkId
    {
        /// <summary>
        ///  Fix Tag for Strategy Link Id
        /// </summary>
        public const ushort FixTag = 1851;

        /// <summary>
        ///  Length of Strategy Link Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Strategy Link Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + StrategyLinkId.Length)
            {
                throw new System.Exception("Invalid Length for Strategy Link Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Strategy Link Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + StrategyLinkId.Length;
        }

        /// <summary>
        ///  Encode Strategy Link Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Strategy Link Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + StrategyLinkId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Strategy Link Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + StrategyLinkId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Strategy Link Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}