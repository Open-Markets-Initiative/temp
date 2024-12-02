using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Fix Cl Ord Id: Optional Fixed Length String Field
    /// </summary>

    public sealed class FixClOrdId
    {
        /// <summary>
        ///  Length of Fix Cl Ord Id in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Encode Fix Cl Ord Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + FixClOrdId.Length)
            {
                throw new System.Exception("Invalid Length for Fix Cl Ord Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Fix Cl Ord Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, FixClOrdId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = FixClOrdId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + FixClOrdId.Length;
        }

        /// <summary>
        ///  Check available length and set Fix Cl Ord Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + FixClOrdId.Length)
            {
                throw new System.Exception("Invalid Length for Fix Cl Ord Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Fix Cl Ord Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + FixClOrdId.Length;
        }

        /// <summary>
        ///  Set Fix Cl Ord Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < FixClOrdId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Fix Cl Ord Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + FixClOrdId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Fix Cl Ord Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Fix Cl Ord Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + FixClOrdId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Fix Cl Ord Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, FixClOrdId.Length).Trim('\0');
        }
    }
}