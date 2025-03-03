namespace Universe.Common
{
	public class Response<T>
	{
		public T ResponseData { get; set; } = default(T)!;
		public List<T> Collection { get; set; } = null!;
		public bool IsValidationError { get; set; }
		public int Success { get; set; } = 0;
		public string Message { get; set; } = null!;
        public Response() { }
    }
}