using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TSN.Collections.Generic
{
    [Serializable]
    public class ReadOnlyHashSet<T> : IReadOnlySet<T>, ISerializable, IDeserializationCallback
    {
        protected ReadOnlyHashSet(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));
            _set = (HashSet<T>)info.GetValue(nameof(_set), typeof(HashSet<T>));
        }
        public ReadOnlyHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer = null)
        {
            _set = new HashSet<T>(collection, comparer);
        }
        public ReadOnlyHashSet(params T[] items)
        {
            _set = items == null ? new HashSet<T>() : new HashSet<T>(items);
            _set.TrimExcess();
        }


        private readonly HashSet<T> _set;

        public int Count => _set.Count;
        public IEqualityComparer<T> Comparer => _set.Comparer;



        public bool Contains(T item) => _set.Contains(item);
        public bool IsProperSubsetOf(IEnumerable<T> other) => _set.IsProperSubsetOf(other);
        public bool IsProperSupersetOf(IEnumerable<T> other) => _set.IsProperSupersetOf(other);
        public bool IsSubsetOf(IEnumerable<T> other) => _set.IsSubsetOf(other);
        public bool IsSupersetOf(IEnumerable<T> other) => _set.IsSupersetOf(other);
        public bool Overlaps(IEnumerable<T> other) => _set.Overlaps(other);
        public bool SetEquals(IEnumerable<T> other) => _set.SetEquals(other);
        public IReadOnlySet<T> ExceptWith(IEnumerable<T> other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            var hs = new HashSet<T>(_set, _set.Comparer);
            hs.ExceptWith(other);
            return new ReadOnlyHashSet<T>(hs, _set.Comparer);
        }
        public IReadOnlySet<T> IntersectWith(IEnumerable<T> other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            var hs = new HashSet<T>(_set, _set.Comparer);
            hs.IntersectWith(other);
            return new ReadOnlyHashSet<T>(hs, _set.Comparer);
        }
        public IReadOnlySet<T> SymmetricExceptWith(IEnumerable<T> other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            var hs = new HashSet<T>(_set, _set.Comparer);
            hs.SymmetricExceptWith(other);
            return new ReadOnlyHashSet<T>(hs, _set.Comparer);
        }
        public IReadOnlySet<T> UnionWith(IEnumerable<T> other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));
            var hs = new HashSet<T>(_set, _set.Comparer);
            hs.UnionWith(other);
            return new ReadOnlyHashSet<T>(hs, _set.Comparer);
        }
        public IReadOnlySet<T> RemoveWhere(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            var hs = new HashSet<T>(_set, _set.Comparer);
            hs.RemoveWhere(match);
            return new ReadOnlyHashSet<T>(hs, _set.Comparer);
        }
        public void CopyTo(T[] array, int arrayIndex) => _set.CopyTo(array, arrayIndex);
        public void CopyTo(T[] array, int arrayIndex, int count) => _set.CopyTo(array, arrayIndex, count);
        public void CopyTo(T[] array) => _set.CopyTo(array);
        public IEnumerator<T> GetEnumerator() => _set.GetEnumerator();
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));
            info.AddValue(nameof(_set), _set, typeof(HashSet<T>));
        }
        public virtual void OnDeserialization(object sender) { }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_set).GetEnumerator();
    }
}