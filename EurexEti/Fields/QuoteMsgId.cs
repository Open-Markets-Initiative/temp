using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Msg Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class QuoteMsgId
    {
        /// <summary>
        ///  Fix Tag for Quote Msg Id
        /// </summary>
        public const ushort FixTag = 1166;

        /// <summary>
        ///  Length of Quote Msg Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Quote Msg Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + QuoteMsgId.Length)
            {
                throw new System.Exception("Invalid Length for Quote Msg Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Msg Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + QuoteMsgId.Length;
        }

        /// <summary>
        ///  Encode Quote Msg Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Quote Msg Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + QuoteMsgId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Msg Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteMsgId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Msg Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}