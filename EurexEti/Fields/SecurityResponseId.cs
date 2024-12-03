using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Security Response Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class SecurityResponseId
    {
        /// <summary>
        ///  Fix Tag for Security Response Id
        /// </summary>
        public const ushort FixTag = 322;

        /// <summary>
        ///  Length of Security Response Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Security Response Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + SecurityResponseId.Length)
            {
                throw new System.Exception("Invalid Length for Security Response Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Security Response Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SecurityResponseId.Length;
        }

        /// <summary>
        ///  Encode Security Response Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Security Response Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + SecurityResponseId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Security Response Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SecurityResponseId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Security Response Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}