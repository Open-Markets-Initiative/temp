using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Fill Exec Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class FillExecId
    {
        /// <summary>
        ///  Length of Fill Exec Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Fill Exec Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + FillExecId.Length)
            {
                throw new System.Exception("Invalid Length for Fill Exec Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Fill Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + FillExecId.Length;
        }

        /// <summary>
        ///  Encode Fill Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Fill Exec Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + FillExecId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Fill Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + FillExecId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Fill Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}