namespace Universe.DataAccess
{
    public class CompanyFollowerRepositoryEF : RepositoryBase<Core.CompanyFollower>, Core.ICompanyFollower
    {
        public CompanyFollowerRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}