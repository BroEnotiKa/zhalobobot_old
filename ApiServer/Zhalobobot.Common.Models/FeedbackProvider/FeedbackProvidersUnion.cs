using Zhalobobot.Common.Models.Commons;

namespace Zhalobobot.Common.Models.FeedbackProvider
{
    public record FeedbackProvidersUnion(
        FeedbackProviderId[] Providers,
        Tag[] Tags
    );
}