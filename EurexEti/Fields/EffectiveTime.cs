using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Effective Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class EffectiveTime
    {
        /// <summary>
        ///  Length of Effective Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Effective Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + EffectiveTime.Length)
            {
                throw new System.Exception("Invalid Length for Effective Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Effective Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + EffectiveTime.Length;
        }

        /// <summary>
        ///  Encode Effective Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Effective Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + EffectiveTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Effective Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EffectiveTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Effective Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}