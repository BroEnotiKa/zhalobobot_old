using Zhalobobot.Common.Models.FeedbackReceiver;

namespace Zhalobobot.Common.Models.Events
{
    public record Event(
        EventId Id,
        string EventName,
        string Description,
        EventType Type,
        FeedbackReceiverId CreatedBy
    );
}