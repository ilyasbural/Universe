namespace Universe.Common
{
	public class CompanyResponse : Response<CompanyResponse>
	{
		public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

        public CompanyResponse()
        {
            
        }
    }
}