using System;
using System.Collections.Generic;
using Zhalobobot.Common.Models.Entities;
using Zhalobobot.Common.Models.Helpers;

namespace Zhalobobot.Common.Models.FeedbackProvider
{
    public class FeedbackProviderId : EntityId
    {
        private static readonly IReadOnlyCollection<EntityKind> SupportedKinds = new HashSet<EntityKind>
        {
            EntityKind.FeedbackProvider
        };

        public FeedbackProviderId(EntityKind kind, Guid id) 
            : base(kind, id)
        {
            kind.ThrowIfInvalidKind(SupportedKinds);
        }
    }
}