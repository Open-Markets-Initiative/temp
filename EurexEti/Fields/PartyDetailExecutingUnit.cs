using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Detail Executing Unit: Optional Fixed Length String Field
    /// </summary>

    public sealed class PartyDetailExecutingUnit
    {
        /// <summary>
        ///  Fix Tag for Party Detail Executing Unit
        /// </summary>
        public const ushort FixTag = 22259;

        /// <summary>
        ///  Length of Party Detail Executing Unit in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Encode Party Detail Executing Unit
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyDetailExecutingUnit.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Executing Unit");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Detail Executing Unit
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyDetailExecutingUnit.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyDetailExecutingUnit.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PartyDetailExecutingUnit.Length;
        }

        /// <summary>
        ///  Check available length and set Party Detail Executing Unit to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyDetailExecutingUnit.Length)
            {
                throw new System.Exception("Invalid Length for Party Detail Executing Unit");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Detail Executing Unit to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyDetailExecutingUnit.Length;
        }

        /// <summary>
        ///  Set Party Detail Executing Unit to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyDetailExecutingUnit.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Detail Executing Unit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyDetailExecutingUnit.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Detail Executing Unit
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Detail Executing Unit
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyDetailExecutingUnit.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Detail Executing Unit
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyDetailExecutingUnit.Length).Trim('\0');
        }
    }
}