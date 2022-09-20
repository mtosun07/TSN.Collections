# TSN.Collections
> **A library that presents special generic collections, object models and LINQ extensions, that follow the original .NET patterns.**

 - **`IReadOnlySet<T>`**
 *An interface that defines the pattern while implementing `IReadOnlyCollection<T>`*
 - **`ReadOnlyHashSet<T>`**
 *A class that implents `IReadOnlySet<T>` and encapsulates an `HashSet<T>` internally in order to operate on properly; and prevents adding, removing, clearing, etc. at high-level. Also, represents convenient methods of the `HashSet<T>` pattern with return type `ReadOnlyHashSet<T>`, not `void`. These are `ExceptWith()`, `IntersectWith()`, `SymmetricExceptWith()`, `UnionWith()`, `RemoveWhere()`. Other methods are presented as is. Thus, the implementation is more LINQ-able than the original one.*
 - **`EntityEqualityComparer<T>`**
 *A generic equality comparer implementation that allows to define `Equals()` and `GetHashCode()` methods while creating an instance. Also, presents a static method named `NullAwareEquals()`* 
 - **`ToHashSet()`**
 *LINQ extension method for any `IEnumerable<T>`*
 - **`ToReadOnlySet()`**
 *LINQ extension method for any `IEnumerable<T>`* 
 - **`AsReadOnly()`**
 *LINQ extension method for any `HashSet<T>`* 


MUSTAFA TOSUN
`www.mustafatosun.net`

## Version Notes
| # | ... | @ |
|--|--|--|
| **1.0.1** | Added helper methods as LINQ extensions | 2022-09-19 |
| **1.0.0** | Initial release | 2022-09-19 |
|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|*All rights reserved.*|&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|