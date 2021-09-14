namespace Zhalobobot.Common.Models.User
{
    public record User(
        UserId Id,
        UserName? Name,
        ContactInformation ContactInformation
    );
}
