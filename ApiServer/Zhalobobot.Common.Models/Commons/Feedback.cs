using System;
using Zhalobobot.Common.Models.FeedbackProvider;
using Zhalobobot.Common.Models.FeedbackReceiver;

namespace Zhalobobot.Common.Models.Commons
{
    public record Feedback(
        FeedbackProviderId Provider,
        FeedbackReceiverId Receiver,
        string Message,
        TimeSpan CreatedAt
    );
}