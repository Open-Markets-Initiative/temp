using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Event Date: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class EventDate
    {
        /// <summary>
        ///  Fix Tag for Event Date
        /// </summary>
        public const ushort FixTag = 866;

        /// <summary>
        ///  Length of Event Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Event Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + EventDate.Length)
            {
                throw new System.Exception("Invalid Length for Event Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Event Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + EventDate.Length;
        }

        /// <summary>
        ///  Encode Event Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Event Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + EventDate.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Event Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EventDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Event Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}