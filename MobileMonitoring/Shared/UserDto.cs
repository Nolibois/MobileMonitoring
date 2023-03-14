namespace MobileMonitoring.Shared
{
    public record UserDto(int IdUser, string User, int DynamicsId, string Company)
    {
        #region for deserialyzation only
        public UserDto() : this(default, "", default, "") { }
        #endregion

        public UserDto(User user) : this(user.IdUser, user.FullName, user.DynamicsId, user.Company.Name) { }
    }
}
