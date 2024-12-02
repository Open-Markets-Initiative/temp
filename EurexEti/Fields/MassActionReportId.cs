using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Mass Action Report Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class MassActionReportId
    {
        /// <summary>
        ///  Length of Mass Action Report Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Mass Action Report Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + MassActionReportId.Length)
            {
                throw new System.Exception("Invalid Length for Mass Action Report Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mass Action Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MassActionReportId.Length;
        }

        /// <summary>
        ///  Encode Mass Action Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Mass Action Report Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + MassActionReportId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Mass Action Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MassActionReportId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mass Action Report Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}