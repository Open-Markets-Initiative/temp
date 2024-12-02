using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Target Party Id Desk Id: Optional Fixed Length String Field
    /// </summary>

    public sealed class TargetPartyIdDeskId
    {
        /// <summary>
        ///  Length of Target Party Id Desk Id in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Encode Target Party Id Desk Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + TargetPartyIdDeskId.Length)
            {
                throw new System.Exception("Invalid Length for Target Party Id Desk Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Target Party Id Desk Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, TargetPartyIdDeskId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = TargetPartyIdDeskId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + TargetPartyIdDeskId.Length;
        }

        /// <summary>
        ///  Check available length and set Target Party Id Desk Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TargetPartyIdDeskId.Length)
            {
                throw new System.Exception("Invalid Length for Target Party Id Desk Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Target Party Id Desk Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TargetPartyIdDeskId.Length;
        }

        /// <summary>
        ///  Set Target Party Id Desk Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < TargetPartyIdDeskId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Target Party Id Desk Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + TargetPartyIdDeskId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Target Party Id Desk Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Target Party Id Desk Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TargetPartyIdDeskId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Target Party Id Desk Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, TargetPartyIdDeskId.Length).Trim('\0');
        }
    }
}