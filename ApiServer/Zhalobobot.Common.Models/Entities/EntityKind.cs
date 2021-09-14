namespace Zhalobobot.Common.Models.Entities
{
    public enum EntityKind : uint
    {
        FeedbackProvider = 1,
        FeedbackReceiver = 2,
        
        Reserved = uint.MaxValue
    }
}