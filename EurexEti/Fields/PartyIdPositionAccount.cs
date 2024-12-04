using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Position Account: Optional Fixed Length String Field
    /// </summary>

    public sealed class PartyIdPositionAccount
    {
        /// <summary>
        ///  Fix Tag for Party Id Position Account
        /// </summary>
        public const ushort FixTag = 20038;

        /// <summary>
        ///  Length of Party Id Position Account in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Party Id Position Account
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PartyIdPositionAccount.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Position Account");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Position Account
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PartyIdPositionAccount.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PartyIdPositionAccount.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PartyIdPositionAccount.Length;
        }

        /// <summary>
        ///  Check available length and set Party Id Position Account to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyIdPositionAccount.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Position Account");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Id Position Account to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyIdPositionAccount.Length;
        }

        /// <summary>
        ///  Set Party Id Position Account to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PartyIdPositionAccount.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Party Id Position Account
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PartyIdPositionAccount.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Id Position Account
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Party Id Position Account
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdPositionAccount.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Position Account
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PartyIdPositionAccount.Length).Trim('\0');
        }
    }
}