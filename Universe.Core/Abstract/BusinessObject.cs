namespace Universe.Core
{
    public abstract class BusinessObject<T>
    {
        protected T Data { get; set; } = default!;
        protected List<T> Collection { get; set; } = null!;
        protected int Complete { get; set; }

        public BusinessObject()
        {

        }
    }
}