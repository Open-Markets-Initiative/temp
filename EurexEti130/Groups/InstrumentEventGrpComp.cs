using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Instrument Event Grp Comp Message Methods
/// </summary>

public static partial class InstrumentEventGrpComp
{
    /// <summary>
    ///  Fix Tag for Instrument Event Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39114;

    /// <summary>
    ///  Encode Instrument Event Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup instrumentEventGrpComp, out int current)
    {
        current = offset;

        foreach (var group in instrumentEventGrpComp.sectionList)
        {
            if (group.TryGetInt(EventDate.FixTag, out var eventDate))
            {
                EventDate.Encode(pointer, current, (uint)eventDate, out current);
            }
            else
            {
                EventDate.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(EventType.FixTag, out var eventType))
            {
                EventType.Encode(pointer, current, (byte)eventType, out current);
            }
            else
            {
                EventType.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Instrument Event Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoEvents.FixTag, count);

        while (count-- > 0)
        {
            if (EventDate.TryDecode(pointer, current, out var eventDate, out current))
            {
                message.AppendInt(EventDate.FixTag, (int)eventDate);
            }

            if (EventType.TryDecode(pointer, current, out var eventType, out current))
            {
                message.AppendInt(EventType.FixTag, eventType);
            }

            current += Pad3.Length;

        }
    }
}
