using System;

namespace Zhalobobot.Common.Models.Primitives
{
    public class CaseToleranceString
    {
        private static readonly StringComparer Comparer = StringComparer.OrdinalIgnoreCase;

        private readonly string value;

        public CaseToleranceString(string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value), "Expected not null string");

            this.value = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Expected significant string", nameof(value))
                : value;
        }

        public string AsString() => value;

        public string AsNormalizedString() => value.ToLowerInvariant();

        public override string ToString() => value;

        #region Equality memebers

        public bool Equals(CaseToleranceString? other) => other?.GetType() == GetType() && Comparer.Equals(other.value, value);

        public int CompareTo(CaseToleranceString other) => Comparer.Compare(value, other.value);

        public override bool Equals(object obj) => Equals(obj as CaseToleranceString);

        public override int GetHashCode() => Comparer.GetHashCode(value);

        public static bool operator==(CaseToleranceString? left, CaseToleranceString? right) => Equals(left, right);

        public static bool operator!=(CaseToleranceString? left, CaseToleranceString? right) => !(left == right);

        #endregion
    }
}