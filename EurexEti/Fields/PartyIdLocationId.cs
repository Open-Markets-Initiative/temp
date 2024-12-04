using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Location Id: Optional Fixed Length String Field
    /// </summary>

    public sealed class PartyIdLocationId
    {
        /// <summary>
        ///  Fix Tag for Party Id Location Id
        /// </summary>
        public const ushort FixTag = 20075;

        /// <summary>
        ///  Length of Party Id Location Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Party Id Location Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyIdLocationId.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Location Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Location Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyIdLocationId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyIdLocationId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PartyIdLocationId.Length;
        }

        /// <summary>
        ///  Check available length and set Party Id Location Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyIdLocationId.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Location Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Id Location Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyIdLocationId.Length;
        }

        /// <summary>
        ///  Set Party Id Location Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyIdLocationId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Id Location Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyIdLocationId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Id Location Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Id Location Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdLocationId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Location Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyIdLocationId.Length).Trim('\0');
        }
    }
}