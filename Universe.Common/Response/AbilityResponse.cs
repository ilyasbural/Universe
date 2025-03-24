namespace Universe.Common
{
    public class AbilityResponse : Response<AbilityResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

        public AbilityResponse()
        {
            
        }
    }
}