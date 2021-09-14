using Zhalobobot.Common.Models.Primitives;

namespace Zhalobobot.Common.Models.User
{
    public class LastName : CaseToleranceString
    {
        public LastName(string value) 
            : base(value)
        {
        }
    }
}