using Zhalobobot.Common.Models.Commons;
using Zhalobobot.Common.Models.PersonsCommon;

namespace Zhalobobot.Common.Models.FeedbackProvider
{
    public record FeedbackProvider(
        FeedbackProviderId Id,
        PersonName? Name,
        ContactInformation ContactInformation,
        Tag[] Tags
    );
}