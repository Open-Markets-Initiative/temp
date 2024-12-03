using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Multi Leg Reporting Type: Enum
    /// </summary>

    public sealed class MultiLegReportingType
    {
        /// <summary>
        ///  Single instrument
        /// </summary>
        public const byte Singlesecurity = 1;

        /// <summary>
        ///  Complex instrument
        /// </summary>
        public const byte Individuallegofamultilegsecurity = 2;

        /// <summary>
        ///  Fix Tag for Multi Leg Reporting Type
        /// </summary>
        public const ushort FixTag = 442;

        /// <summary>
        ///  Length of Multi Leg Reporting Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Multi Leg Reporting Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MultiLegReportingType.Length)
            {
                throw new System.Exception("Invalid Length for Multi Leg Reporting Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Multi Leg Reporting Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MultiLegReportingType.Length;
        }

        /// <summary>
        ///  TryDecode Multi Leg Reporting Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MultiLegReportingType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Multi Leg Reporting Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MultiLegReportingType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Multi Leg Reporting Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}