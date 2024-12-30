using Ardalis.SmartEnum;

namespace ODataWebAPI.Models;

public sealed class User
{
    public User()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string FullName => string.Join(" ", FirstName, LastName);
    public UserTypeEnum UserType { get; set; } = UserTypeEnum.User;
    public Address Address { get; set; } = default!;

}

public sealed class UserTypeEnum : SmartEnum<UserTypeEnum>
{
    public static UserTypeEnum User = new("User", 0);
    public static UserTypeEnum Admin = new("Admin", 1);
    public UserTypeEnum(string name, int value) : base(name, value)
    {
    }
}

public sealed record Address(
    string City,
    string Town,
    string FullAddress);
