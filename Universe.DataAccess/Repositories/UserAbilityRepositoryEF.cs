namespace Universe.DataAccess
{
    public class UserAbilityRepositoryEF : RepositoryBase<Core.UserAbility>, Core.IUserAbility
    {
        public UserAbilityRepositoryEF(Microsoft.EntityFrameworkCore.DbContext dbContext) : base(dbContext)
        {

        }
    }
}