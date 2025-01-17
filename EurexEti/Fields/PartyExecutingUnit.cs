using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Executing Unit: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class PartyExecutingUnit
    {
        /// <summary>
        ///  Fix Tag for Party Executing Unit
        /// </summary>
        public const ushort FixTag = 22059;

        /// <summary>
        ///  Length of Party Executing Unit in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Encode Party Executing Unit
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyExecutingUnit.Length)
            {
                throw new System.Exception("Invalid Length for Party Executing Unit");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Executing Unit
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyExecutingUnit.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyExecutingUnit.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + PartyExecutingUnit.Length;
        }

        /// <summary>
        ///  Check available length and set Party Executing Unit to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyExecutingUnit.Length)
            {
                throw new System.Exception("Invalid Length for Party Executing Unit");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Executing Unit to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyExecutingUnit.Length;
        }

        /// <summary>
        ///  Set Party Executing Unit to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyExecutingUnit.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Executing Unit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyExecutingUnit.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Executing Unit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + PartyExecutingUnit.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Executing Unit
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyExecutingUnit.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Executing Unit
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyExecutingUnit.Length).Trim();
        }
    }
}