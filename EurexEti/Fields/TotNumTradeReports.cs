using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Tot Num Trade Reports: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class TotNumTradeReports
    {
        /// <summary>
        ///  Fix Tag for Tot Num Trade Reports
        /// </summary>
        public const ushort FixTag = 748;

        /// <summary>
        ///  Length of Tot Num Trade Reports in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Tot Num Trade Reports
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + TotNumTradeReports.Length)
            {
                throw new System.Exception("Invalid Length for Tot Num Trade Reports");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Tot Num Trade Reports
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TotNumTradeReports.Length;
        }

        /// <summary>
        ///  Encode Tot Num Trade Reports
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Tot Num Trade Reports
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + TotNumTradeReports.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Tot Num Trade Reports
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TotNumTradeReports.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Tot Num Trade Reports
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}