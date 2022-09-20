using System.Collections.Generic;
using TSN.Collections.Generic;

namespace TSN.Collections
{
    public static class LinqExtensions
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> collection, IEqualityComparer<T> comparer = null) => new HashSet<T>(collection, comparer);
        public static ReadOnlyHashSet<T> AsReadOnly<T>(this HashSet<T> collection, IEqualityComparer<T> comparer = null) => new ReadOnlyHashSet<T>(collection, comparer ?? collection?.Comparer);
        public static IReadOnlySet<T> ToReadOnlySet<T>(this IEnumerable<T> collection, IEqualityComparer<T> comparer = null) => new ReadOnlyHashSet<T>(collection, comparer);
    }
}