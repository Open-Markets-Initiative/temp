using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Tes Exec Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class TesExecId
    {
        /// <summary>
        ///  Fix Tag for Tes Exec Id
        /// </summary>
        public const ushort FixTag = 30017;

        /// <summary>
        ///  Length of Tes Exec Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Tes Exec Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + TesExecId.Length)
            {
                throw new System.Exception("Invalid Length for Tes Exec Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Tes Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TesExecId.Length;
        }

        /// <summary>
        ///  Encode Tes Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Tes Exec Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + TesExecId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Tes Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TesExecId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Tes Exec Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}