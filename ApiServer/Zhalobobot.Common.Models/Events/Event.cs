using Zhalobobot.Common.Models.User;

namespace Zhalobobot.Common.Models.Events
{
    public record Event(
        EventId Id,
        string EventName,
        string Description,
        EventType Type,
        UserId CreatedBy
    );
}