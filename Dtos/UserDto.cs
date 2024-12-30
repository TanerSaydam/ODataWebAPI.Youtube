using ODataWebAPI.Models;

namespace ODataWebAPI.Dtos;

public sealed class UserDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public UserTypeEnum UserType { get; set; } = UserTypeEnum.User;
    public string UserTypeName { get; set; } = default!;
    public int UserTypeValue { get; set; }
    public Address Address { get; set; } = default!;
}
