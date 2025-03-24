namespace Universe.Core
{
    public class CompanySettings : Base<CompanySettings>, IEntity
    {
        public Company Company { get; set; } = new Company();

        public CompanySettings()
        {

        }
    }
}