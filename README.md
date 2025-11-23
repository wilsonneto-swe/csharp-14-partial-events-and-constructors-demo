# Partial Events and Constructors - C# 14 New features

Before C# 14, we weren't able to define partial constructors or events. These are new features introduced in C# 14. The code below is valid C# 14 code:

```csharp
public partial class User
{
    public string Name { get; private set; }

    public partial User(string name);

    public partial event Action<string> NameChanged;

    public partial void Rename(string newName);
}
```

This is a great enhancement, mainly for source generation tooling, as we can now define partial constructors, which provides a great way to use source generators to generate even the class constructors.
