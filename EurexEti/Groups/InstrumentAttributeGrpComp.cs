using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Instrument Attribute Grp Comp Message Methods
/// </summary>

public static partial class InstrumentAttributeGrpComp
{
    /// <summary>
    ///  Fix Tag for Instrument Attribute Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39113;

    /// <summary>
    ///  Encode Instrument Attribute Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup instrumentAttributeGrpComp, out int current)
    {
        current = offset;

        foreach (var group in instrumentAttributeGrpComp.sectionList)
        {
            if (group.TryGetInt(InstrAttribType.FixTag, out var instrAttribType))
            {
                InstrAttribType.Encode(pointer, current, (byte)instrAttribType, out current);
            }
            else
            {
                InstrAttribType.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(InstrAttribValue.FixTag, out var instrAttribValue))
            {
                InstrAttribValue.Encode(pointer, current, instrAttribValue, out current);
            }
            else
            {
                InstrAttribValue.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Instrument Attribute Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoInstrAttrib.FixTag, count);

        while (count-- > 0)
        {
            if (InstrAttribType.TryDecode(pointer, current, out var instrAttribType, out current))
            {
                message.AppendInt(InstrAttribType.FixTag, instrAttribType);
            }

            if (InstrAttribValue.TryDecode(pointer, current, out var instrAttribValue, out current))
            {
                message.AppendString(InstrAttribValue.FixTag, instrAttribValue);
            }

            current += Pad7.Length;

        }
    }
}
