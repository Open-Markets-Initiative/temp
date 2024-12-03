using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Mass Order Report Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class MassOrderReportId
    {
        /// <summary>
        ///  Fix Tag for Mass Order Report Id
        /// </summary>
        public const ushort FixTag = 2424;

        /// <summary>
        ///  Length of Mass Order Report Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Mass Order Report Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + MassOrderReportId.Length)
            {
                throw new System.Exception("Invalid Length for Mass Order Report Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mass Order Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MassOrderReportId.Length;
        }

        /// <summary>
        ///  Encode Mass Order Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Mass Order Report Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + MassOrderReportId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Mass Order Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MassOrderReportId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mass Order Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}