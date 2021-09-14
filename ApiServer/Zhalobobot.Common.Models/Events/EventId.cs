using System;
using Zhalobobot.Common.Models.Entities;

namespace Zhalobobot.Common.Models.Events
{
    public class EventId : EntityId
    {
        public EventId(Guid id) 
            : base(EntityKind.Event, id)
        {
        }
        
        public static EventId NewId() => new(Guid.NewGuid());
    }
}