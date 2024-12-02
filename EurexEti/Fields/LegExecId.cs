using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Leg Exec Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class LegExecId
    {
        /// <summary>
        ///  Length of Leg Exec Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Leg Exec Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + LegExecId.Length)
            {
                throw new System.Exception("Invalid Length for Leg Exec Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + LegExecId.Length;
        }

        /// <summary>
        ///  Encode Leg Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Leg Exec Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + LegExecId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Leg Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegExecId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}