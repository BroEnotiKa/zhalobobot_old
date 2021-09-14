using Zhalobobot.Common.Models.Primitives;

namespace Zhalobobot.Common.Models.UsersCommon
{
    public class LastName : CaseToleranceString
    {
        public LastName(string value) 
            : base(value)
        {
        }
    }
}