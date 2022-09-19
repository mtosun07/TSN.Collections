using System;
using System.Collections.Generic;

namespace TSN.Collections
{
    public sealed class EntityEqualityComparer<TEntity> : IEqualityComparer<TEntity>
    {
        static EntityEqualityComparer()
        {
            _default = new EntityEqualityComparer<TEntity>();
        }
        public EntityEqualityComparer(CompareEquality<TEntity> equals = null, GetHashCode<TEntity> getHashCode = null)
        {
            _equals = equals ?? new CompareEquality<TEntity>((x, y) => NullAwareEquals(x, y));
            _getHashCode = getHashCode ?? DefaultGetHashCode;
        }


        private static readonly EntityEqualityComparer<TEntity> _default;

        private readonly CompareEquality<TEntity> _equals;
        private readonly GetHashCode<TEntity> _getHashCode;

        public static EntityEqualityComparer<TEntity> Default => _default;



        public bool Equals(TEntity x, TEntity y) => _equals(x, y);
        public int GetHashCode(TEntity obj) => _getHashCode(obj);

        public static bool NullAwareEquals(TEntity x, TEntity y, Func<TEntity, TEntity, bool> equals = null) => (x == null == (y == null)) && (x == null || ReferenceEquals(x, y) || x.Equals(y) || (equals?.Invoke(x, y) ?? true));
        public static int DefaultGetHashCode(TEntity obj) => obj?.GetHashCode() ?? 0;
    }
}