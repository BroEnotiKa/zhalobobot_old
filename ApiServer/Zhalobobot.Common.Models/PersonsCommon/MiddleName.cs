using Zhalobobot.Common.Models.Primitives;

namespace Zhalobobot.Common.Models.PersonsCommon
{
    public class MiddleName : CaseToleranceString
    {
        public MiddleName(string value) 
            : base(value)
        {
        }
    }
}