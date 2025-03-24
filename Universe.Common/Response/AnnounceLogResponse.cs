namespace Universe.Common
{
    public class AnnounceLogResponse : Response<AnnounceLogResponse>
    {
        public Guid Id { get; set; }
        public string Note { get; set; } = String.Empty;
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

        public AnnounceLogResponse()
        {

        }
    }
}