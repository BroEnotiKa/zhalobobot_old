using Zhalobobot.Common.Models.PersonsCommon;

namespace Zhalobobot.Common.Models.FeedbackReceiver
{
    public record FeedbackReceiver(
        FeedbackReceiverId Id,
        PersonName? Name,
        ContactInformation ContactInformation
    ); // Union -> [Union, Receiver]
}