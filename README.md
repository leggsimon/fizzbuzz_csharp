# Objective

Trying to learn C# basics by doing a fizzbuzz game

## Issues arisen

#### Problem

In `Test.cs` I had an error compiling when using
```cs
var expected = new List<int>{1,2};
```
the error was
`The non-generic type 'NUnit.Framework.List' cannot be used with the type arguments`

#### Solution

In C# you have to explicitly define the libraries you are using with their 'namespaces'. You can get the namespaces by looking at the class on Microsoft Developer Network for example the [`List<T> Class`](https://msdn.microsoft.com/en-us/library/6sh2ey19) shows the the namespace for `List` is [`System.Collections.Generic`](https://msdn.microsoft.com/en-us/library/system.collections.generic)

I added the following line on line 3 of `Test.cs`

```cs
using System.Collections.Generic;
```

--------
