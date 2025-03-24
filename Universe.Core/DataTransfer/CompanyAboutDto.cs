﻿namespace Universe.Core
{
    public class CompanyAboutRegisterDto
    {
		public string Description { get; set; } = String.Empty;
	}

    public class CompanyAboutUpdateDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = String.Empty;
    }

    public class CompanyAboutDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class CompanyAboutSelectDto
    {
        public Guid Id { get; set; }
    }
}