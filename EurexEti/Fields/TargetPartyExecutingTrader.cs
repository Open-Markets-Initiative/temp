using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Target Party Executing Trader: Optional Fixed Length String Field
    /// </summary>

    public sealed class TargetPartyExecutingTrader
    {
        /// <summary>
        ///  Fix Tag for Target Party Executing Trader
        /// </summary>
        public const ushort FixTag = 22602;

        /// <summary>
        ///  Length of Target Party Executing Trader in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Encode Target Party Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + TargetPartyExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Target Party Executing Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Target Party Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, TargetPartyExecutingTrader.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = TargetPartyExecutingTrader.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + TargetPartyExecutingTrader.Length;
        }

        /// <summary>
        ///  Check available length and set Target Party Executing Trader to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TargetPartyExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Target Party Executing Trader");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Target Party Executing Trader to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TargetPartyExecutingTrader.Length;
        }

        /// <summary>
        ///  Set Target Party Executing Trader to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < TargetPartyExecutingTrader.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Target Party Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + TargetPartyExecutingTrader.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Target Party Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Target Party Executing Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TargetPartyExecutingTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Target Party Executing Trader
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, TargetPartyExecutingTrader.Length).Trim('\0');
        }
    }
}