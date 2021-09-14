using System;
using System.Collections.Generic;
using Zhalobobot.Common.Models.Entities;
using Zhalobobot.Common.Models.Helpers;

namespace Zhalobobot.Common.Models.FeedbackReceiver
{
    public class FeedbackReceiverId : EntityId
    {
        public FeedbackReceiverId(Guid id) 
            : base(EntityKind.FeedbackReceiver, id)
        {
        }
        
        public static FeedbackReceiverId NewId() => new(Guid.NewGuid());
    }
}