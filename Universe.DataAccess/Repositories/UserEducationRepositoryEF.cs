namespace Universe.DataAccess
{
    public class UserEducationRepositoryEF : RepositoryBase<Core.UserEducation>, Core.IUserEducation
    {
        public UserEducationRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}