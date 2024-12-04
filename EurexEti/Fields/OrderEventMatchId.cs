using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Event Match Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class OrderEventMatchId
    {
        /// <summary>
        ///  Fix Tag for Order Event Match Id
        /// </summary>
        public const ushort FixTag = 30060;

        /// <summary>
        ///  Length of Order Event Match Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Order Event Match Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + OrderEventMatchId.Length)
            {
                throw new System.Exception("Invalid Length for Order Event Match Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Event Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + OrderEventMatchId.Length;
        }

        /// <summary>
        ///  Encode Order Event Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Order Event Match Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + OrderEventMatchId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Event Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderEventMatchId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Event Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}