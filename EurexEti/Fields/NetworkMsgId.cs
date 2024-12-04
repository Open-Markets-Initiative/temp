using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Network Msg Id: Optional Fixed Length String Field
    /// </summary>

    public sealed class NetworkMsgId
    {
        /// <summary>
        ///  Fix Tag for Network Msg Id
        /// </summary>
        public const ushort FixTag = 25028;

        /// <summary>
        ///  Length of Network Msg Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Network Msg Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + NetworkMsgId.Length)
            {
                throw new System.Exception("Invalid Length for Network Msg Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Network Msg Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, NetworkMsgId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = NetworkMsgId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + NetworkMsgId.Length;
        }

        /// <summary>
        ///  Check available length and set Network Msg Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NetworkMsgId.Length)
            {
                throw new System.Exception("Invalid Length for Network Msg Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Network Msg Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + NetworkMsgId.Length;
        }

        /// <summary>
        ///  Set Network Msg Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < NetworkMsgId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Network Msg Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + NetworkMsgId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Network Msg Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Network Msg Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NetworkMsgId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Network Msg Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, NetworkMsgId.Length).Trim('\0');
        }
    }
}