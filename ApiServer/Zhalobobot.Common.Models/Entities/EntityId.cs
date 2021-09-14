using System;
using System.Diagnostics.CodeAnalysis;
using Zhalobobot.Common.Models.Primitives;

namespace Zhalobobot.Common.Models.Entities
{
     public class EntityId : IEquatable<EntityId>, IComparable<EntityId>
    {
        private readonly EntityKind kind;
        private readonly Guid id;
        public EntityId(EntityKind kind, Guid id)
        {
            this.kind = kind;
            this.id = id;
        }

        public static EntityId CreateSpecialId(Guid value) => new(EntityKind.Reserved, value);

        public static EntityId Parse(string s) =>
            TryParse(s, out var result) ? result : throw new ArgumentException($"Can't parse '{s}' as Entity.");

        public static bool TryParse(string s, [NotNullWhen(true)] out EntityId? result)
        {
            result = null;

            var parts = s.Split('/');
            if (parts.Length != 2)
                return false;

            if (!Enum<EntityKind>.TryParse(parts[0], out var entityKind, true))
                return false;

            if (!Guid.TryParse(parts[1], out var id))
                return false;

            result = new EntityId(entityKind, id);
            return true;
        }

        public EntityKind GetKind() => kind;
        public Guid GetId() => id;

        public override string ToString() => $"{kind}/{id:N}";

        public string ToShortString() => id.ToString("N");

        #region Compare members

        public int CompareTo(EntityId? another)
        {
            if (another == null)
                return 1;

            if (kind.CompareTo(another.kind) is var kindCompareResult && kindCompareResult != 0)
                return kindCompareResult;

            return id.CompareTo(another.id);
        }

        #endregion

        #region Equality members

        public bool Equals(EntityId? other) => other?.kind == kind && id == other.id;

        public override bool Equals(object obj) => Equals(obj as EntityId);

        public override int GetHashCode() => id.GetHashCode();

        public static bool operator==(EntityId? left, EntityId? right) => Equals(left, right);

        public static bool operator!=(EntityId? left, EntityId? right) => !(left == right);

        #endregion
    }
}