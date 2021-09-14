using System;
using System.Collections.Generic;
using System.Linq;
using Zhalobobot.Common.Models.Entities;

namespace Zhalobobot.Common.Models.Helpers
{
    public static class EntityIdHelper
    {
        public static EntityKind ThrowIfInvalidKind(this EntityKind kind, IReadOnlyCollection<EntityKind> supportedKinds)
        {
            if (!supportedKinds.Contains(kind))
                throw new ArgumentException($"Entity '{kind}' kind is not supports");
            return kind;
        }
    }
}