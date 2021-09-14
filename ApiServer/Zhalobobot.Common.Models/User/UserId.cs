using System;
using Zhalobobot.Common.Models.Entities;

namespace Zhalobobot.Common.Models.User
{
    public class UserId : EntityId
    {
        public UserId(Guid id) 
            : base(EntityKind.User, id)
        {
        }
        
        public static UserId NewId() => new(Guid.NewGuid());
    }
}