using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mass Action Report Id: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class MassActionReportId
    {
        /// <summary>
        ///  Fix Tag for Mass Action Report Id
        /// </summary>
        public const ushort FixTag = 1369;

        /// <summary>
        ///  Length of Mass Action Report Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Mass Action Report Id
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

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
        ///  Check available length and set Mass Action Report Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MassActionReportId.Length)
            {
                throw new System.Exception("Invalid Length for Mass Action Report Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Mass Action Report Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MassActionReportId.Length;
        }

        /// <summary>
        ///  Set Mass Action Report Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Mass Action Report Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + MassActionReportId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Mass Action Report Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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