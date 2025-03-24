namespace Universe.Common
{
	public class CompanyAboutResponse : Response<CompanyAboutResponse>
	{
		public Guid Id { get; set; }
        public string Description { get; set; } = String.Empty;
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}