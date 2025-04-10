﻿namespace Universe.Common
{
	public class CollegeResponse : Response<CollegeResponse>
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = String.Empty;
		public DateTime RegisterDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public bool IsActive { get; set; }

		public CollegeResponse()
		{

		}
	}
}