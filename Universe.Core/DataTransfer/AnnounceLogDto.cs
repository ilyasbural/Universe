namespace Universe.Core
{
    public class AnnounceLogRegisterDto
    {
		public string Note { get; set; } = String.Empty;
	}

    public class AnnounceLogUpdateDto
    {
        public Guid Id { get; set; }
        public string Note { get; set; } = String.Empty;
    }

    public class AnnounceLogDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class AnnounceLogSelectDto
    {
        public Guid Id { get; set; }
    }
}