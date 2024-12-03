using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Var Text: Optional Fixed Length String Field
    /// </summary>

    public sealed class VarText
    {
        /// <summary>
        ///  Fix Tag for Var Text
        /// </summary>
        public const ushort FixTag = 30355;

        /// <summary>
        ///  Length of Var Text in bytes
        /// </summary>
        public const int Length = 2000;

        /// <summary>
        ///  Encode Var Text
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + VarText.Length)
            {
                throw new System.Exception("Invalid Length for Var Text");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Var Text
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, VarText.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = VarText.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + VarText.Length;
        }

        /// <summary>
        ///  Check available length and set Var Text to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + VarText.Length)
            {
                throw new System.Exception("Invalid Length for Var Text");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Var Text to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + VarText.Length;
        }

        /// <summary>
        ///  Set Var Text to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < VarText.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Var Text
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + VarText.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Var Text
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Var Text
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + VarText.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Var Text
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, VarText.Length).Trim('\0');
        }
    }
}