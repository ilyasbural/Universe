namespace Universe.Core
{
    public class UserNetwork : Base<UserNetwork>, IEntity
    {
        public User User { get; set; } = null!;

        public UserNetwork()
        {

        }
    }
}