using System;
using Zhalobobot.Common.Models.Events;
using Zhalobobot.Common.Models.User;

namespace Zhalobobot.Common.Models.Commons
{
    public record Feedback(
        UserId Provider,
        EventId Event,
        string Message,
        DateTime CreatedAt
    );
}