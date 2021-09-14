using Zhalobobot.Common.Models.Commons;
using Zhalobobot.Common.Models.UsersCommon;

namespace Zhalobobot.Common.Models.FeedbackProvider
{
    public record FeedbackProvider(
        FeedbackProviderId Id,
        UserName? Name,
        ContactInformation ContactInformation,
        Tag[] Tags
    );
}