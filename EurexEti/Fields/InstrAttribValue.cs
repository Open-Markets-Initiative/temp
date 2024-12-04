using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Instr Attrib Value: Optional Fixed Length String Field
    /// </summary>

    public sealed class InstrAttribValue
    {
        /// <summary>
        ///  Fix Tag for Instr Attrib Value
        /// </summary>
        public const ushort FixTag = 872;

        /// <summary>
        ///  Length of Instr Attrib Value in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Instr Attrib Value
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + InstrAttribValue.Length)
            {
                throw new System.Exception("Invalid Length for Instr Attrib Value");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Instr Attrib Value
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, InstrAttribValue.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = InstrAttribValue.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + InstrAttribValue.Length;
        }

        /// <summary>
        ///  Check available length and set Instr Attrib Value to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + InstrAttribValue.Length)
            {
                throw new System.Exception("Invalid Length for Instr Attrib Value");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Instr Attrib Value to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + InstrAttribValue.Length;
        }

        /// <summary>
        ///  Set Instr Attrib Value to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < InstrAttribValue.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Instr Attrib Value
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + InstrAttribValue.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Instr Attrib Value
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Instr Attrib Value
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + InstrAttribValue.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Instr Attrib Value
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, InstrAttribValue.Length).Trim('\0');
        }
    }
}