namespace MobileMonitoring.Shared
{
    public record UserDto(int IdUser, string User, int DynamicsId, string Company)
    {
        public UserDto(User user) : this(user.IdUser, user.FullName, user.DynamicsId, user.Company.Name) { }
    }
}
