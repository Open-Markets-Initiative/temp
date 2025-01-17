using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Default Cstm Appl Ver Sub Id: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class DefaultCstmApplVerSubId
    {
        /// <summary>
        ///  Fix Tag for Default Cstm Appl Ver Sub Id
        /// </summary>
        public const ushort FixTag = 28763;

        /// <summary>
        ///  Length of Default Cstm Appl Ver Sub Id in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Encode Default Cstm Appl Ver Sub Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + DefaultCstmApplVerSubId.Length)
            {
                throw new System.Exception("Invalid Length for Default Cstm Appl Ver Sub Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Default Cstm Appl Ver Sub Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, DefaultCstmApplVerSubId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = DefaultCstmApplVerSubId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + DefaultCstmApplVerSubId.Length;
        }

        /// <summary>
        ///  Check available length and set Default Cstm Appl Ver Sub Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + DefaultCstmApplVerSubId.Length)
            {
                throw new System.Exception("Invalid Length for Default Cstm Appl Ver Sub Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Default Cstm Appl Ver Sub Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + DefaultCstmApplVerSubId.Length;
        }

        /// <summary>
        ///  Set Default Cstm Appl Ver Sub Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < DefaultCstmApplVerSubId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Default Cstm Appl Ver Sub Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + DefaultCstmApplVerSubId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Default Cstm Appl Ver Sub Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + DefaultCstmApplVerSubId.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Default Cstm Appl Ver Sub Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + DefaultCstmApplVerSubId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Default Cstm Appl Ver Sub Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, DefaultCstmApplVerSubId.Length).Trim();
        }
    }
}