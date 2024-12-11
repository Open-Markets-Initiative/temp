using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade To Quote Ratio Position: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public static class TradeToQuoteRatioPosition
    {
        /// <summary>
        ///  Fix Tag for Trade To Quote Ratio Position
        /// </summary>
        public const ushort FixTag = 25202;

        /// <summary>
        ///  Length of Trade To Quote Ratio Position in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Trade To Quote Ratio Position
        /// </summary>
        public const ushort NoValue = 0xFFFF;

        /// <summary>
        ///  Encode Trade To Quote Ratio Position
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + TradeToQuoteRatioPosition.Length)
            {
                throw new System.Exception("Invalid Length for Trade To Quote Ratio Position");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade To Quote Ratio Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TradeToQuoteRatioPosition.Length;
        }

        /// <summary>
        ///  Encode Trade To Quote Ratio Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Trade To Quote Ratio Position to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TradeToQuoteRatioPosition.Length)
            {
                throw new System.Exception("Invalid Length for Trade To Quote Ratio Position");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Trade To Quote Ratio Position to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TradeToQuoteRatioPosition.Length;
        }

        /// <summary>
        ///  Set Trade To Quote Ratio Position to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ushort*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Trade To Quote Ratio Position
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + TradeToQuoteRatioPosition.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Trade To Quote Ratio Position
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Trade To Quote Ratio Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeToQuoteRatioPosition.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade To Quote Ratio Position
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}