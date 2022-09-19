using System;
using System.Collections.Generic;

namespace TSN.Collections.Generic
{
    public interface IReadOnlySet<T> : IReadOnlyCollection<T>
    {
        bool IsProperSubsetOf(IEnumerable<T> other);
        bool IsProperSupersetOf(IEnumerable<T> other);
        bool IsSubsetOf(IEnumerable<T> other);
        bool IsSupersetOf(IEnumerable<T> other);
        bool Overlaps(IEnumerable<T> other);
        bool SetEquals(IEnumerable<T> other);
        IReadOnlySet<T> ExceptWith(IEnumerable<T> other);
        IReadOnlySet<T> IntersectWith(IEnumerable<T> other);
        IReadOnlySet<T> SymmetricExceptWith(IEnumerable<T> other);
        IReadOnlySet<T> UnionWith(IEnumerable<T> other);
        IReadOnlySet<T> RemoveWhere(Predicate<T> match);
        void CopyTo(T[] array, int arrayIndex);
        void CopyTo(T[] array, int arrayIndex, int count);
        void CopyTo(T[] array);
    }
}