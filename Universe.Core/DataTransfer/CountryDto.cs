namespace Universe.Core
{
    public class CountryRegisterDto
    {
		public string Name { get; set; } = string.Empty;
	}

    public class CountryUpdateDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }

    public class CountryDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class CountrySelectDto
    {
        public Guid Id { get; set; }
    }
}