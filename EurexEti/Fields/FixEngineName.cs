using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Fix Engine Name: Optional Fixed Length String Field
    /// </summary>

    public static class FixEngineName
    {
        /// <summary>
        ///  Fix Tag for Fix Engine Name
        /// </summary>
        public const ushort FixTag = 1600;

        /// <summary>
        ///  Length of Fix Engine Name in bytes
        /// </summary>
        public const int Length = 30;

        /// <summary>
        ///  Encode Fix Engine Name
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + FixEngineName.Length)
            {
                throw new System.Exception("Invalid Length for Fix Engine Name");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Fix Engine Name
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, FixEngineName.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = FixEngineName.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + FixEngineName.Length;
        }

        /// <summary>
        ///  Check available length and set Fix Engine Name to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + FixEngineName.Length)
            {
                throw new System.Exception("Invalid Length for Fix Engine Name");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Fix Engine Name to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + FixEngineName.Length;
        }

        /// <summary>
        ///  Set Fix Engine Name to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < FixEngineName.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Fix Engine Name
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + FixEngineName.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Fix Engine Name
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Fix Engine Name
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + FixEngineName.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Fix Engine Name
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, FixEngineName.Length).Trim('\0');
        }
    }
}