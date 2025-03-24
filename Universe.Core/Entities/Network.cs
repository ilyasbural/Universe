namespace Universe.Core
{
    public class Network : Base<Network>, IEntity
    {
        public string Name { get; set; } = String.Empty;

        public Network()
        {

        }
    }
}