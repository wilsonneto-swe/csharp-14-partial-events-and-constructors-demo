# Partial Events and Constructors - C# 14 New features

Before C# 14, we weren't able to define partial constructors or events. These are new features introduced in C# 14. The code below is valid C# 14 code:

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

This is a great enhancement, mainly for source generation tooling, as we can now define partial constructors, which provides a great way to use source generators to generate even the class constructors.
