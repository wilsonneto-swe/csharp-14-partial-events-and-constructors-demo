var user = new User("A User Name");
user.NameChanged += name => Console.WriteLine($"Listener: {name}");

Console.WriteLine($"Current name is: {user.Name}");

user.Rename("A New Name");

Console.WriteLine($"Current name is: {user.Name}");

    
[AutoUser]
public partial class User
{
    public string Name { get; private set; }

    public partial User(string name);

    public partial event Action<string> NameChanged;

    public partial void Rename(string newName);
}
