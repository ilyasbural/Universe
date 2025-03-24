namespace Universe.DataAccess
{
    public class UserProjectRepositoryEF : RepositoryBase<Core.UserProject>, Core.IUserProject
    {
        public UserProjectRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}