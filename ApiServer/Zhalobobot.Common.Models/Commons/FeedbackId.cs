using System;
using Zhalobobot.Common.Models.Entities;

namespace Zhalobobot.Common.Models.Commons
{
    public class FeedbackId : EntityId
    {
        public FeedbackId(Guid id) 
            : base(EntityKind.Feedback, id)
        {
        }
    }
}