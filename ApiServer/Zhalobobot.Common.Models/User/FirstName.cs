using Zhalobobot.Common.Models.Primitives;

namespace Zhalobobot.Common.Models.User
{
    public class FirstName : CaseToleranceString
    {
        public FirstName(string value)
            : base(value)
        {
        }
    }
}