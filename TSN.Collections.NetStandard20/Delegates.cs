namespace TSN.Collections
{
    public delegate bool CompareEquality<in T>(T x, T y);
    public delegate int GetHashCode<in T>(T obj);
}