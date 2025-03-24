namespace Universe.DataAccess
{
    public class UserFollowerRepositoryEF : RepositoryBase<Core.UserFollower>, Core.IUserFollower
    {
        public UserFollowerRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}