using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Trade Report Text: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class BasketTradeReportText
    {
        /// <summary>
        ///  Fix Tag for Basket Trade Report Text
        /// </summary>
        public const ushort FixTag = 25168;

        /// <summary>
        ///  Length of Basket Trade Report Text in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Encode Basket Trade Report Text
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + BasketTradeReportText.Length)
            {
                throw new System.Exception("Invalid Length for Basket Trade Report Text");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Basket Trade Report Text
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, BasketTradeReportText.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = BasketTradeReportText.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + BasketTradeReportText.Length;
        }

        /// <summary>
        ///  Check available length and set Basket Trade Report Text to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + BasketTradeReportText.Length)
            {
                throw new System.Exception("Invalid Length for Basket Trade Report Text");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Basket Trade Report Text to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + BasketTradeReportText.Length;
        }

        /// <summary>
        ///  Set Basket Trade Report Text to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < BasketTradeReportText.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Basket Trade Report Text
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + BasketTradeReportText.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Basket Trade Report Text
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + BasketTradeReportText.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Basket Trade Report Text
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BasketTradeReportText.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Basket Trade Report Text
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, BasketTradeReportText.Length).Trim();
        }
    }
}