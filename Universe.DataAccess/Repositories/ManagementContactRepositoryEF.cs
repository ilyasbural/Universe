namespace Universe.DataAccess
{
    public class ManagementContactRepositoryEF : RepositoryBase<Core.ManagementContact>, Core.IManagementContact
    {
        public ManagementContactRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}