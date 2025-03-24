namespace Universe.Core
{
    public class Occupation : Base<Occupation>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public Occupation()
        {

        }
    }
}