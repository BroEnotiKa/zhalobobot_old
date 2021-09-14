namespace Zhalobobot.Common.Models.Entities
{
    public enum EntityKind : uint
    {
        User = 0,
        Feedback = 1,
        Event = 2,
        
        Reserved = uint.MaxValue
    }
}