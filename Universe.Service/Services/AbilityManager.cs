namespace Universe.Service
{
    using Core;
    using Common;
    using AutoMapper;
    using FluentValidation;

    public class AbilityManager : BusinessObject<Ability>, IAbilityService
    {
        readonly IMapper Mapper;
        readonly IUnitOfWork UnitOfWork;
        readonly IValidator<Ability> Validator;

        public AbilityManager(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Ability> validator)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
            Validator = validator;
        }   

        public async Task<Response<AbilityResponse>> InsertAsync(AbilityRegisterDto Model)
        {
            Data = Mapper.Map<Ability>(Model);
            Data.Id = Guid.NewGuid();
            Data.RegisterDate = DateTime.Now;
            Data.UpdateDate = DateTime.Now;
            Data.IsActive = true;

            Validator.ValidateAndThrow<Ability>(Data);
            await UnitOfWork.Ability.InsertAsync(Data);
            Complete = await UnitOfWork.SaveChangesAsync();

            return new Response<AbilityResponse>
            {
                Success = Complete
            };
        }

        public async Task<Response<AbilityResponse>> UpdateAsync(AbilityUpdateDto Model)
        {
            Collection = await UnitOfWork.Ability.SelectAsync(x => x.Id == Model.Id);
            Data = Collection.FirstOrDefault()!;
            Data.Name = Model.Name;
            Data.UpdateDate = DateTime.Now;
            Validator.ValidateAndThrow(Data);

            await UnitOfWork.Ability.UpdateAsync(Data);
            Complete = await UnitOfWork.SaveChangesAsync();

            return new Response<AbilityResponse>
            {
                ResponseData = Mapper.Map<AbilityResponse>(Data),
                Success = Complete
            };
        }

        public async Task<Response<AbilityResponse>> DeleteAsync(AbilityDeleteDto Model)
        {
            Collection = await UnitOfWork.Ability.SelectAsync(x => x.Id == Model.Id);
            Data = Mapper.Map<Ability>(Collection[0]);

            await UnitOfWork.Ability.DeleteAsync(Data);
            Complete = await UnitOfWork.SaveChangesAsync();

            return new Response<AbilityResponse>
            {
                Success = Complete
            };
        }

        public async Task<Response<AbilityResponse>> SelectAsync(AbilitySelectDto Model)
        {
            Collection = await UnitOfWork.Ability.SelectAsync(x => x.IsActive == true);
            return new Response<AbilityResponse>
            {
                ResponseCollection = Collection.Select(x => new AbilityResponse 
                {
                    Id = x.Id, 
                    Name = x.Name, 
                    RegisterDate = x.RegisterDate, 
                    UpdateDate = x.UpdateDate, 
                    IsActive = x.IsActive 
                }).ToList()
            };
        }

        public async Task<Response<AbilityResponse>> SelectSingleAsync(AbilitySelectDto Model)
        {
            Collection = await UnitOfWork.Ability.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			return new Response<AbilityResponse>
			{
				ResponseCollection = Collection.Select(x => new AbilityResponse
				{
					Id = x.Id,
					Name = x.Name,
					RegisterDate = x.RegisterDate,
					UpdateDate = x.UpdateDate,
					IsActive = x.IsActive
				}).ToList()
			};
		}
    }
}