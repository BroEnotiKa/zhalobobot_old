using Zhalobobot.Common.Models.UsersCommon;

namespace Zhalobobot.Common.Models.FeedbackReceiver
{
    public record FeedbackReceiver(
        FeedbackReceiverId Id,
        UserName? Name,
        ContactInformation ContactInformation
    ); // Union -> [Union, Receiver]
}