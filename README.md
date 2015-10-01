# Objective

Trying to learn C# basics by Test Driving a simple fizzbuzz program.



## Things I have learnt

In a `List`, because C# is ['strongly typed'](http://whatis.techtarget.com/definition/strongly-typed), you have to define the type of all the elements in the `List` so you can't combine Strings and Integers within the same `List`

-----

When defining a method you have to define both the types of input and types of output.
```cs
public List<string> GetFizzBuzz (int ceiling)
{
  //body
}

public string GetNextFizzBuzz(int position)
{
  //body
}
```
In these methods I am defining that the input arguments `ceiling` and `position` must be `integers`.

In the method `GetFizzBuzz` I am defining that the output must be a `List` of strings; `List<string>` and the ouput of `GetNextFizzBuzz` must be a `string`

-----

## Issues encountered

#### Problem #1

In `Test.cs` I had an error compiling when using
```cs
var expected = new List<int>{1,2};
```
the error was
`The non-generic type 'NUnit.Framework.List' cannot be used with the type arguments.`

#### Solution #1

In C# you have to explicitly define the libraries you are using with their 'namespaces'. You can get the namespaces by looking at the class on Microsoft Developer Network for example the [`List<T> Class`](https://msdn.microsoft.com/en-us/library/6sh2ey19) shows the the namespace for `List` is [`System.Collections.Generic`](https://msdn.microsoft.com/en-us/library/system.collections.generic)

I added the following line on line 3 of `Test.cs`

```cs
using System.Collections.Generic;
```

--------
