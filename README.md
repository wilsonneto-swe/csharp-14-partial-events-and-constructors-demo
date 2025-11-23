# Partial Events and Constructors - C# 14 New features

Before C# 14 we weren't able to define partial constructors or events, this is a new feature presented in C#, the below code is a C# 14 valid code:

```csharp
public partial class User
{
    // now we can define partial constructors
    public partial User(string name);

    // also partial events
    public partial event Action<string> NameChanged;

    public string Name { get; private set; }

    public partial void Rename(string newName);
}
```

This is a great enhacement, mainly for source generation tooling, as now we can partially define constructors, what provides a great way to use source generator to generate even the class constructors.
