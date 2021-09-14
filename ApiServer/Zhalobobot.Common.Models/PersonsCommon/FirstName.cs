using Zhalobobot.Common.Models.Primitives;

namespace Zhalobobot.Common.Models.PersonsCommon
{
    public class FirstName : CaseToleranceString
    {
        public FirstName(string value)
            : base(value)
        {
        }
    }
}