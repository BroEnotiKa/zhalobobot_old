using Zhalobobot.Common.Models.Primitives;

namespace Zhalobobot.Common.Models.Commons
{
    public class Tag : CaseToleranceString
    {
        public Tag(string value) 
            : base(value)
        {
        }
    }
}