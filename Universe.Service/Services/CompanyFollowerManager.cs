namespace Universe.Service
{
    using Core;
	using Common;
	using AutoMapper;
    using FluentValidation;

    public class CompanyFollowerManager : BusinessObject<CompanyFollower>, ICompanyFollowerService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<CompanyFollower> Validator;

        public CompanyFollowerManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CompanyFollower> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }

        public async Task<Response<CompanyFollowerResponse>> InsertAsync(CompanyFollowerRegisterDto Model)
        {
            List<User> User = await UnitOfWork.User.SelectAsync(x => x.Id == Model.UserId);
            Data = Mapper.Map<CompanyFollower>(Model);
            Data.Id = Guid.NewGuid();
            Data.User = User.FirstOrDefault()!;
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<CompanyFollower>(Data);
            await UnitOfWork.CompanyFollower.InsertAsync(Data);
            Complete = await UnitOfWork.SaveChangesAsync();

            return new Response<CompanyFollowerResponse>
            {
                Success = Complete
            };
        }

        public async Task<Response<CompanyFollowerResponse>> UpdateAsync(CompanyFollowerUpdateDto Model)
        {
            Collection = await UnitOfWork.CompanyFollower.SelectAsync(x => x.Id == Model.Id);
            Data = Mapper.Map<CompanyFollower>(Collection[0]);
            Data.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Data);

            await UnitOfWork.CompanyFollower.UpdateAsync(Data);
            await UnitOfWork.SaveChangesAsync();

            return new Response<CompanyFollowerResponse>
            {
                Message = "Success",
                Success = 1,
                IsValidationError = false
            };
        }

        public async Task<Response<CompanyFollowerResponse>> DeleteAsync(CompanyFollowerDeleteDto Model)
        {
            Collection = await UnitOfWork.CompanyFollower.SelectAsync(x => x.Id == Model.Id);
            Data = Mapper.Map<CompanyFollower>(Collection[0]);

            await UnitOfWork.CompanyFollower.DeleteAsync(Data);
            await UnitOfWork.SaveChangesAsync();

            return new Response<CompanyFollowerResponse>
            {
                Message = "Success",
                Success = 1,
                IsValidationError = false
            };
        }

        public async Task<Response<CompanyFollowerResponse>> SelectAsync(CompanyFollowerSelectDto Model)
        {
            Collection = await UnitOfWork.CompanyFollower.SelectAsync(x => x.IsActive == true);
            return new Response<CompanyFollowerResponse>
            {
				ResponseCollection = Collection.Select(x => new CompanyFollowerResponse { Id = x.Id }).ToList()
			};
        }

        public async Task<Response<CompanyFollowerResponse>> SelectSingleAsync(CompanyFollowerSelectDto Model)
        {
            Collection = await UnitOfWork.CompanyFollower.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
            return new Response<CompanyFollowerResponse>
            {
				ResponseCollection = Collection.Select(x => new CompanyFollowerResponse { Id = x.Id }).ToList()
			};
        }
    }
}