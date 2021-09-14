using System;
using Zhalobobot.Common.Models.Entities;

namespace Zhalobobot.Common.Models.FeedbackProvider
{
    public class FeedbackProviderId : EntityId
    {
        public FeedbackProviderId(Guid id) 
            : base(EntityKind.FeedbackProvider, id)
        {
        }
        
        public static FeedbackProviderId NewId() => new(Guid.NewGuid());
    }
}