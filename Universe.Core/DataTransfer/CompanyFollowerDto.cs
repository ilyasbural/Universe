﻿namespace Universe.Core
{
    public class CompanyFollowerRegisterDto
    {
        public Guid UserId { get; set; }
    }

    public class CompanyFollowerUpdateDto
    {
        public Guid Id { get; set; }
    }

    public class CompanyFollowerDeleteDto
    {
        public Guid Id { get; set; }
    }

    public class CompanyFollowerSelectDto
    {
        public Guid Id { get; set; }
    }
}