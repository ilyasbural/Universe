namespace Universe.Core
{
    public class CompanyFollower : Base<CompanyFollower>, IEntity
    {
        public User User { get; set; } = new User();

        public CompanyFollower()
        {

        }
    }
}