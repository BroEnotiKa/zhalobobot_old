using System;
using System.Collections.Generic;
using Zhalobobot.Common.Models.Entities;
using Zhalobobot.Common.Models.Helpers;

namespace Zhalobobot.Common.Models.FeedbackReceiver
{
    public class FeedbackReceiverId : EntityId
    {
        private static readonly IReadOnlyCollection<EntityKind> SupportedKinds = new HashSet<EntityKind>
        {
            EntityKind.FeedbackReceiver
        };
        
        public FeedbackReceiverId(EntityKind kind, Guid id) 
            : base(kind, id)
        {
            kind.ThrowIfInvalidKind(SupportedKinds);
        }
    }
}