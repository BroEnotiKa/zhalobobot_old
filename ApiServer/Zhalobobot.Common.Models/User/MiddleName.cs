using Zhalobobot.Common.Models.Primitives;

namespace Zhalobobot.Common.Models.User
{
    public class MiddleName : CaseToleranceString
    {
        public MiddleName(string value) 
            : base(value)
        {
        }
    }
}