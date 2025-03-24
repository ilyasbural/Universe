namespace Universe.Core
{
    public class AnnounceDetailRegisterDto
    {
		public string Description { get; set; } = String.Empty;
	}

    public class AnnounceDetailUpdateDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = String.Empty;
    }

    public class AnnounceDetailDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class AnnounceDetailSelectDto
    {
        public Guid Id { get; set; }
    }
}